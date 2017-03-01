using Syncfusion.SfChart.XForms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SampleChart
{
    public class Chart : ContentPage
    {
        ObservableCollection<ChartDataPoint> datas;
        SfChart chart;
        public Chart()
        {
            chart = new SfChart();
            chart.Title = new ChartTitle();

            datas = new ObservableCollection<ChartDataPoint>();
            datas.Add(new ChartDataPoint("MON", 45));
            datas.Add(new ChartDataPoint("TUE", 25));
            datas.Add(new ChartDataPoint("WED", 50));
            datas.Add(new ChartDataPoint("THU", 30));
            datas.Add(new ChartDataPoint("FRI", 45));
            datas.Add(new ChartDataPoint("SAT", 25));
            datas.Add(new ChartDataPoint("SUN", 50));
            datas.Add(new ChartDataPoint("MON", 30));

            CategoryAxis primaryAxis = new CategoryAxis();
            chart.PrimaryAxis = primaryAxis;

            NumericalAxis secondaryAxis = new NumericalAxis();
            secondaryAxis.Maximum = 65;
            chart.SecondaryAxis = secondaryAxis;

            var series = new ColumnSeries();
            series.SelectedDataPointColor = Color.FromHex("#90EE90");
            series.ItemsSource = datas;
            series.EnableDataPointSelection = true;
            series.ColorModel.Palette = ChartColorPalette.Custom;
            series.ColorModel.CustomBrushes = GetCustomBrushes(datas);
            chart.Series.Add(series);

            Content = chart;
        }
        List<Color> GetCustomBrushes(ObservableCollection<ChartDataPoint> datas)
        {
            List<Color> colors = new List<Color>();

            for (int i = 0; i < datas.Count; i++)
            {
                if (datas[i].YValue < 35)
                    colors.Add(Color.Gray);
                else
                    colors.Add(Color.Green);
            }

            return colors;
        }
    }
}
