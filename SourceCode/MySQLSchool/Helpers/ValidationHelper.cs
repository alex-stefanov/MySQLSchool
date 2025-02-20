using L_INTERFACES = MySQLSchool.Logging.Interfaces;

namespace MySQLSchool.Helpers;

//TODO:XML doc
//TODO:type of param
public static class ValidationHelper
{
    public static T GetValidatedInput<T>(
        string infoMessage,
        string errorMessage,
        L_INTERFACES.ILogger logger)
    {
        do
        {
            Console.Write(infoMessage);
            var input = Console.ReadLine();
        
            logger.Log(infoMessage + input);

            if (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    var value = (T)Convert.ChangeType(input, typeof(T));
                    return value;
                }
                catch
                {
                    continue;
                }
            }

            Console.WriteLine(errorMessage);
            logger.Log(errorMessage);
        } while (true);
    }

    public static string? GetNotValidatedInput(
        string infoMessage,
        L_INTERFACES.ILogger logger)
    {
        Console.Write(infoMessage);
        string? input = Console.ReadLine();

        logger.Log(infoMessage + input);
        
        return input;
    }
}