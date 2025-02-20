namespace MySQLSchool.Infrastructure.Interfaces;

/// <summary>
/// Defines the methods for creating entities in the system.
/// </summary>
public interface ICreateService
{
    /// <summary>
    /// Creates parents in the system.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int CreateParents();

    /// <summary>
    /// Creates subjects in the system.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int CreateSubjects();

    /// <summary>
    /// Creates teachers in the system.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int CreateTeachers();

    /// <summary>
    /// Creates classrooms in the system.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int CreateClassrooms();

    /// <summary>
    /// Creates classes in the system.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int CreateClasses();

    /// <summary>
    /// Creates students in the system.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int CreateStudents();

    /// <summary>
    /// Creates relationships between teachers and subjects in the system.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int CreateTeachersSubjects();

    /// <summary>
    /// Creates relationships between classes and subjects in the system.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int CreateClassesSubjects();

    /// <summary>
    /// Creates relationships between students and parents in the system.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int CreateStudentsParents();
}