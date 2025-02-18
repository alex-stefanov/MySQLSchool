namespace MySQLSchool.Logging.Interfaces;

/// <summary>
/// Defines a contract for a logger that includes logging and saving functionalities.
/// </summary>
public interface ILogger
    : ILog, ISave
{
}