namespace MySQLSchool.Infrastructure.Interfaces;

//TODO: Add returns xml doc

/// <summary>
/// Defines the methods for creating entities in the system.
/// </summary>
public interface ICreateService
{
    /// <summary>
    /// Creates parents in the system.
    /// </summary>
    int CreateParents();

    /// <summary>
    /// Creates subjects in the system.
    /// </summary>
    int CreateSubjects();

    /// <summary>
    /// Creates teachers in the system.
    /// </summary>
    int CreateTeachers();

    /// <summary>
    /// Creates classrooms in the system.
    /// </summary>
    int CreateClassrooms();

    /// <summary>
    /// Creates classes in the system.
    /// </summary>
    int CreateClasses();

    /// <summary>
    /// Creates students in the system.
    /// </summary>
    int CreateStudents();

    /// <summary>
    /// Creates relationships between teachers and subjects in the system.
    /// </summary>
    int CreateTeachersSubjects();

    /// <summary>
    /// Creates relationships between classes and subjects in the system.
    /// </summary>
    int CreateClassesSubjects();

    /// <summary>
    /// Creates relationships between students and parents in the system.
    /// </summary>
    int CreateStudentsParents();
}