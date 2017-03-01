using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SfChartSample
{
    public partial class AxisLabelCustomization : ContentPage
    {
        public AxisLabelCustomization()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<CategoryData>(Database.db.Table<CategoryData>());
        }
    }
}
