using SQLite;

namespace SfChartSample
{
    public interface IFileHelper
    {
        SQLiteConnection DbConnection();
    }
}
