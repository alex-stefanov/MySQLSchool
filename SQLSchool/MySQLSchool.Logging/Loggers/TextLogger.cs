using INTERFACES = MySQLSchool.Logging.Interfaces;

namespace MySQLSchool.Logging.Loggers;

public class TextLogger(
    string filePath)
    : INTERFACES.ILogger
{
    private readonly List<string> _logs = [];

    public void Log(
        string message)
    {
        var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
        _logs.Add(logEntry);
    }

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
            Console.WriteLine($"Error saving text log: {ex.Message}");
        }
    }
}