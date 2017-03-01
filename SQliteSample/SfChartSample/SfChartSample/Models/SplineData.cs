using SQLite;
using System;

namespace SfChartSample
{
    public class SplineData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
       
    }
}
