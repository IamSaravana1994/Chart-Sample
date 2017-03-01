using SQLite;
using System;

namespace SfChartSample
{
    public class RangeData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
    }
}
