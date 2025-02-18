using ClosedXML.Excel;
using INTERFACES = MySQLSchool.Logging.Interfaces;

namespace MySQLSchool.Logging.Loggers;

/// <summary>
/// A logger that stores logs in an Excel file.
/// </summary>
public class ExcelLogger(
    string filePath)
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
    /// Saves the collected logs to the Excel file.
    /// </summary>
    public void SaveLog()
    {
        try
        {
            var fileExists = File.Exists(filePath);

            using var workbook = fileExists
                ? new XLWorkbook(filePath)
                : new XLWorkbook();

            var worksheet = workbook.Worksheets.Count > 0
                ? workbook.Worksheet(1)
                : workbook.Worksheets.Add("Log");

            var lastRow = worksheet.LastRowUsed()?.RowNumber()
                ?? 0;

            for (var i = 0; i < _logs.Count; i++)
            {
                worksheet.Cell(lastRow + i + 1, 1).Value = _logs[i];
            }

            workbook.SaveAs(filePath);
            _logs.Clear();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving Excel log: {ex.Message}");
        }
    }
}