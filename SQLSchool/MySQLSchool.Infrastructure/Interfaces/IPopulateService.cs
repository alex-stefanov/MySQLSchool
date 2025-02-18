using L_INTERFACES = MySQLSchool.Logging.Interfaces;

namespace MySQLSchool.Infrastructure.Interfaces;

/// <summary>
/// Defines the methods for populating entities in the system.
/// </summary>
public interface IPopulateService
{
    /// <summary>
    /// Populates the parents data in the system.
    /// </summary>
    /// <param name="logger">The logger used for logging actions and errors.</param>
    void PopulateParents(
        L_INTERFACES.ILogger logger);

    /// <summary>
    /// Populates the subjects data in the system.
    /// </summary>
    /// <param name="logger">The logger used for logging actions and errors.</param>
    void PopulateSubjects(
        L_INTERFACES.ILogger logger);

    /// <summary>
    /// Populates the teachers data in the system.
    /// </summary>
    /// <param name="logger">The logger used for logging actions and errors.</param>
    void PopulateTeachers(
        L_INTERFACES.ILogger logger);

    /// <summary>
    /// Populates the classrooms data in the system.
    /// </summary>
    /// <param name="logger">The logger used for logging actions and errors.</param>
    void PopulateClassrooms(
        L_INTERFACES.ILogger logger);

    /// <summary>
    /// Populates the classes data in the system.
    /// </summary>
    /// <param name="logger">The logger used for logging actions and errors.</param>
    void PopulateClasses(
        L_INTERFACES.ILogger logger);

    /// <summary>
    /// Populates the students data in the system.
    /// </summary>
    /// <param name="logger">The logger used for logging actions and errors.</param>
    void PopulateStudents(
        L_INTERFACES.ILogger logger);

    /// <summary>
    /// Populates the relationships between teachers and subjects in the system.
    /// </summary>
    /// <param name="logger">The logger used for logging actions and errors.</param>
    void PopulateTeachersSubjects(
        L_INTERFACES.ILogger logger);

    /// <summary>
    /// Populates the relationships between classes and subjects in the system.
    /// </summary>
    /// <param name="logger">The logger used for logging actions and errors.</param>
    void PopulateClassesSubjects(
        L_INTERFACES.ILogger logger);

    /// <summary>
    /// Populates the relationships between students and parents in the system.
    /// </summary>
    /// <param name="logger">The logger used for logging actions and errors.</param>
    void PopulateStudentsParents(
        L_INTERFACES.ILogger logger);
}