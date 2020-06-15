using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace laser
{
    public partial class WaitingRoom : ContentPage
    {
        public WaitingRoom()
        {
            InitializeComponent();
            PlayersList.ItemsSource = new List<string>() { "adam noah", "galaxy gaurdian ", "alien" };  

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new GameScene());
        }
    }
}
