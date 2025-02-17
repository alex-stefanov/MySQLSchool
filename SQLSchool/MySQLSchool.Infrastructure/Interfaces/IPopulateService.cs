using L_INTERFACES = MySQLSchool.Logging.Interfaces;

namespace MySQLSchool.Infrastructure.Interfaces;

public interface IPopulateService
{
    void PopulateParents(
        L_INTERFACES.ILogger logger);

    void PopulateSubjects(
        L_INTERFACES.ILogger logger);

    void PopulateTeachers(
        L_INTERFACES.ILogger logger);

    void PopulateClassrooms(
        L_INTERFACES.ILogger logger);

    void PopulateClasses(
        L_INTERFACES.ILogger logger);

    void PopulateStudents(
        L_INTERFACES.ILogger logger);

    void PopulateTeachersSubjects(
        L_INTERFACES.ILogger logger);

    void PopulateClassesSubjects(
        L_INTERFACES.ILogger logger);

    void PopulateStudentsParents(
        L_INTERFACES.ILogger logger);
}