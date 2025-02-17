using MySqlConnector;
using MySQLSchool.Common;

namespace MySQLSchool.Data;

public static class DbInitializer
{
    private static readonly MySqlConnection _connection = new(SchoolOptions.ConnectionString);

    public static void Initialize()
    {
        _connection.Open();
    }

    public static MySqlConnection GetConnection()
        => _connection;
}