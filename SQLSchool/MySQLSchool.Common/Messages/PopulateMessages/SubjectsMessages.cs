namespace MySQLSchool.Common.Messages.PopulateMessages;

/// <summary>
/// Provides predefined messages for handling subject data input.
/// </summary>
public static class SubjectsMessages
{
    /// <summary>
    /// Message displayed at the start of the subject data input process.
    /// </summary>
    public const string StartMessage = "Попълнете данни за предмет:";

    /// <summary>
    /// Information message prompting the user to enter the subject title.
    /// </summary>
    public const string TitleInfoMessage = "Заглавие на предмета: ";

    /// <summary>
    /// Error message displayed when the subject title is missing or invalid.
    /// </summary>
    public const string TitleErrorMessage = "Заглавието на предмета е задължително. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the subject level.
    /// </summary>
    public const string LevelInfoMessage = "Ниво на предмета: ";

    /// <summary>
    /// Error message displayed when the subject level is missing or invalid.
    /// </summary>
    public const string LevelErrorMessage = "Нивото на предмета е задължително. Моля, въведете отново.";

    /// <summary>
    /// Message displayed upon successful completion of the subject data input process.
    /// </summary>
    public const string EndMessage = "Данните за предмета са успешно записани.";
}