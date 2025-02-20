namespace MySQLSchool.Common.Messages.InsertMessages;

/// <summary>
/// Provides predefined messages for handling student-parent relationship data input.
/// </summary>
public static class StudentsParentsMessages
{
    /// <summary>
    /// Message displayed at the start of the student-parent data input process.
    /// </summary>
    public const string StartMessage = "Попълнете данни за студент и родител:";

    /// <summary>
    /// Information message prompting the user to enter the student identifier.
    /// </summary>
    public const string StudentIdInfoMessage = "Идентификатор на студент: ";

    /// <summary>
    /// Error message displayed when the student identifier is missing or invalid.
    /// </summary>
    public const string StudentIdErrorMessage = "Идентификаторът на студента е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter the parent identifier.
    /// </summary>
    public const string ParentIdInfoMessage = "Идентификатор на родител: ";

    /// <summary>
    /// Error message displayed when the parent identifier is missing or invalid.
    /// </summary>
    public const string ParentIdErrorMessage = "Идентификаторът на родителя е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Message displayed upon successful completion of the student-parent data input process.
    /// </summary>
    public const string EndMessage = "Данните за студента и родителя са успешно записани.";
}