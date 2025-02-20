namespace MySQLSchool.Common.Messages.InsertMessages;

/// <summary>
/// Provides predefined messages for handling parent data input.
/// </summary>
public static class ParentsMessages
{
    /// <summary>
    /// Message displayed at the start of the parent data input process.
    /// </summary>
    public const string StartMessage = "Попълнете данни за родител:";

    /// <summary>
    /// Information message prompting the user to enter the parent code.
    /// </summary>
    public const string CodeInfoMessage = "Код на родителя: ";

    /// <summary>
    /// Error message displayed when the parent code is missing or invalid.
    /// </summary>
    public const string CodeErrorMessage = "Кодът на родителя е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the full name of the parent.
    /// </summary>
    public const string FullNameInfoMessage = "Пълно име на родителя: ";

    /// <summary>
    /// Error message displayed when the full name of the parent is missing or invalid.
    /// </summary>
    public const string FullNameErrorMessage = "Пълното име на родителя е задължително. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the parent's phone number.
    /// </summary>
    public const string PhoneInfoMessage = "Телефон: ";

    /// <summary>
    /// Error message displayed when the parent's phone number is missing or invalid.
    /// </summary>
    public const string PhoneErrorMessage = "Телефонът е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the parent's email address.
    /// </summary>
    public const string EmailInfoMessage = "Имейл: ";

    /// <summary>
    /// Error message displayed when the parent's email address is missing or invalid.
    /// </summary>
    public const string EmailErrorMessage = "Имейлът е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Message displayed upon successful completion of the parent data input process.
    /// </summary>
    public const string EndMessage = "Данните за родителя са успешно записани.";
}