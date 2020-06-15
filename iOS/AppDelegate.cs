using System;
using System.Collections.Generic;
using System.Linq;
using Syncfusion.SfPicker;
using Foundation;
using UIKit;
using Syncfusion.SfPicker.XForms.iOS;
using Syncfusion.SfRotator.XForms.iOS;

namespace laser.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            SfPickerRenderer.Init();
            Syncfusion.SfChart.XForms.iOS.Renderers.SfChartRenderer.Init();
            Xamarin.FormsMaps.Init();
            new SfRotatorRenderer();

            // Code for starting up the Xamarin Test Cloud Agent
#if DEBUG
			Xamarin.Calabash.Start();
#endif

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
