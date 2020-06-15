using System;
using System.Collections.Generic;

namespace laser

{
    public class RotatorViewModel
    {
        public List<RotatorModel> imageCollection = new List<RotatorModel>();

        public List<RotatorModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }


        public RotatorViewModel()
        {
            ImageCollection.Add(new RotatorModel("laser.gun.png"));
            ImageCollection.Add(new RotatorModel("laser.Gun2.png"));
                }
    }
}
   
