using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SfChartSample
{
    public partial class RangeAreaChart : ContentPage
    {
        public RangeAreaChart()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<RangeData>(Database.db4.Table<RangeData>());
        }
    }
}
