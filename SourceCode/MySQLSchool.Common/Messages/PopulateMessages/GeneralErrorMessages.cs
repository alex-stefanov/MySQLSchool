namespace MySQLSchool.Common.Messages.PopulateMessages;

/// <summary>
/// Provides predefined error messages for logging during the population of general data.
/// </summary>
public static class GeneralErrorMessages
{
    /// <summary>
    /// Error message indicating an issue during the population of parent data.
    /// </summary>
    public const string ParentsMessage = "Error in PopulateParents: ";

    /// <summary>
    /// Error message indicating an issue during the population of subject data.
    /// </summary>
    public const string SubjectsMessage = "Error in PopulateSubjects: ";

    /// <summary>
    /// Error message indicating an issue during the population of teacher data.
    /// </summary>
    public const string TeachersMessage = "Error in PopulateTeachers: ";

    /// <summary>
    /// Error message indicating an issue during the population of classroom data.
    /// </summary>
    public const string ClassroomsMessage = "Error in PopulateClassrooms: ";

    /// <summary>
    /// Error message indicating an issue during the population of class data.
    /// </summary>
    public const string ClassesMessage = "Error in PopulateClasses: ";

    /// <summary>
    /// Error message indicating an issue during the population of student data.
    /// </summary>
    public const string StudentsMessage = "Error in PopulateStudents: ";

    /// <summary>
    /// Error message indicating an issue during the population of teacher-subject relationships.
    /// </summary>
    public const string TeachersSubjectsMessage = "Error in PopulateTeachersSubjects: ";

    /// <summary>
    /// Error message indicating an issue during the population of class-subject relationships.
    /// </summary>
    public const string ClassesSubjectsMessage = "Error in PopulateClassesSubjects: ";

    /// <summary>
    /// Error message indicating an issue during the population of student-parent relationships.
    /// </summary>
    public const string StudentsParentsMessage = "Error in PopulateStudentsParents: ";
}