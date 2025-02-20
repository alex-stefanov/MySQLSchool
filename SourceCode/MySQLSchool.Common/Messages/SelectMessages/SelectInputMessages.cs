namespace MySQLSchool.Common.Messages.SelectMessages;

/// <summary>
/// Provides predefined messages for handling select assignments.
/// </summary>
public static class SelectInputMessages
{
    /// <summary>
    /// Message requesting the class number information.
    /// </summary>
    public const string NumberInfoMessage = "Номер на клас: ";

    /// <summary>
    /// Error message indicating that the class number is required.
    /// </summary>
    public const string NumberErrorMessage = "Номерът на класа е задължителен. Моля, въведете отново.";
    
    /// <summary>
    /// Message requesting the class letter information.
    /// </summary>
    public const string LetterInfoMessage = "Буква на клас: ";

    /// <summary>
    /// Error message indicating that the class letter is required.
    /// </summary>
    public const string LetterErrorMessage = "Буквата на класа е задължителна. Моля, въведете отново.";
    
    /// <summary>
    /// Information message prompting the user to enter the student's date of birth.
    /// </summary>
    public const string DateOfBirthInfoMessage = "Дата на раждане (YYYY-MM-DD): ";
    
    /// <summary>
    /// Error message indicating that the date of birth is required.
    /// </summary>
    public const string DateOfBirthErrorMessage = "Датата на раждане (YYYY-MM-DD) е задължителна. Моля, въведете отново.";
    
    /// <summary>
    /// Information message prompting the user to enter the full name of the student.
    /// </summary>
    public const string FullNameInfoMessage = "Пълно име на студента: ";

    /// <summary>
    /// Error message displayed when the full name of the student is missing or invalid.
    /// </summary>
    public const string FullNameErrorMessage = "Пълното име на студента е задължително. Моля, въведете отново.";
    
    /// <summary>
    /// Information message prompting the user to enter the parent's email address.
    /// </summary>
    public const string EmailInfoMessage = "Имейл: ";

    /// <summary>
    /// Error message displayed when the parent's email address is missing or invalid.
    /// </summary>
    public const string EmailErrorMessage = "Имейлът е задължителен. Моля, въведете отново.";
}