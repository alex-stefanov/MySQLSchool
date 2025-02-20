namespace MySQLSchool.Common.Messages.InsertMessages;

/// <summary>
/// Provides predefined messages for inserting class and subject data.
/// </summary>
public static class ClassesSubjectsMessages
{
    /// <summary>
    /// Message prompting the user to start entering class and subject data.
    /// </summary>
    public const string StartMessage = "Попълнете данни за клас и предмет:";

    /// <summary>
    /// Message requesting the class identifier information.
    /// </summary>
    public const string ClassIdInfoMessage = "Идентификатор на клас: ";

    /// <summary>
    /// Error message indicating that the class identifier is required.
    /// </summary>
    public const string ClassIdErrorMessage = "Идентификаторът на класа е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Message requesting the subject identifier information.
    /// </summary>
    public const string SubjectIdInfoMessage = "Идентификатор на предмет: ";

    /// <summary>
    /// Error message indicating that the subject identifier is required.
    /// </summary>
    public const string SubjectIdErrorMessage = "Идентификаторът на предмета е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Message confirming that the class and subject data has been successfully recorded.
    /// </summary>
    public const string EndMessage = "Данните за класа и предмета са успешно записани.";
}