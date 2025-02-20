namespace MySQLSchool.Common.Messages.InsertMessages;

/// <summary>
/// Provides predefined messages for handling teacher-subject assignments.
/// </summary>
public static class TeachersSubjectsMessages
{
    /// <summary>
    /// Message displayed at the start of the teacher-subject assignment process.
    /// </summary>
    public const string StartMessage = "Попълнете данни за учител и предмет:";

    /// <summary>
    /// Information message prompting the user to enter a teacher's identifier.
    /// </summary>
    public const string TeacherIdInfoMessage = "Идентификатор на учител: ";

    /// <summary>
    /// Error message displayed when the teacher's identifier is missing or invalid.
    /// </summary>
    public const string TeacherIdErrorMessage = "Идентификаторът на учителя е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Information message prompting the user to enter a subject's identifier.
    /// </summary>
    public const string SubjectIdInfoMessage = "Идентификатор на предмет: ";

    /// <summary>
    /// Error message displayed when the subject's identifier is missing or invalid.
    /// </summary>
    public const string SubjectIdErrorMessage = "Идентификаторът на предмета е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Message displayed upon successful completion of the teacher-subject assignment process.
    /// </summary>
    public const string EndMessage = "Данните за учителя и предмета са успешно записани.";
}