using MySQLSchool.Logging.Interfaces;

namespace MySQLSchool.Logging.Loggers;

public class TextLogger(
    string filePath)
    : ILogger
{
    private readonly List<string> logs = [];

    public void Log(
        string message)
    {
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
        logs.Add(logEntry);
    }

    public void SaveLog()
    {
        try
        {
            using FileStream fileStream = new(filePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            using StreamWriter writer = new(fileStream);

            foreach (var entry in logs)
            {
                writer.WriteLine(entry);
            }

            logs.Clear();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving text log: {ex.Message}");
        }
    }
}