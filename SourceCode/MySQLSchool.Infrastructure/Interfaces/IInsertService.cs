namespace MySQLSchool.Infrastructure.Interfaces;

/// <summary>
/// Defines the methods for inserting entities into the system.
/// </summary>
public interface IInsertService
{
    /// <summary>
    /// Inserts the parents data into the system.
    /// </summary>
    /// <param name="parentCode">The unique code of the parent.</param>
    /// <param name="fullName">The full name of the parent.</param>
    /// <param name="phone">The phone number of the parent.</param>
    /// <param name="email">The email address of the parent.</param>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertParents(
        string parentCode,
        string fullName,
        string phone,
        string email);

    /// <summary>
    /// Inserts the subjects data into the system.
    /// </summary>
    /// <param name="title">The title of the subject.</param>
    /// <param name="level">The level of the subject.</param>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertSubjects(
        string title,
        string level);

    /// <summary>
    /// Inserts the teachers data into the system.
    /// </summary>
    /// <param name="teacherCode">The unique code of the teacher.</param>
    /// <param name="fullName">The full name of the teacher.</param>
    /// <param name="email">The email address of the teacher.</param>
    /// <param name="phone">The phone number of the teacher.</param>
    /// <param name="workingDays">The number of working days per week for the teacher.</param>
    /// <param name="dateOfBirth">The birth date of the teacher (optional).</param>
    /// <param name="gender">The gender of the teacher (optional).</param>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertTeachers(
        string teacherCode,
        string fullName,
        string email,
        string phone,
        int workingDays,
        string? dateOfBirth,
        string? gender);

    /// <summary>
    /// Inserts the classrooms data into the system.
    /// </summary>
    /// <param name="floor">The floor number where the classroom is located.</param>
    /// <param name="capacity">The seating capacity of the classroom.</param>
    /// <param name="description">A description of the classroom.</param>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertClassrooms(
        int floor,
        int capacity,
        string description);

    /// <summary>
    /// Inserts the classes data into the system.
    /// </summary>
    /// <param name="classNumber">The number of the class.</param>
    /// <param name="classLetter">The letter of the class.</param>
    /// <param name="classTeacherId">The ID of the teacher assigned to the class.</param>
    /// <param name="classroomId">The ID of the classroom assigned to the class.</param>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertClasses(
        int classNumber,
        char classLetter,
        int classTeacherId,
        int classroomId);

    /// <summary>
    /// Inserts the students data into the system.
    /// </summary>
    /// <param name="studentCode">The unique code of the student.</param>
    /// <param name="fullName">The full name of the student.</param>
    /// <param name="email">The email address of the student.</param>
    /// <param name="phone">The phone number of the student.</param>
    /// <param name="classId">The ID of the class the student belongs to.</param>
    /// <param name="isActive">A flag indicating whether the student is active.</param>
    /// <param name="gender">The gender of the student (optional).</param>
    /// <param name="dateOfBirth">The birthdate of the student (optional).</param>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertStudents(
        string studentCode,
        string fullName,
        string email,
        string phone,
        int classId,
        bool isActive,
        string? gender,
        string? dateOfBirth);

    /// <summary>
    /// Inserts the relationships between teachers and subjects into the system.
    /// </summary>
    /// <param name="teacherId">The ID of the teacher.</param>
    /// <param name="subjectId">The ID of the subject.</param>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertTeachersSubjects(
        int teacherId,
        int subjectId);

    /// <summary>
    /// Inserts the relationships between classes and subjects into the system.
    /// </summary>
    /// <param name="classId">The ID of the class.</param>
    /// <param name="subjectId">The ID of the subject.</param>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertClassesSubjects(
        int classId,
        int subjectId);

    /// <summary>
    /// Inserts the relationships between students and parents into the system.
    /// </summary>
    /// <param name="studentId">The ID of the student.</param>
    /// <param name="parentId">The ID of the parent.</param>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertStudentsParents(
        int studentId,
        int parentId);

    /// <summary>
    /// Inserts the parents data into the system with default values.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertParentsWithDefault();

    /// <summary>
    /// Inserts the subjects data into the system with default values.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertSubjectsWithDefault();

    /// <summary>
    /// Inserts the teachers data into the system with default values.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertTeachersWithDefault();

    /// <summary>
    /// Inserts the classrooms data into the system with default values.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertClassroomsWithDefault();

    /// <summary>
    /// Inserts the classes data into the system with default values.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertClassesWithDefault();

    /// <summary>
    /// Inserts the students data into the system with default values.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertStudentsWithDefault();

    /// <summary>
    /// Inserts the relationships between teachers and subjects into the system with default values.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertTeachersSubjectsWithDefault();

    /// <summary>
    /// Inserts the relationships between classes and subjects into the system with default values.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertClassesSubjectsWithDefault();

    /// <summary>
    /// Inserts the relationships between students and parents into the system with default values.
    /// </summary>
    /// <returns>An integer indicating the number of rows affected by the operation.</returns>
    int InsertStudentsParentsWithDefault();
}