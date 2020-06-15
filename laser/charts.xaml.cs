using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace laser
{
    public partial class charts : ContentPage
    {
        public List<PlayerGameRecord> Data { get; set; }


        public charts()
        {
            InitializeComponent();
            Data = new List<PlayerGameRecord>()
            {
                new PlayerGameRecord{Name= "lars" ,Score=99},
                new PlayerGameRecord{Name="noah" ,Score=23},
                new PlayerGameRecord{Name ="jack",Score=11}

            };

           PieChart.ItemsSource = Data;
        }
    }
}
