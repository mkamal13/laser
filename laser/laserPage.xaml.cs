using Xamarin.Forms;
using Realms;
using Realms.Schema;
using Realms.Weaving;
using Realms.Sync;


using System.Linq;
namespace laser
{
    public partial class laserPage : ContentPage
    {
         public laserPage()
        {
            InitializeComponent();
            //this.login();

        }

       async public void login()
        {
            var credentials = Credentials.UsernamePassword(usernameField.Text, passField.Text, createUser: true);

            var authURL = new System.Uri("https://game-object.us1.cloud.realm.io/");
            var user = await User.LoginAsync(credentials, authURL);
            var realm = Realm.GetInstance();
            realm.Write(() =>
            {
                realm.Add(new Player { Health = 1, name = "apex" });

            });

            var players = realm.All<Player>();
            var count = players.Count();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            this.login();
        }    }
}
