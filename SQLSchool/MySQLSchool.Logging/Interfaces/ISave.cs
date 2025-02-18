namespace MySQLSchool.Logging.Interfaces;

/// <summary>
/// Defines a contract for saving log data.
/// </summary>
public interface ISave
{
    /// <summary>
    /// Saves the log data.
    /// </summary>
    void SaveLog();
}