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

        public ObservableCollection<WeatherData> WeatherTable { get; set; }
       

        public static SQLiteConnection db, db1, db2, db3, db4, db5, db6, db7, db8;

        public Database()
        {
            var WeatherTable = new List<WeatherData>
                {
                new WeatherData {ID = 1, Month = "Jan", Temperature = 30 },
                new WeatherData {ID = 2, Month = "Feb", Temperature = 43 },
                new WeatherData {ID = 3, Month = "Mar", Temperature = 20 },
                new WeatherData {ID = 4, Month = "Apr", Temperature = 54 },
                new WeatherData {ID = 5, Month = "May", Temperature = 15 },
                new WeatherData {ID = 6, Month = "Jun", Temperature = 40 },
                new WeatherData {ID = 7, Month = "Jul", Temperature = 33 },
                new WeatherData {ID = 8, Month = "Aug", Temperature = 45 },
            };

            db = DependencyService.Get<IFileHelper>().DbConnection();
            db.CreateTable<WeatherData>();

            if (db.Table<WeatherData>().Any())
            {
                db.DropTable<WeatherData>();
                db.CreateTable<WeatherData>();
            }

            if (db.InsertAll(WeatherTable) != 0)
            {
                db.UpdateAll(WeatherTable);
            }


            var ExpenditureTable = new List<ExpenditureData>
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

            if (db1.InsertAll(ExpenditureTable) != 0)
            {
                db1.UpdateAll(ExpenditureTable);
            }

            var FinancialAnalysisTable = new ObservableCollection<FinancialAnalysisData>()
            {
                new FinancialAnalysisData { Date = new DateTime(2016,01,01),Open = 873.8, High = 878.85, Low = 855.5, Close = 860.5 },
                new FinancialAnalysisData { Date = new DateTime(2016,01,02),Open = 861, High = 868.4, Low = 835.2, Close = 843.45  },
                new FinancialAnalysisData { Date = new DateTime(2016,01,03),Open = 843.15, High = 850, Low = 838.5,Close =  847.5 },
                new FinancialAnalysisData { Date = new DateTime(2016,01,04),Open = 855.2, High = 858.4, Low = 835.2, Close = 843.45 },
                new FinancialAnalysisData { Date = new DateTime(2016,01,05),Open = 846, High = 860.75,Low =  841, Close = 855 },
                new FinancialAnalysisData { Date = new DateTime(2016,01,06),Open = 873.8, High = 878.85, Low = 855.5, Close = 860.5 },
                new FinancialAnalysisData { Date = new DateTime(2016,01,07),Open = 861, High = 868.4, Low = 835.2, Close = 843.45  },
                new FinancialAnalysisData { Date = new DateTime(2016,01,08),Open = 846, High = 860.75, Low = 841, Close = 855 },
                new FinancialAnalysisData { Date = new DateTime(2016,01,09),Open = 873.8,High =  878.85, Low = 855.5, Close = 860.5 },
                new FinancialAnalysisData { Date = new DateTime(2016,01,10),Open = 865,High =  868.4, Low = 835.2, Close = 843.45 },

            };

            db2 = DependencyService.Get<IFileHelper>().DbConnection();
            db2.CreateTable<FinancialAnalysisData>();

            if (db2.Table<FinancialAnalysisData>().Any())
            {
                db2.DropTable<FinancialAnalysisData>();
                db2.CreateTable<FinancialAnalysisData>();
            }

            if (db2.InsertAll(FinancialAnalysisTable) != 0)
            {
                db2.UpdateAll(FinancialAnalysisTable);
            }

            var PriceTable = new ObservableCollection<PriceData>()
            {
                new PriceData { Date = new DateTime(2016,01,01), High = 48, Low = 36},
                new PriceData { Date = new DateTime(2016,01,02), High = 38, Low = 26},
                new PriceData { Date = new DateTime(2016,01,03), High = 49, Low = 37},
                new PriceData { Date = new DateTime(2016,01,04), High = 37, Low = 25},
                new PriceData { Date = new DateTime(2016,01,05), High = 46, Low =  35},
                new PriceData { Date = new DateTime(2016,01,06), High = 34, Low = 23},
                new PriceData { Date = new DateTime(2016,01,07), High = 47, Low = 34},
            };

            db3 = DependencyService.Get<IFileHelper>().DbConnection();
            db3.CreateTable<PriceData>();

            if (db3.Table<PriceData>().Any())
            {
                db3.DropTable<PriceData>();
                db3.CreateTable<PriceData>();
            }

            if (db3.InsertAll(PriceTable) != 0)
            {
                db3.UpdateAll(PriceTable);
            }

            var USProductionTable = new List<USProductionData>
                {
                new USProductionData {ID = 1, Year = "2009", Production = 30 },
                new USProductionData {ID = 2, Year = "2010", Production = 43 },
                new USProductionData {ID = 3, Year = "2011", Production = 20 },
                new USProductionData {ID = 4, Year = "2012", Production = 54 },
                new USProductionData {ID = 5, Year = "2013", Production = 15 },
                new USProductionData {ID = 6, Year = "2014", Production = 40 },
                new USProductionData {ID = 7, Year = "2015", Production = 25 },
                new USProductionData {ID = 8, Year = "2016", Production = 36 },
            };

            db4 = DependencyService.Get<IFileHelper>().DbConnection();
            db4.CreateTable<USProductionData>();

            if (db4.Table<USProductionData>().Any())
            {
                db4.DropTable<USProductionData>();
                db4.CreateTable<USProductionData>();
            }

            if (db4.InsertAll(USProductionTable) != 0)
            {
                db4.UpdateAll(USProductionTable);
            }

            var IndianProductionTable = new List<IndianProductionData>
                {
                new IndianProductionData {ID = 1, Year = "2009", Production = 46 },
                new IndianProductionData {ID = 2, Year = "2010", Production = 34 },
                new IndianProductionData {ID = 3, Year = "2011", Production = 55 },
                new IndianProductionData {ID = 4, Year = "2012", Production = 11 },
                new IndianProductionData {ID = 5, Year = "2013", Production = 75 },
                new IndianProductionData {ID = 6, Year = "2014", Production = 44 },
                new IndianProductionData {ID = 7, Year = "2015", Production = 52 },
                new IndianProductionData {ID = 8, Year = "2016", Production = 45 },
            };

            db5 = DependencyService.Get<IFileHelper>().DbConnection();
            db5.CreateTable<IndianProductionData>();

            if (db5.Table<IndianProductionData>().Any())
            {
                db5.DropTable<IndianProductionData>();
                db5.CreateTable<IndianProductionData>();
            }

            if (db5.InsertAll(IndianProductionTable) != 0)
            {
                db5.UpdateAll(IndianProductionTable);
            }

            var ChineseProductionTable = new List<ChineseProductionData>
                {
                new ChineseProductionData {ID = 1, Year = "2009", Production = 30 },
                new ChineseProductionData {ID = 2, Year = "2010", Production = 43 },
                new ChineseProductionData {ID = 3, Year = "2011", Production = 55 },
                new ChineseProductionData {ID = 4, Year = "2012", Production = 33 },
                new ChineseProductionData {ID = 5, Year = "2013", Production = 45 },
                new ChineseProductionData {ID = 6, Year = "2014", Production = 40 },
                new ChineseProductionData {ID = 7, Year = "2015", Production = 63 },
                new ChineseProductionData {ID = 8, Year = "2016", Production = 36 },
            };

            db6 = DependencyService.Get<IFileHelper>().DbConnection();
            db6.CreateTable<ChineseProductionData>();

            if (db6.Table<ChineseProductionData>().Any())
            {
                db6.DropTable<ChineseProductionData>();
                db6.CreateTable<ChineseProductionData>();
            }

            if (db6.InsertAll(ChineseProductionTable) != 0)
            {
                db6.UpdateAll(ChineseProductionTable);
            }

            var CanadaProductionTable = new List<CanadaProductionData>
                {
                new CanadaProductionData {ID = 1, Year = "2009", Production = 50 },
                new CanadaProductionData {ID = 2, Year = "2010", Production = 43 },
                new CanadaProductionData {ID = 3, Year = "2011", Production = 56 },
                new CanadaProductionData {ID = 4, Year = "2012", Production = 54 },
                new CanadaProductionData {ID = 5, Year = "2013", Production = 65 },
                new CanadaProductionData {ID = 6, Year = "2014", Production = 46 },
                new CanadaProductionData {ID = 7, Year = "2015", Production = 25 },
                new CanadaProductionData {ID = 8, Year = "2016", Production = 56 },
            };

            db7 = DependencyService.Get<IFileHelper>().DbConnection();
            db7.CreateTable<CanadaProductionData>();

            if (db7.Table<CanadaProductionData>().Any())
            {
                db7.DropTable<CanadaProductionData>();
                db7.CreateTable<CanadaProductionData>();
            }

            if (db7.InsertAll(CanadaProductionTable) != 0)
            {
                db7.UpdateAll(CanadaProductionTable);
            }

            var FinancialTable = new ObservableCollection<FinancialData>()
            {
                new FinancialData { Date = new DateTime(2016,01,01),Value = 880},
                new FinancialData { Date = new DateTime(2016,01,02),Value = 879.23},
                new FinancialData { Date = new DateTime(2016,01,03),Value = 881.5 },
                new FinancialData { Date = new DateTime(2016,01,04),Value = 891},
                new FinancialData { Date = new DateTime(2016,01,05),Value = 883.23},
                new FinancialData { Date = new DateTime(2016,01,06),Value = 895},
                new FinancialData { Date = new DateTime(2016,01,07),Value = 894.34},
                new FinancialData { Date = new DateTime(2016,01,08),Value = 892.37},
                new FinancialData { Date = new DateTime(2016,01,09),Value = 895.24},
                new FinancialData { Date = new DateTime(2016,01,10),Value = 899},

            };

            db8 = DependencyService.Get<IFileHelper>().DbConnection();
            db8.CreateTable<FinancialData>();

            if (db8.Table<FinancialData>().Any())
            {
                db8.DropTable<FinancialData>();
                db8.CreateTable<FinancialData>();
            }

            if (db8.InsertAll(FinancialTable) != 0)
            {
                db8.UpdateAll(FinancialTable);
            }

        }
    }
}
