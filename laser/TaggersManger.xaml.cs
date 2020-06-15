using System;
using System.Collections.Generic;
using Syncfusion.SfRotator.XForms;
using Xamarin.Forms;

namespace laser
{
    public partial class TaggersManger : ContentPage
    {
        public List<RotatorModel> collectionOfItems;
        public TaggersManger()
        {
            InitializeComponent();
            var r = new RotatorViewModel();
            var v = r.imageCollection;
            var w = r.ImageCollection;
           
            this.BindingContext = new RotatorViewModel();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var r = rotator.SelectedIndex;
            collectionOfItems.RemoveAt(r);
            //rotator.DataSource = collectionOfItems;
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
           // collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Image() { Source = ImageSource.FromResource("laser.gun.jpeg"), Aspect = Aspect.AspectFit } });
            //rotator.DataSource = collectionOfItems;
            var button = sender as Button;
            button.IsVisible = false;
        }
    }
}
