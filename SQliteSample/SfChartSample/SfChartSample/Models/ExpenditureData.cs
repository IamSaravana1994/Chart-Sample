﻿using SQLite;
using System;

namespace SfChartSample
{
    public class ExpenditureData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Type { get; set; }
        public double AmountSpent { get; set; }
    }
}
