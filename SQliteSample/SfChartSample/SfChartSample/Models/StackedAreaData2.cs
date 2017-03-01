﻿using SQLite;
using System;

namespace SfChartSample
{
    public class StackedAreaData2
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Year { get; set; }
        public double Production { get; set; }
    
    }
}
