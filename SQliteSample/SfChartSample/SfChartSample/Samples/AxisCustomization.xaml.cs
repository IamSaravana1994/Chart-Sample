using Syncfusion.SfChart.XForms;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SfChartSample
{
    public partial class AxisCustomization : ContentPage
    {
        public AxisCustomization()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<DateTimeData>(Database.db2.Table<DateTimeData>()); ;
        }

        private void PrimaryAxis_LabelCreated(object sender, ChartAxisLabelEventArgs e)
        {
            DateTime dateTime;

            if (Device.OS == TargetPlatform.iOS)
                dateTime = new DateTime(1970, 1, 1) + TimeSpan.FromMilliseconds(e.Position);
            else if (Device.OS == TargetPlatform.Android)
                dateTime = new DateTime(1970, 1, 1) + TimeSpan.FromMilliseconds(e.Position);
            else
                dateTime = new DateTime(1900, 1, 1) + TimeSpan.FromMilliseconds(e.Position);

            if (primaryAxis.GetActualIntervalType() == DateTimeIntervalType.Years)
            {
                e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
            }

            else if (primaryAxis.GetActualIntervalType() == DateTimeIntervalType.Months || primaryAxis.GetActualIntervalType() == DateTimeIntervalType.Days)
            {
                e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
            }

            else if (primaryAxis.GetActualIntervalType() == DateTimeIntervalType.Hours)
            {
                if (dateTime.Hour != 0 && dateTime.Hour < 12)
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + dateTime.Hour + "AM";
                }
                else if (dateTime.Hour == 0)
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + "12AM";
                }
                else if (dateTime.Hour > 12)
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + (dateTime.Hour - 12) + "PM";
                }
                else
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + (dateTime.Hour) + "PM";
                }

            }

            else if (primaryAxis.GetActualIntervalType() == DateTimeIntervalType.Minutes)
            {
                if (dateTime.Hour != 0 && dateTime.Hour < 12)
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + dateTime.Hour + ":" + dateTime.Minute + "AM";
                }
                else if (dateTime.Hour == 0)
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + "12AM" + ":" + dateTime.Minute;
                }
                else if (dateTime.Hour > 12)
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + (dateTime.Hour - 12) + ":" + dateTime.Minute + "PM";
                }
                else
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + (dateTime.Hour) + ":" + dateTime.Minute + "PM";
                }
            }
            else if (primaryAxis.GetActualIntervalType() == DateTimeIntervalType.Seconds || primaryAxis.GetActualIntervalType() == DateTimeIntervalType.Milliseconds)
            {
                if (dateTime.Hour != 0 && dateTime.Hour < 12)
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + dateTime.Hour + ":" + dateTime.Minute + ":" + dateTime.Second + "AM";
                }
                else if (dateTime.Hour == 0)
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + "12" + ":" + dateTime.Minute + ":" + dateTime.Second + "AM";
                }
                else if (dateTime.Hour > 12)
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + (dateTime.Hour - 12) + ":" + dateTime.Minute + ":" + dateTime.Second + "PM";
                }
                else
                {
                    e.LabelContent = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + " " + (dateTime.Hour) + ":" + dateTime.Minute + ":" + dateTime.Second + "PM";
                }
            }
        }
    }
}
