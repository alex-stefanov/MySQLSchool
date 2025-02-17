namespace MySQLSchool.Infrastructure.Interfaces;

public interface ICreateService
{
    void CreateParents();

    void CreateSubjects();

    void CreateTeachers();

    void CreateClassrooms();

    void CreateClasses();

    void CreateStudents();

    void CreateTeachersSubjects();

    void CreateClassesSubjects();

    void CreateStudentsParents();
}