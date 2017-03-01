using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SfChartSample
{
    public partial class StackedArea : ContentPage
    {
        public StackedArea()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<StackedAreaData1>(Database.db5.Table<StackedAreaData1>());
            series2.ItemsSource = new ObservableCollection<StackedAreaData2>(Database.db6.Table<StackedAreaData2>());
            series3.ItemsSource = new ObservableCollection<StackedAreaData3>(Database.db7.Table<StackedAreaData3>());
            series4.ItemsSource = new ObservableCollection<StackedAreaData4>(Database.db8.Table<StackedAreaData4>());
        }
    }
}
