using L_INTERFACES = MySQLSchool.Logging.Interfaces;

namespace MySQLSchool.Helpers;

//TODO:XML doc
//TODO:type of param
public static class ValidationHelper
{
    public static string GetValidatedInput(
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
                return input;

            Console.WriteLine(errorMessage);
            logger.Log(errorMessage);

        } while (true);
    }

    public static string? GetNotValidatedInput(
        string infoMessage,
        L_INTERFACES.ILogger logger)
    {
        Console.Write(infoMessage);
        string? dateOfBirth = Console.ReadLine();

        logger.Log(infoMessage + dateOfBirth);
        
        return dateOfBirth;
    }
}