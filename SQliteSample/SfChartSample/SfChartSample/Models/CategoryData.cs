using SQLite;
using System;

namespace SfChartSample
{
    public class CategoryData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Month { get; set; }
        public double Temperature { get; set; }
    
    }
}
