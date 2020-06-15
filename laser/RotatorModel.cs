using System;
using Syncfusion.SfRotator.XForms;
namespace laser
{
    public class RotatorModel
    {
        
        public RotatorModel(string imageString)
        {
            Image = imageString;
        }
        private String _image;
        public String Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
