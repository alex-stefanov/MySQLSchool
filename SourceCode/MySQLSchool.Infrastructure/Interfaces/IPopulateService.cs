namespace MySQLSchool.Infrastructure.Interfaces;

//TODO:Add params xml doc
//TODO:Validation to capacity\
//TODO: Add returns xml doc

/// <summary>
/// Defines the methods for populating entities in the system.
/// </summary>
public interface IPopulateService
{
    /// <summary>
    /// Populates the parents data in the system.
    /// </summary>
    int PopulateParents(
        string parentCode,
        string fullName,
        string phone,
        string email);

    /// <summary>
    /// Populates the subjects data in the system.
    /// </summary>
    int PopulateSubjects(
        string title,
        string level);

    /// <summary>
    /// Populates the teachers data in the system.
    /// </summary>
    int PopulateTeachers(
        string teacherCode,
        string fullName,
        string email,
        string phone,
        int workingDays,
        string? dateOfBirth,
        string? gender);

    /// <summary>
    /// Populates the classrooms data in the system.
    /// </summary>
    int PopulateClassrooms(
        int floor,
        int capacity,
        string description);

    /// <summary>
    /// Populates the classes data in the system.
    /// </summary>
    int PopulateClasses(
        int classNumber,
        char classLetter,
        int classTeacherId,
        int classroomId);

    /// <summary>
    /// Populates the students data in the system.
    /// </summary>
    int PopulateStudents(
        string studentCode,
        string fullName,
        string email,
        string phone,
        int classId,
        bool isActive,
        string? gender,
        string? dateOfBirth);

    /// <summary>
    /// Populates the relationships between teachers and subjects in the system.
    /// </summary>
    int PopulateTeachersSubjects(
        int teacherId,
        int subjectId);

    /// <summary>
    /// Populates the relationships between classes and subjects in the system.
    /// </summary>
    int PopulateClassesSubjects(
        int classId,
        int subjectId);

    /// <summary>
    /// Populates the relationships between students and parents in the system.
    /// </summary>
    int PopulateStudentsParents(
        int studentId,
        int parentId);
}