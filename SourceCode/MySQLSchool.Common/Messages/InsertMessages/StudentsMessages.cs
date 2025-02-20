namespace MySQLSchool.Common.Messages.InsertMessages;

/// <summary>
/// Provides predefined messages for handling student data input.
/// </summary>
public static class StudentsMessages
{
    /// <summary>
    /// Message displayed at the start of the student data input process.
    /// </summary>
    public const string StartMessage = "Попълнете данни за студент:";

    /// <summary>
    /// Information message prompting the user to enter the student code.
    /// </summary>
    public const string CodeInfoMessage = "Код на студента: ";

    /// <summary>
    /// Error message displayed when the student code is missing or invalid.
    /// </summary>
    public const string CodeErrorMessage = "Кодът на студента е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the full name of the student.
    /// </summary>
    public const string FullNameInfoMessage = "Пълно име на студента: ";

    /// <summary>
    /// Error message displayed when the full name of the student is missing or invalid.
    /// </summary>
    public const string FullNameErrorMessage = "Пълното име на студента е задължително. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the student's email.
    /// </summary>
    public const string EmailInfoMessage = "Имейл: ";

    /// <summary>
    /// Error message displayed when the student's email is missing or invalid.
    /// </summary>
    public const string EmailErrorMessage = "Имейлът на студента е задължително. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the student's phone number.
    /// </summary>
    public const string PhoneInfoMessage = "Телефон: ";

    /// <summary>
    /// Error message displayed when the student's phone number is missing or invalid.
    /// </summary>
    public const string PhoneErrorMessage = "Телефонът на студента е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the class identifier.
    /// </summary>
    public const string ClassIdInfoMessage = "Идентификатор на клас: ";

    /// <summary>
    /// Error message displayed when the class identifier is missing or invalid.
    /// </summary>
    public const string ClassIdErrorMessage = "Идентификаторът на класа е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to specify whether the student is active.
    /// </summary>
    public const string IsActiveInfoMessage = "Активен ли е студентът (1 за да, 0 за не): ";

    /// <summary>
    /// Error message displayed when the student's active status is missing or invalid.
    /// </summary>
    public const string IsActiveErrorMessage = "Активността на студента е задължителна. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the student's gender.
    /// </summary>
    public const string GenderInfoMessage = "Пол: ";

    /// <summary>
    /// Information message prompting the user to enter the student's date of birth.
    /// </summary>
    public const string DateOfBirthInfoMessage = "Дата на раждане (YYYY-MM-DD): ";

    /// <summary>
    /// Message displayed upon successful completion of the student data input process.
    /// </summary>
    public const string EndMessage = "Данните за студента са успешно записани.";
}