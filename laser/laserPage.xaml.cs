using Xamarin.Forms;
using Realms;
using Realms.Schema;
using Realms.Weaving;
using Realms.Sync;
using System.Linq;
using System;

namespace laser
{
    public partial class laserPage : ContentPage
    {
        Realm realm;
        dynamic players;
        IDisposable token;    // Place token here, not in function where it is removed at end

        public laserPage()
        {
            InitializeComponent();
        }

        async void init()
        {
            var credentials = Credentials.UsernamePassword(usernameField.Text.ToLower(), passField.Text, createUser: false);
            var authURL = new System.Uri("https://game-object.us1.cloud.realm.io/");
            var user = await User.LoginAsync(credentials, authURL);
            var serverURL = new System.Uri("realms://game-object.us1.cloud.realm.io/~/default");
            var configuration = new SyncConfiguration(user, serverURL);
            var permission = await user.GetGrantedPermissionsAsync(Recipient.CurrentUser, millisecondTimeout: 2111);
            realm = Realm.GetInstance(configuration);
            Realms.RealmConfiguration.DefaultConfiguration = configuration;
            var realmSession = realm.GetSession();
            var state = realmSession.State;
            var permissionCondition = PermissionCondition.UserId(user.Identity);
            players = realm.All<Player>();

            // Create listenener immediately after connecting to get all changes
            token = realm.All<Player>().SubscribeForNotifications((sender, changes, error) =>
            {
                // Access changes.InsertedIndices, changes.DeletedIndices, and changes.ModifiedIndices
                Device.BeginInvokeOnMainThread(() => { countLabel.Text = players.Count.ToString(); });
            });
        }

        public void login()
        {
            this.init();
        }

        void Handle_Clicked_1(object senderButton, System.EventArgs e)
        {
            realm.Refresh();
            realm.Write(() =>
            {
                realm.Add(new Player { Health = 9, name = "papex", Latitude = 38.3, Longitude = 73.2 });
                var s = realm.GetSession();
            });
            // Later, when you no longer wish to receive notifications
            // token.Dispose();     // Don't dispose the token in each click - it will remove the listener!!!
            var count = players.Count;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            this.login();
        }
    }
}
