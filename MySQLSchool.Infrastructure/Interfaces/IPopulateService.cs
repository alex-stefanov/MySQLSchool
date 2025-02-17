namespace MySQLSchool.Infrastructure.Interfaces;

public interface IPopulateService
{
    void PopulateParents();

    void PopulateSubjects();

    void PopulateTeachers();

    void PopulateClassrooms();

    void PopulateClasses();

    void PopulateStudents();

    void PopulateTeachersSubjects();

    void PopulateClassesSubjects();

    void PopulateStudentsParents();
}