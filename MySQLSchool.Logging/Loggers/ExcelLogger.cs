using ClosedXML.Excel;
using MySQLSchool.Logging.Interfaces;

namespace MySQLSchool.Logging.Loggers;

public class ExcelLogger(
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
            var fileExists = File.Exists(filePath);

            using var workbook = fileExists
                ? new XLWorkbook(filePath)
                : new XLWorkbook();

            var worksheet = workbook.Worksheets.Count > 0
                ? workbook.Worksheet(1)
                : workbook.Worksheets.Add("Log");

            int lastRow = worksheet.LastRowUsed()?.RowNumber()
                ?? 0;

            for (int i = 0; i < logs.Count; i++)
            {
                worksheet.Cell(lastRow + i + 1, 1).Value = logs[i];
            }

            workbook.SaveAs(filePath);
            logs.Clear();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving Excel log: {ex.Message}");
        }
    }
}
