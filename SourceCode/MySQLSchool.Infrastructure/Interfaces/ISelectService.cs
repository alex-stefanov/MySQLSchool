namespace MySQLSchool.Infrastructure.Interfaces;

public interface ISelectService
{
    void GetStudentsNames();

    void GetTeachersNamesAndSubject();

    void GetClassesAndTeacher();

    void GetSubjectsWithTeacherCount();

    void GetClassroomsOrderedByFloor();

    void GetStudentsByClasses();

    void GetAllStudentsByClass(
        int classNumber,
        char classLetter);

    void GetStudentsWithSpecificBirthday(
        string dateOfBirth);

    void GetCountOfSubjectsByStudent(
        string studentName);

    void GetTeachersAndSubjectsByStudent(
        string studentName);

    void GetClassByParentEmail(
        string parentEmail);
}
