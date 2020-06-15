using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace laser
{
    public partial class HomeMenu : ContentPage
    {
        private ObservableCollection<string> _navigiationItems;

        public ObservableCollection<string> NavigiationItems

        {

            get { return _navigiationItems; }

            set { _navigiationItems = value; }

        }


        public HomeMenu()
        {
            InitializeComponent();

            NavigiationItems = new ObservableCollection<string>();

            NavigiationItems.Add("init game");

            NavigiationItems.Add("join game");

            NavigiationItems.Add("manage taggers");

            NavigiationItems.Add("manage locations");

            picker.ItemsSource=NavigiationItems;
            picker.OkButtonClicked +=Picker_OkButtonClicked;

        }


        void Picker_OkButtonClicked(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            var selection = "init game";
            if(picker.SelectedItem!=null)
            {
                selection = picker.SelectedItem.ToString();
            }


            switch(selection)
            {
                case"init game":
                    Navigation.PushModalAsync(new NewGame());
                    break;
                case "join game":
                    Navigation.PushModalAsync(new JoinGame());
                    break;
                case "manage taggers":
                    Navigation.PushModalAsync(new TaggersManger());
                    break;
                case "manage locations":
                    Navigation.PushModalAsync(new locationManger());
                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("default switch case reached");
                    break;
            }

        }

    }
}
