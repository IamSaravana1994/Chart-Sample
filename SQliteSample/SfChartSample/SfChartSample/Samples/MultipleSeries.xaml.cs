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
    public partial class MultipleSeries : ContentPage
    {
        public MultipleSeries()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<FinancialData>(Database.db3.Table<FinancialData>());
            series2.ItemsSource = new ObservableCollection<SplineData>(Database.db9.Table<SplineData>());
        }
    }
}
