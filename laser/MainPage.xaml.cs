using Syncfusion.SfRotator.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace laser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()

        {
            InitializeComponent();
            SfRotator rotator = new SfRotator();
            this.BindingContext = new RotatorViewModel2();

           var photo =ImageSource.FromResource("laser.Gun2.jpeg");

            if (photo is Xamarin.Forms.StreamImageSource)
            {
                Xamarin.Forms.StreamImageSource objFileImageSource = (Xamarin.Forms.StreamImageSource)photo;
                //
                // Access the file that was specified:-

                string strFileName = objFileImageSource.Stream.ToString();
            }
        }

       
    }
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(System.IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            // Do your translation lookup here, using whatever method you require
            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
    public class RotatorViewModel2
    {
        public RotatorViewModel2()
        {
                       var photo =ImageSource.FromResource("laser.Gun2.jpeg");
          var r=  photo.BindingContext;
            ImageCollection.Add(new RotatorMode("movie1.png"));
            ImageCollection.Add(new RotatorMode("laser.gun.png"));
            ImageCollection.Add(new RotatorMode("gun.jpeg"));
            ImageCollection.Add(new RotatorMode("laser.gun.png"));
        }
        private List<RotatorMode> imageCollection = new List<RotatorMode>();

        public List<RotatorMode> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
    public class RotatorMode
    {
        public RotatorMode(string imagestr)
        {
            Image = imagestr;
        }
        private String _image;
        public String Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }

}