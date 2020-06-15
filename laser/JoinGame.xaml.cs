using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace laser
{
    public partial class JoinGame : ContentPage
    {
        public JoinGame()
        {
            InitializeComponent();
            var locations = new ObservableCollection<string>();
            locations.Add("lyngby");
            locations.Add("brondby");
            locations.Add("kobenhave");
            locationselection.ItemsSource = locations;

            var Teams = new ObservableCollection<string>();
            Teams.Add("predators");
            Teams.Add("tigers");
            Teams.Add("sharks");
            teamselection.ItemsSource = locations;
        }

        void locationChoosen(object sender, System.EventArgs e)
        {
           



        }
        void teamChoosen(object sender, System.EventArgs e)
        {
           
        }

        void startGame(object sender, System.EventArgs e)
        {

            Navigation.PushModalAsync(new WaitingRoom());

        }
    }
}
