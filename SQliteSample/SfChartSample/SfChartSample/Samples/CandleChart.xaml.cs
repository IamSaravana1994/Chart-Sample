using Syncfusion.SfChart.XForms;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SfChartSample
{
    public partial class CandleChart : ContentPage
    {
        public CandleChart()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<FinancialData>(Database.db3.Table<FinancialData>());
        }
    }
}
