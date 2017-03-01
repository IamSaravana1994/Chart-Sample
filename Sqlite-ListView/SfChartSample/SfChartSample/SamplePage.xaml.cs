using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SfChartSample
{
    public partial class SamplePage : ContentPage
    {
        public SamplePage()
        {
            InitializeComponent();
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Type type;
            if ((e.SelectedItem as ListModel).Page == "Axis labels customization")
            {
                type = Type.GetType("SfChartSample.AxisLabelCustomization");
            }
            else if ((e.SelectedItem as ListModel).Page == "Trackball template")
            {
                type = Type.GetType("SfChartSample.TrackBallTemplate");
            }
            else if ((e.SelectedItem as ListModel).Page == "Axis customization")
            {
                type = Type.GetType("SfChartSample.AxisCustomization");
            }
            else if ((e.SelectedItem as ListModel).Page == "Save As Image")
            {
                type = Type.GetType("SfChartSample.SaveAsImage");
            }
            else if ((e.SelectedItem as ListModel).Page == "Tooltip template")
            {
                type = Type.GetType("SfChartSample.TooltipTemplate");
            }
            else if ((e.SelectedItem as ListModel).Page == "Datamarker template")
            {
                type = Type.GetType("SfChartSample.DataMarkerTemplate");
            }
            else if ((e.SelectedItem as ListModel).Page == "Trackball label customization")
            {
                type = Type.GetType("SfChartSample.TrackBallLabelCustomization");
            }
            else if ((e.SelectedItem as ListModel).Page == "Pie series customization")
            {
                type = Type.GetType("SfChartSample.PieSeriesCustomization");
            }
            else if ((e.SelectedItem as ListModel).Page == "Doughnut series customization")
            {
                type = Type.GetType("SfChartSample.DoughnutSeriesCustomization");
            }
            else if ((e.SelectedItem as ListModel).Page == "Datamarker label customization")
            {
                type = Type.GetType("SfChartSample.DataMarkerLabelCustomization");
            }
            else if ((e.SelectedItem as ListModel).Page == "Candle chart")
            {
                type = Type.GetType("SfChartSample.CandleChart");
            }
            else if ((e.SelectedItem as ListModel).Page == "Polar chart")
            {
                type = Type.GetType("SfChartSample.PolarChart");
            }
            else if ((e.SelectedItem as ListModel).Page == "RangeArea chart")
            {
                type = Type.GetType("SfChartSample.RangeAreaChart");
            }
            else if ((e.SelectedItem as ListModel).Page == "Pyramid")
            {
                type = Type.GetType("SfChartSample.Pyramid");
            }
            else if ((e.SelectedItem as ListModel).Page == "StackedArea chart")
            {
                type = Type.GetType("SfChartSample.StackedArea");
            }
            else if ((e.SelectedItem as ListModel).Page == "100% Stacked Column chart")
            {
                type = Type.GetType("SfChartSample.StackedColumn100");
            }
            else if ((e.SelectedItem as ListModel).Page == "StepLine chart")
            {
                type = Type.GetType("SfChartSample.StepLineChart");
            }
            else if ((e.SelectedItem as ListModel).Page == "SplineArea chart")
            {
                type = Type.GetType("SfChartSample.SplineAreaChart");
            }
            else if ((e.SelectedItem as ListModel).Page == "Multiple axes")
            {
                type = Type.GetType("SfChartSample.MultipleAxes");
            }
            else if ((e.SelectedItem as ListModel).Page == "Multiple series")
            {
                type = Type.GetType("SfChartSample.MultipleSeries");
            }
            else 
            {
                type = Type.GetType("SfChartSample.RangeAreaChart");
            }


            Navigation.PushAsync(Activator.CreateInstance(type) as ContentPage);
        }
    }

    public class ListViewModel
    {
        public ObservableCollection<WeatherData> ListData
        {
            get { return new ObservableCollection<WeatherData>(Database.db.Table<WeatherData>()); }
            set { }
        }
        public ListViewModel()
        {
            //ListData = new ObservableCollection<ListModel>();
            //ListData.Add(new ListModel() { Page = "Axis labels customization" });
            //ListData.Add(new ListModel() { Page = "Trackball template" });
            //ListData.Add(new ListModel() { Page = "Axis customization" });
            //ListData.Add(new ListModel() { Page = "Save As Image" });
            //ListData.Add(new ListModel() { Page = "Tooltip template" });
            //ListData.Add(new ListModel() { Page = "Datamarker template" });
            //ListData.Add(new ListModel() { Page = "Trackball label customization" });
            //ListData.Add(new ListModel() { Page = "Pie series customization" });
            //ListData.Add(new ListModel() { Page = "Doughnut series customization" });
            //ListData.Add(new ListModel() { Page = "Datamarker label customization" });
            //ListData.Add(new ListModel() { Page = "Candle chart" });
            //ListData.Add(new ListModel() { Page = "Polar chart" });
            //ListData.Add(new ListModel() { Page = "RangeArea chart" });
            //ListData.Add(new ListModel() { Page = "Pyramid" });
            //ListData.Add(new ListModel() { Page = "StackedArea chart" });
            //ListData.Add(new ListModel() { Page = "100% Stacked Column chart" });
            //ListData.Add(new ListModel() { Page = "StepLine chart" });
            //ListData.Add(new ListModel() { Page = "SplineArea chart" });
            //ListData.Add(new ListModel() { Page = "Multiple axes" });
            //ListData.Add(new ListModel() { Page = "Multiple series" });

        }
    }

    public class ListModel
    {
        public string Page { get; set; }
    }
}
