//TODO:Add xml doc

namespace MySQLSchool.Infrastructure.Interfaces;

public interface ISelectService
{
    string GetStudentsNames();

    string GetTeachersNamesAndSubject();

    string GetClassesAndTeacher();

    string GetSubjectsWithTeacherCount();

    string GetClassroomsOrderedByFloor();

    string GetStudentsByClasses();

    string GetAllStudentsByClass(
        int classNumber,
        char classLetter);

    string GetStudentsWithSpecificBirthday(
        string dateOfBirth);

    string GetCountOfSubjectsByStudent(
        string studentName);

    string GetTeachersAndSubjectsByStudent(
        string studentName);

    string GetClassByParentEmail(
        string parentEmail);
}
