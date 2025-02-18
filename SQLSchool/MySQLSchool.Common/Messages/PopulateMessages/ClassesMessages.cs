namespace MySQLSchool.Common.Messages.PopulateMessages;

/// <summary>
/// Provides predefined messages for populating class data.
/// </summary>
public static class ClassesMessages
{
    /// <summary>
    /// Message prompting the user to start entering class data.
    /// </summary>
    public const string StartMessage = "Попълнете данни за клас:";

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
    /// Message requesting the teacher identifier for the class.
    /// </summary>
    public const string TeacherIdInfoMessage = "Идентификатор на учител на клас: ";

    /// <summary>
    /// Error message indicating that the teacher identifier for the class is required.
    /// </summary>
    public const string TeacherIdErrorMessage = "Идентификатор на учителя на класа е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Message requesting the classroom identifier for the class.
    /// </summary>
    public const string ClassroomIdInfoMessage = "Идентификатор на класна стая: ";

    /// <summary>
    /// Error message indicating that the classroom identifier is required.
    /// </summary>
    public const string ClassroomIdErrorMessage = "Идентификатор на класната стая е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Message confirming that the class data has been successfully recorded.
    /// </summary>
    public const string EndMessage = "Данните за класа са успешно записани.";
}