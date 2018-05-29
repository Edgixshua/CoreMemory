using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace CoreMemory.InMemoryDatabase
{
    public static class Setup
    {
        public static DbContext InMemoryDatabase<T>() where T : DbContext
        {
            var builder = new DbContextOptionsBuilder<T>();
            builder.UseInMemoryDatabase();
            var options = builder.Options;

            return new DbContext(options);
        }

        public static DbContext InMemoryDatabaseWithSqlProvider<T>() where T : DbContext
        {
            var connectionStringBuilder =
              new SqliteConnectionStringBuilder { DataSource = ":memory:" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            var builder = new DbContextOptionsBuilder<T>();
            builder.UseSqlite(connection);
            var options = builder.Options;

            return new DbContext(options);
        }
    }
}
