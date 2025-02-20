namespace MySQLSchool.Common.Messages.InsertMessages;

/// <summary>
/// Provides predefined error messages for logging during the insertion of general data.
/// </summary>
public static class GeneralErrorMessages
{
    /// <summary>
    /// Error message indicating an issue during the insertion of parent data.
    /// </summary>
    public const string ParentsMessage = "Error in InsertParents: ";

    /// <summary>
    /// Error message indicating an issue during the insertion of subject data.
    /// </summary>
    public const string SubjectsMessage = "Error in InsertSubjects: ";

    /// <summary>
    /// Error message indicating an issue during the insertion of teacher data.
    /// </summary>
    public const string TeachersMessage = "Error in InsertTeachers: ";

    /// <summary>
    /// Error message indicating an issue during the insertion of classroom data.
    /// </summary>
    public const string ClassroomsMessage = "Error in InsertClassrooms: ";

    /// <summary>
    /// Error message indicating an issue during the insertion of class data.
    /// </summary>
    public const string ClassesMessage = "Error in InsertClasses: ";

    /// <summary>
    /// Error message indicating an issue during the insertion of student data.
    /// </summary>
    public const string StudentsMessage = "Error in InsertStudents: ";

    /// <summary>
    /// Error message indicating an issue during the insertion of teacher-subject relationships.
    /// </summary>
    public const string TeachersSubjectsMessage = "Error in InsertTeachersSubjects: ";

    /// <summary>
    /// Error message indicating an issue during the insertion of class-subject relationships.
    /// </summary>
    public const string ClassesSubjectsMessage = "Error in InsertClassesSubjects: ";

    /// <summary>
    /// Error message indicating an issue during the insertion of student-parent relationships.
    /// </summary>
    public const string StudentsParentsMessage = "Error in InsertStudentsParents: ";
}