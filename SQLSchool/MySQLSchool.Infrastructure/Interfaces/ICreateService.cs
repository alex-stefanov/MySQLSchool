namespace MySQLSchool.Infrastructure.Interfaces;

/// <summary>
/// Defines the methods for creating entities in the system.
/// </summary>
public interface ICreateService
{
    /// <summary>
    /// Creates parents in the system.
    /// </summary>
    void CreateParents();

    /// <summary>
    /// Creates subjects in the system.
    /// </summary>
    void CreateSubjects();

    /// <summary>
    /// Creates teachers in the system.
    /// </summary>
    void CreateTeachers();

    /// <summary>
    /// Creates classrooms in the system.
    /// </summary>
    void CreateClassrooms();

    /// <summary>
    /// Creates classes in the system.
    /// </summary>
    void CreateClasses();

    /// <summary>
    /// Creates students in the system.
    /// </summary>
    void CreateStudents();

    /// <summary>
    /// Creates relationships between teachers and subjects in the system.
    /// </summary>
    void CreateTeachersSubjects();

    /// <summary>
    /// Creates relationships between classes and subjects in the system.
    /// </summary>
    void CreateClassesSubjects();

    /// <summary>
    /// Creates relationships between students and parents in the system.
    /// </summary>
    void CreateStudentsParents();
}