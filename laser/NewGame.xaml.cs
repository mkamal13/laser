using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace laser
{
    public partial class NewGame : ContentPage
    {
        private ObservableCollection<string> _navigiationItems;

        public ObservableCollection<string> NavigiationItems

        {

            get { return _navigiationItems; }

            set { _navigiationItems = value; }

        }
        public string PageTitle{ get; set; }
        public NewGame()
        {
            InitializeComponent();
            PageTitle = "new game";
            NavigiationItems = new ObservableCollection<string>();

            NavigiationItems.Add("teams game");

            NavigiationItems.Add("last man standing game");

            picker.ItemsSource = NavigiationItems;
            picker.OkButtonClicked += Picker_OkButtonClicked;

        }

        void Picker_OkButtonClicked(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            var selection = "teams game";
            if (picker.SelectedItem != null)

             selection = picker.SelectedItem.ToString();
            switch (selection)
            {
                 
                case "teams game":
                    Navigation.PushModalAsync(new JoinGame());
                    break;
                case "last man standing game":
                    Navigation.PushModalAsync(new JoinGame());
                    break;
            }

        }

    }
}
