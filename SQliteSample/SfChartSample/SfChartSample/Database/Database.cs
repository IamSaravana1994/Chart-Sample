using SQLite;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfChartSample
{
    public class Database
    {

        public ObservableCollection<CategoryData> DataTable { get; set; }
        public ObservableCollection<ExpenditureData> DataTable1 { get; set; }
        public ObservableCollection<DateTimeData> DataTable2 { get; set; }
        public ObservableCollection<FinancialData> DataTable3 { get; set; }
        public ObservableCollection<RangeData> DataTable4 { get; set; }
        public ObservableCollection<StackedAreaData1> DataTable5 { get; set; }
        public ObservableCollection<StackedAreaData2> DataTable6 { get; set; }
        public ObservableCollection<StackedAreaData3> DataTable7 { get; set; }
        public ObservableCollection<StackedAreaData4> DataTable8 { get; set; }
        public ObservableCollection<SplineData> DataTable9 { get; set; }
        public ObservableCollection<PolarData> DataTable10 { get; set; }

        public static SQLiteConnection db, db1, db2, db3, db4, db5, db6, db7, db8, db9, db10;

        public Database()
        {
            var DataTable = new List<CategoryData>
                {
                new CategoryData {ID = 1, Month = "Jan", Temperature = 30 },
                new CategoryData {ID = 2, Month = "Feb", Temperature = 43 },
                new CategoryData {ID = 3, Month = "Mar", Temperature = 20 },
                new CategoryData {ID = 4, Month = "Apr", Temperature = 54 },
                new CategoryData {ID = 5, Month = "May", Temperature = 15 },
                new CategoryData {ID = 6, Month = "Jun", Temperature = 40 },
                new CategoryData {ID = 7, Month = "Jul", Temperature = 25 },
                new CategoryData {ID = 8, Month = "Aug", Temperature = 36 },
            };

            db = DependencyService.Get<IFileHelper>().DbConnection();
            db.CreateTable<CategoryData>();

            if (db.Table<CategoryData>().Any())
            {
                db.DropTable<CategoryData>();
                db.CreateTable<CategoryData>();
            }

            if (db.InsertAll(DataTable) != 0)
            {
                db.UpdateAll(DataTable);
            }


            var DataTable1 = new List<ExpenditureData>
                {
                    new ExpenditureData { Type = "Sports & Health", AmountSpent = 300 },
                    new ExpenditureData { Type = "Housing", AmountSpent = 500 },
                    new ExpenditureData { Type = "Food", AmountSpent = 450 },
                    new ExpenditureData { Type = "Education", AmountSpent = 600 },
                    new ExpenditureData { Type = "Electronics", AmountSpent = 400 },
                    new ExpenditureData { Type = "Transportation", AmountSpent = 350 },
                    new ExpenditureData { Type = "Other personal", AmountSpent = 700 },
                };

            db1 = DependencyService.Get<IFileHelper>().DbConnection();
            db1.CreateTable<ExpenditureData>();

            if (db1.Table<ExpenditureData>().Any())
            {
                db1.DropTable<ExpenditureData>();
                db1.CreateTable<ExpenditureData>();
            }

            if (db1.InsertAll(DataTable1) != 0)
            {
                db1.UpdateAll(DataTable1);
            }


            var DataTable2 = new List<DateTimeData>
                {
                    new DateTimeData { Date = new DateTime(2016,01,01), Temperature = 15 },
                    new DateTimeData { Date = new DateTime(2016,02,01), Temperature = 32 },
                    new DateTimeData { Date = new DateTime(2016,03,01), Temperature = 46 },
                    new DateTimeData { Date = new DateTime(2016,04,01), Temperature = 57 },
                    new DateTimeData { Date = new DateTime(2016,05,01), Temperature = 65 },
                    new DateTimeData { Date = new DateTime(2016,06,01), Temperature = 73 },
                    new DateTimeData { Date = new DateTime(2016,07,01), Temperature = 84 },
                    new DateTimeData { Date = new DateTime(2016,08,01), Temperature = 65 },
                    new DateTimeData { Date = new DateTime(2016,09,01), Temperature = 72 },
                    new DateTimeData { Date = new DateTime(2016,10,01), Temperature = 43 },
                    new DateTimeData { Date = new DateTime(2016,11,01), Temperature = 64 },
                    new DateTimeData { Date = new DateTime(2016,12,01), Temperature = 72 },
                };

            db2 = DependencyService.Get<IFileHelper>().DbConnection();
            db2.CreateTable<DateTimeData>();

            if (db2.Table<DateTimeData>().Any())
            {
                db2.DropTable<DateTimeData>();
                db2.CreateTable<DateTimeData>();
            }

            if (db2.InsertAll(DataTable2) != 0)
            {
                db2.UpdateAll(DataTable2);
            }

            var DataTable3 = new ObservableCollection<FinancialData>()
            {
                new FinancialData { Date = new DateTime(2016,01,01),Open = 873.8, High = 878.85, Low = 855.5, Close = 860.5 },
                new FinancialData { Date = new DateTime(2016,01,02),Open = 861, High = 868.4, Low = 835.2, Close = 843.45  },
                new FinancialData { Date = new DateTime(2016,01,03),Open = 843.15, High = 850, Low = 838.5,Close =  847.5 },
                new FinancialData { Date = new DateTime(2016,01,04),Open = 855.2, High = 858.4, Low = 835.2, Close = 843.45 },
                new FinancialData { Date = new DateTime(2016,01,05),Open = 846, High = 860.75,Low =  841, Close = 855 },
                new FinancialData { Date = new DateTime(2016,01,06),Open = 873.8, High = 878.85, Low = 855.5, Close = 860.5 },
                new FinancialData { Date = new DateTime(2016,01,07),Open = 861, High = 868.4, Low = 835.2, Close = 843.45  },
                new FinancialData { Date = new DateTime(2016,01,08),Open = 846, High = 860.75, Low = 841, Close = 855 },
                new FinancialData { Date = new DateTime(2016,01,09),Open = 873.8,High =  878.85, Low = 855.5, Close = 860.5 },
                new FinancialData { Date = new DateTime(2016,01,10),Open = 865,High =  868.4, Low = 835.2, Close = 843.45 },

            };

            db3 = DependencyService.Get<IFileHelper>().DbConnection();
            db3.CreateTable<FinancialData>();

            if (db3.Table<FinancialData>().Any())
            {
                db3.DropTable<FinancialData>();
                db3.CreateTable<FinancialData>();
            }

            if (db3.InsertAll(DataTable3) != 0)
            {
                db3.UpdateAll(DataTable3);
            }

            var DataTable4 = new ObservableCollection<RangeData>()
            {
                new RangeData { Date = new DateTime(2016,01,01), High = 48, Low = 36},
                new RangeData { Date = new DateTime(2016,01,02), High = 38, Low = 26},
                new RangeData { Date = new DateTime(2016,01,03), High = 49, Low = 37},
                new RangeData { Date = new DateTime(2016,01,04), High = 37, Low = 25},
                new RangeData { Date = new DateTime(2016,01,05), High = 46, Low =  35},
                new RangeData { Date = new DateTime(2016,01,06), High = 34, Low = 23},
                new RangeData { Date = new DateTime(2016,01,07), High = 47, Low = 34},
            };

            db4 = DependencyService.Get<IFileHelper>().DbConnection();
            db4.CreateTable<RangeData>();

            if (db4.Table<RangeData>().Any())
            {
                db4.DropTable<RangeData>();
                db4.CreateTable<RangeData>();
            }

            if (db4.InsertAll(DataTable4) != 0)
            {
                db4.UpdateAll(DataTable4);
            }

            var DataTable5 = new List<StackedAreaData1>
                {
                new StackedAreaData1 {ID = 1, Year = "2009", Production = 30 },
                new StackedAreaData1 {ID = 2, Year = "2010", Production = 43 },
                new StackedAreaData1 {ID = 3, Year = "2011", Production = 20 },
                new StackedAreaData1 {ID = 4, Year = "2012", Production = 54 },
                new StackedAreaData1 {ID = 5, Year = "2013", Production = 15 },
                new StackedAreaData1 {ID = 6, Year = "2014", Production = 40 },
                new StackedAreaData1 {ID = 7, Year = "2015", Production = 25 },
                new StackedAreaData1 {ID = 8, Year = "2016", Production = 36 },
            };

            db5 = DependencyService.Get<IFileHelper>().DbConnection();
            db5.CreateTable<StackedAreaData1>();

            if (db5.Table<StackedAreaData1>().Any())
            {
                db5.DropTable<StackedAreaData1>();
                db5.CreateTable<StackedAreaData1>();
            }

            if (db5.InsertAll(DataTable5) != 0)
            {
                db5.UpdateAll(DataTable5);
            }

            var DataTable6 = new List<StackedAreaData2>
                {
                new StackedAreaData2 {ID = 1, Year = "2009", Production = 46 },
                new StackedAreaData2 {ID = 2, Year = "2010", Production = 34 },
                new StackedAreaData2 {ID = 3, Year = "2011", Production = 55 },
                new StackedAreaData2 {ID = 4, Year = "2012", Production = 11 },
                new StackedAreaData2 {ID = 5, Year = "2013", Production = 75 },
                new StackedAreaData2 {ID = 6, Year = "2014", Production = 44 },
                new StackedAreaData2 {ID = 7, Year = "2015", Production = 52 },
                new StackedAreaData2 {ID = 8, Year = "2016", Production = 45 },
            };

            db6 = DependencyService.Get<IFileHelper>().DbConnection();
            db6.CreateTable<StackedAreaData2>();

            if (db6.Table<StackedAreaData2>().Any())
            {
                db6.DropTable<StackedAreaData2>();
                db6.CreateTable<StackedAreaData2>();
            }

            if (db6.InsertAll(DataTable6) != 0)
            {
                db6.UpdateAll(DataTable6);
            }

            var DataTable7 = new List<StackedAreaData3>
                {
                new StackedAreaData3 {ID = 1, Year = "2009", Production = 30 },
                new StackedAreaData3 {ID = 2, Year = "2010", Production = 43 },
                new StackedAreaData3 {ID = 3, Year = "2011", Production = 55 },
                new StackedAreaData3 {ID = 4, Year = "2012", Production = 33 },
                new StackedAreaData3 {ID = 5, Year = "2013", Production = 45 },
                new StackedAreaData3 {ID = 6, Year = "2014", Production = 40 },
                new StackedAreaData3 {ID = 7, Year = "2015", Production = 63 },
                new StackedAreaData3 {ID = 8, Year = "2016", Production = 36 },
            };

            db7 = DependencyService.Get<IFileHelper>().DbConnection();
            db7.CreateTable<StackedAreaData3>();

            if (db7.Table<StackedAreaData3>().Any())
            {
                db7.DropTable<StackedAreaData3>();
                db7.CreateTable<StackedAreaData3>();
            }

            if (db7.InsertAll(DataTable7) != 0)
            {
                db7.UpdateAll(DataTable7);
            }

            var DataTable8 = new List<StackedAreaData4>
                {
                new StackedAreaData4 {ID = 1, Year = "2009", Production = 50 },
                new StackedAreaData4 {ID = 2, Year = "2010", Production = 43 },
                new StackedAreaData4 {ID = 3, Year = "2011", Production = 56 },
                new StackedAreaData4 {ID = 4, Year = "2012", Production = 54 },
                new StackedAreaData4 {ID = 5, Year = "2013", Production = 65 },
                new StackedAreaData4 {ID = 6, Year = "2014", Production = 46 },
                new StackedAreaData4 {ID = 7, Year = "2015", Production = 25 },
                new StackedAreaData4 {ID = 8, Year = "2016", Production = 56 },
            };

            db8 = DependencyService.Get<IFileHelper>().DbConnection();
            db8.CreateTable<StackedAreaData4>();

            if (db8.Table<StackedAreaData4>().Any())
            {
                db8.DropTable<StackedAreaData4>();
                db8.CreateTable<StackedAreaData4>();
            }

            if (db8.InsertAll(DataTable8) != 0)
            {
                db8.UpdateAll(DataTable8);
            }

            var DataTable9 = new ObservableCollection<SplineData>()
            {
                new SplineData { Date = new DateTime(2016,01,01),Value = 880},
                new SplineData { Date = new DateTime(2016,01,02),Value = 879.23},
                new SplineData { Date = new DateTime(2016,01,03),Value = 881.5 },
                new SplineData { Date = new DateTime(2016,01,04),Value = 891},
                new SplineData { Date = new DateTime(2016,01,05),Value = 883.23},
                new SplineData { Date = new DateTime(2016,01,06),Value = 895},
                new SplineData { Date = new DateTime(2016,01,07),Value = 894.34},
                new SplineData { Date = new DateTime(2016,01,08),Value = 892.37},
                new SplineData { Date = new DateTime(2016,01,09),Value = 895.24},
                new SplineData { Date = new DateTime(2016,01,10),Value = 899},

            };

            db9 = DependencyService.Get<IFileHelper>().DbConnection();
            db9.CreateTable<SplineData>();

            if (db9.Table<SplineData>().Any())
            {
                db9.DropTable<SplineData>();
                db9.CreateTable<SplineData>();
            }

            if (db9.InsertAll(DataTable9) != 0)
            {
                db9.UpdateAll(DataTable9);
            }

            var DataTable10 = new ObservableCollection<PolarData>()
            {
                new PolarData { Name = "N",Value = 80},
                new PolarData { Name = "NE",Value = 85},
                new PolarData { Name = "E",Value = 78 },
                new PolarData { Name = "SE",Value = 90},
                new PolarData { Name = "S",Value = 75},
                new PolarData { Name = "SW",Value = 83},
                new PolarData { Name ="W",Value = 79},
                new PolarData { Name = "NW",Value = 88},
            };

            db10 = DependencyService.Get<IFileHelper>().DbConnection();
            db10.CreateTable<PolarData>();

            if (db10.Table<PolarData>().Any())
            {
                db10.DropTable<PolarData>();
                db10.CreateTable<PolarData>();
            }

            if (db10.InsertAll(DataTable10) != 0)
            {
                db10.UpdateAll(DataTable10);
            }
        }
    }
}
