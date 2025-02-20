namespace MySQLSchool.Common.Messages.CreateMessages;

/// <summary>
/// Provides predefined error messages for creating various entities in the system.
/// </summary>
public static class ErrorMessages
{
    /// <summary>
    /// Error message for creation failure of parent entities.
    /// </summary>
    public const string ParentsMessage = "Error in CreateParents: ";

    /// <summary>
    /// Error message for creation failure of subject entities.
    /// </summary>
    public const string SubjectsMessage = "Error in CreateSubjects: ";

    /// <summary>
    /// Error message for creation failure of teacher entities.
    /// </summary>
    public const string TeachersMessage = "Error in CreateTeachers: ";

    /// <summary>
    /// Error message for creation failure of classroom entities.
    /// </summary>
    public const string ClassroomsMessage = "Error in CreateClassrooms: ";

    /// <summary>
    /// Error message for creation failure of class entities.
    /// </summary>
    public const string ClassesMessage = "Error in CreateClasses: ";

    /// <summary>
    /// Error message for creation failure of student entities.
    /// </summary>
    public const string StudentsMessage = "Error in CreateStudents: ";

    /// <summary>
    /// Error message for creation failure of teacher-subject associations.
    /// </summary>
    public const string TeachersSubjectsMessage = "Error in CreateTeachersSubjects: ";

    /// <summary>
    /// Error message for creation failure of class-subject associations.
    /// </summary>
    public const string ClassesSubjectsMessage = "Error in CreateClassesSubjects: ";

    /// <summary>
    /// Error message for creation failure of student-parent associations.
    /// </summary>
    public const string StudentsParentsMessage = "Error in CreateStudentsParents: ";
}