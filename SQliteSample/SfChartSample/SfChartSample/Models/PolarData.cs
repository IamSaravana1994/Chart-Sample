using SQLite;
using System;

namespace SfChartSample
{
    public class PolarData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    
    }
}
