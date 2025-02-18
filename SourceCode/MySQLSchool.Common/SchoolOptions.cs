namespace MySQLSchool.Common;

/// <summary>
/// Provides configuration options for the school database.
/// </summary>
public static class SchoolOptions
{
    /// <summary>
    /// The connection string used to connect to the school database.
    /// </summary>
    public const string ConnectionString = "Server=localhost;port=3306;Database=mySchool;Uid=profais;Pwd=4Nxjb4hNlAa5DE!S;";

    /// <summary>
    /// Indicates whether the database is created.
    /// </summary>
    public const bool IsDatabaseCreated = true;
}