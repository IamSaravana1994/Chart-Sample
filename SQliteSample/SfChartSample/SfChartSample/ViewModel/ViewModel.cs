using SQLite;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SfChartSample
{
    public class ViewModel
    {
        public ObservableCollection<ChartDataPoint> Values { get; set; }
        public List<Color> Colors { get; set; }
        public ViewModel()
        {
            Values = new ObservableCollection<ChartDataPoint>()
            {
                new ChartDataPoint("Jan", 19),
                new ChartDataPoint("Feb", 43),
                new ChartDataPoint("Mar", 32),
                new ChartDataPoint("Apr", 59),
                new ChartDataPoint("May", 65),
                new ChartDataPoint("Jun", 61),
                new ChartDataPoint("Jul", 20),
                new ChartDataPoint("Aug", 33),
                new ChartDataPoint("Sep", 55),
                new ChartDataPoint("Oct", 42),
                new ChartDataPoint("Nov", 49),
                new ChartDataPoint("Dec", 15),
            };

            Colors = new List<Color>()
            {
                Color.Teal,
                Color.Silver,
                Color.Purple,
                Color.Olive,
                Color.Orange,
                Color.Maroon,
                Color.Aqua,
                Color.Accent,
                Color.Gray,
                Color.Red,
                Color.Navy,
                Color.Green,
                Color.Fuchsia,
            };
        }
    }
}
