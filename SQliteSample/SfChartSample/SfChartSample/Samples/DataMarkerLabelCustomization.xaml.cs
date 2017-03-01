using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SfChartSample
{
    public partial class DataMarkerLabelCustomization : ContentPage
    {
        public DataMarkerLabelCustomization()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<CategoryData>(Database.db.Table<CategoryData>());
        }
    }
}
