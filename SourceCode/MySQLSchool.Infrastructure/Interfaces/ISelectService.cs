namespace MySQLSchool.Infrastructure.Interfaces;

/// <summary>
/// Defines methods for selecting various types of data related to students, teachers, subjects, and classrooms.
/// </summary>
public interface ISelectService
{
    /// <summary>
    /// Retrieves the names of all students in the system.
    /// </summary>
    /// <returns>A string containing the names of all students.</returns>
    string GetStudentsNames();

    /// <summary>
    /// Retrieves the names of all teachers and their corresponding subjects, grouped by subject.
    /// </summary>
    /// <returns>A string containing the names of teachers and their subjects, grouped by subject.</returns>
    string GetTeachersNamesAndSubject();

    /// <summary>
    /// Retrieves the list of classes and their assigned teachers.
    /// </summary>
    /// <returns>A string containing the class number, class letter, and the name of the assigned teacher.</returns>
    string GetClassesAndTeacher();

    /// <summary>
    /// Retrieves the list of subjects and the count of teachers teaching each subject.
    /// </summary>
    /// <returns>A string containing the subject title and the number of teachers teaching that subject.</returns>
    string GetSubjectsWithTeacherCount();

    /// <summary>
    /// Retrieves a list of classrooms that have a capacity greater than 26, ordered by floor.
    /// </summary>
    /// <returns>A string containing the classroom ID and capacity of classrooms with more than 26 seats, ordered by floor.</returns>
    string GetClassroomsOrderedByFloor();

    /// <summary>
    /// Retrieves the names of students, grouped by class and ordered by class number and letter.
    /// </summary>
    /// <returns>A string containing the names of students, grouped by class.</returns>
    string GetStudentsByClasses();

    /// <summary>
    /// Retrieves the names of students from a specific class and letter.
    /// </summary>
    /// <param name="classNumber">The class number.</param>
    /// <param name="classLetter">The class letter.</param>
    /// <returns>A string containing the names of students from the specified class and letter.</returns>
    string GetAllStudentsByClass(
        int classNumber,
        char classLetter);

    /// <summary>
    /// Retrieves the names of students born on a specific date.
    /// </summary>
    /// <param name="dateOfBirth">The birth date to filter students by.</param>
    /// <returns>A string containing the names of students born on the specified date.</returns>
    string GetStudentsWithSpecificBirthday(
        string dateOfBirth);

    /// <summary>
    /// Retrieves the count of subjects for a specific student.
    /// </summary>
    /// <param name="studentName">The name of the student.</param>
    /// <returns>A string containing the count of subjects associated with the specified student.</returns>
    string GetCountOfSubjectsByStudent(
        string studentName);

    /// <summary>
    /// Retrieves the names of teachers and the subjects they teach for a specific student.
    /// </summary>
    /// <param name="studentName">The name of the student.</param>
    /// <returns>A string containing the names of teachers and their corresponding subjects for the specified student.</returns>
    string GetTeachersAndSubjectsByStudent(
        string studentName);

    /// <summary>
    /// Retrieves the classes in which the children of a specific parent are enrolled, identified by the parent's email.
    /// </summary>
    /// <param name="parentEmail">The email of the parent.</param>
    /// <returns>A string containing the class numbers and letters where the parent's children are enrolled.</returns>
    string GetClassByParentEmail(
        string parentEmail);
}
