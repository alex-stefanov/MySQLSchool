using MySqlConnector;
using COMMON = MySQLSchool.Common;

namespace MySQLSchool.Data;

public static class DbInitializer
{
    private static readonly MySqlConnection Connection 
        = new(COMMON.SchoolOptions.ConnectionString);

    public static void Initialize()
    {
        Connection.Open();
    }

    public static MySqlConnection GetConnection()
        => Connection;
}