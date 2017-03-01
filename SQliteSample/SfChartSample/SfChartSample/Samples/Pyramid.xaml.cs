using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SfChartSample
{
    public partial class Pyramid : ContentPage
    {
        public Pyramid()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<CategoryData>(Database.db.Table<CategoryData>());
        }
    }
}
