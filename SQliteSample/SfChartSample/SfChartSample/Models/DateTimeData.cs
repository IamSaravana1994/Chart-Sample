using SQLite;
using System;

namespace SfChartSample
{
    public class DateTimeData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
    }
}
