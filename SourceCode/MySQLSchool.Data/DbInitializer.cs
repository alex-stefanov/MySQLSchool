using MySqlConnector;
using COMMON = MySQLSchool.Common;

namespace MySQLSchool.Data;

/// <summary>
/// Initializes the database connection for the application.
/// </summary>
public static class DbInitializer
{
    private static readonly MySqlConnection Connection
        = new(COMMON.SchoolOptions.ConnectionString);

    /// <summary>
    /// Opens the database connection to the configured MySQL database.
    /// </summary>
    public static void Initialize()
    {
        Connection.Open();
    }

    /// <summary>
    /// Gets the current database connection.
    /// </summary>
    /// <returns>The MySQL connection.</returns>
    public static MySqlConnection GetConnection()
        => Connection;
}