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
    public partial class PolarChart : ContentPage
    {
        public PolarChart()
        {
            InitializeComponent();
            //series1.ItemsSource = new ObservableCollection<PolarData>(Database.db10.Table<PolarData>());
            series1.ItemsSource = new ObservableCollection<ExpenditureData>(Database.db1.Table<ExpenditureData>());
        }
    }

    public class ChartBehaviorExt : ChartZoomPanBehavior
    {
        float initialX = 0, deltaX = 0;

        protected override void OnTouchDown(float x, float y)
        {
            initialX = x;

            base.OnTouchDown(x, y);
        }

        protected override void OnTouchMove(float x, float y)
        {
            base.OnTouchMove(x, y);

            deltaX = Math.Abs(x - initialX);
        }

        protected override void OnTouchUp(float x, float y)
        {
            base.OnTouchUp(x, y);

            foreach (ChartSeries series in Chart.Series)
            {
                if (deltaX > 100)
                {
                    if (series is PolarSeries)
                    {
                        if ((series as PolarSeries).DrawType == PolarRadarSeriesDrawType.Line)
                            (series as PolarSeries).DrawType = PolarRadarSeriesDrawType.Area;
                        else
                            (series as PolarSeries).DrawType = PolarRadarSeriesDrawType.Line;
                    }
                }
            }
        }
    }
}
