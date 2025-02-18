namespace MySQLSchool.Logging.Interfaces;

/// <summary>
/// Defines a contract for logging messages.
/// </summary>
public interface ILog
{
    /// <summary>
    /// Logs a specified message.
    /// </summary>
    /// <param name="message">The message to be logged.</param>
    void Log(
        string message);
}