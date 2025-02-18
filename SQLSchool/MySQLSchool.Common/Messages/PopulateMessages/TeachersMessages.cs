namespace MySQLSchool.Common.Messages.PopulateMessages;

/// <summary>
/// Provides predefined messages for handling teacher data input.
/// </summary>
public static class TeachersMessages
{
    /// <summary>
    /// Message displayed at the start of the teacher data input process.
    /// </summary>
    public const string StartMessage = "Попълнете данни за учител:";

    /// <summary>
    /// Information message prompting the user to enter the teacher's code.
    /// </summary>
    public const string CodeInfoMessage = "Код на учителя: ";

    /// <summary>
    /// Error message displayed when the teacher's code is missing or invalid.
    /// </summary>
    public const string CodeErrorMessage = "Кодът на учителя е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the teacher's full name.
    /// </summary>
    public const string FullNameInfoMessage = "Пълно име на учителя: ";

    /// <summary>
    /// Error message displayed when the teacher's full name is missing or invalid.
    /// </summary>
    public const string FullNameErrorMessage = "Пълното име на учителя е задължително. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the teacher's email.
    /// </summary>
    public const string EmailInfoMessage = "Имейл: ";

    /// <summary>
    /// Error message displayed when the teacher's email is missing or invalid.
    /// </summary>
    public const string EmailErrorMessage = "Имейлът на учителя е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the teacher's phone number.
    /// </summary>
    public const string PhoneInfoMessage = "Телефон: ";

    /// <summary>
    /// Error message displayed when the teacher's phone number is missing or invalid.
    /// </summary>
    public const string PhoneErrorMessage = "Телефонът на учителя е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the teacher's working days.
    /// </summary>
    public const string WorkingDaysInfoMessage = "Работни дни: ";

    /// <summary>
    /// Error message displayed when the teacher's working days information is missing or invalid.
    /// </summary>
    public const string WorkingDaysErrorMessage = "Работните дни на учителя са задължителни. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the teacher's date of birth.
    /// </summary>
    public const string DateOfBirthInfoMessage = "Дата на раждане (YYYY-MM-DD): ";

    /// <summary>
    /// Information message prompting the user to enter the teacher's gender.
    /// </summary>
    public const string GenderInfoMessage = "Пол: ";

    /// <summary>
    /// Message displayed upon successful completion of the teacher data input process.
    /// </summary>
    public const string EndMessage = "Данните за учителя са успешно записани.";
}