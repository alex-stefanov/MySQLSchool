using INTERFACES = MySQLSchool.Logging.Interfaces;

namespace MySQLSchool.Logging.Loggers;

/// <summary>
/// A logger that stores logs in a text file.
/// </summary>
public class TextLogger (
    string filePath )
    : INTERFACES.ILogger
{
    private readonly List<string> _logs = [];

    /// <summary>
    /// Logs a specified message.
    /// </summary>
    /// <param name="message">The message to be logged.</param>
    public void Log(
        string message)
    {
        var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
        _logs.Add(logEntry);
    }

    /// <summary>
    /// Saves the collected logs to the text file.
    /// </summary>
    public void SaveLog()
    {
        try
        {
            using FileStream fileStream = new(filePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            using StreamWriter writer = new(fileStream);

            foreach (var entry in _logs)
            {
                writer.WriteLine(entry);
            }

            _logs.Clear();
        }
        catch (Exception ex)
        {
            //TODO: Remove work with Console here
            Console.WriteLine($"Error saving text log: {ex.Message}");
        }
    }
}