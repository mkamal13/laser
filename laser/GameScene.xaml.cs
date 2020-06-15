using System;
using System.Collections.Generic;
using Syncfusion.SfRotator.XForms;
using Xamarin.Forms;

namespace laser
{
    public partial class GameScene : ContentPage
    {
        public GameScene()
        {
            InitializeComponent();
            List<SfRotatorItem> collectionOfItems = new List<SfRotatorItem>();
            collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Image() { Source = ImageSource.FromResource("laser.gun.jpeg"), Aspect = Aspect.AspectFit } });
            collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Image() { Source = ImageSource.FromResource("laser.gun.png"), Aspect = Aspect.AspectFit }});
            collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Image() { Source=ImageSource.FromResource("laser.Gun2.jpeg"), Aspect = Aspect.AspectFit } });
            rotator.DataSource = collectionOfItems;
            SizeChanged +=GameScene_SizeChanged;
            // photo.Source = ImageSource.FromResource("laser.Gun2.jpeg");
          //  image = embeddedImage;
           // image.Source = "gun";
        }

        void PushCharts(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new charts());
        }

        void GameScene_SizeChanged(object sender, EventArgs e)
        {
            
            var page = sender as ContentPage;
            if (page.Height>Width)
            {
                ButtonStatistics.IsVisible = true;

                rotator.IsVisible = true;
                FireMode.IsVisible = true;

            }
            else
            {
                rotator.IsVisible = false;
                FireMode.IsVisible = false;
                ButtonStatistics.IsVisible = false;
                
            }
        }




    }
}
