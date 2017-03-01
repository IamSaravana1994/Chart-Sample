using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        }
    }
}
