using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SfChartSample
{
    public partial class PieSeriesCustomization : ContentPage
    {
        public PieSeriesCustomization()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<ExpenditureData>(Database.db1.Table<ExpenditureData>());
        }
    }
}
