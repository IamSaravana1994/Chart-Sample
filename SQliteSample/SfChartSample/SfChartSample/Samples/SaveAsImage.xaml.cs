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
    public partial class SaveAsImage : ContentPage
    {
        public SaveAsImage()
        {
            InitializeComponent();
        }
        public void OnButtonClick(object sender, EventArgs e)
        {
            sfchart.SaveAsImage("Chart_Sample.jpg");
        }
    }
}
