using System;
using System.Collections.Generic;
using Syncfusion.SfRotator.XForms;
using Xamarin.Forms;

namespace laser
{
    public partial class locationManger : ContentPage
    {
        public List<SfRotatorItem> collectionOfItems;

        public locationManger()
        {
            InitializeComponent();
            collectionOfItems = new List<SfRotatorItem>();
            collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Image() { Source = ImageSource.FromResource("laser.brondby.jpeg"), Aspect = Aspect.AspectFit } });
            collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Image() { Source = ImageSource.FromResource("laser.lyngby.jpeg"), Aspect = Aspect.AspectFit } });
            rotator.DataSource = collectionOfItems;

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var r = rotator.SelectedIndex;
            collectionOfItems.RemoveAt(r);
            rotator.DataSource = collectionOfItems;
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Image() { Source = ImageSource.FromResource("laser.new.jpeg"), Aspect = Aspect.AspectFit } });
            rotator.DataSource = collectionOfItems;
            var button = sender as Button;
            button.IsVisible = false;
        }
    }
}
