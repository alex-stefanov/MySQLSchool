using MySqlConnector;
using DATA = MySQLSchool.Data;
using INTERFACES = MySQLSchool.Infrastructure.Interfaces;
using IT_QUERIES = MySQLSchool.Common.Queries.InsertTableQueries;

namespace MySQLSchool.Infrastructure.Implementation;

/// <summary>
/// Implements the <see cref="INTERFACES.IPopulateService"/> interface for populating data entities in the system.
/// </summary>
public class PopulateService
    : INTERFACES.IPopulateService
{
    private static readonly MySqlConnection Connection
        = DATA.DbInitializer.GetConnection();

    /// <inheritdoc/>
    public int PopulateParents(
        string parentCode,
        string fullName,
        string phone,
        string email)
    {
        using var command = new MySqlCommand(IT_QUERIES.InsertParentsQuery, Connection);

        command.Parameters.AddWithValue("@parentCode", parentCode);
        command.Parameters.AddWithValue("@fullName", fullName);
        command.Parameters.AddWithValue("@phone", phone);
        command.Parameters.AddWithValue("@email", email);

        return command.ExecuteNonQuery();
    }

    /// <inheritdoc/>
    public int PopulateSubjects(
        string title,
        string level)
    {
        using var command = new MySqlCommand(IT_QUERIES.InsertSubjects, Connection);

        command.Parameters.AddWithValue("@title", title);
        command.Parameters.AddWithValue("@level", level);

        return command.ExecuteNonQuery();
    }

    /// <inheritdoc/>
    public int PopulateTeachers(
        string teacherCode,
        string fullName,
        string email,
        string phone,
        int workingDays,
        string? dateOfBirth,
        string? gender)
    {
        using var command = new MySqlCommand(IT_QUERIES.InsertTeachers, Connection);

        command.Parameters.AddWithValue("@teacherCode", teacherCode);
        command.Parameters.AddWithValue("@fullName", fullName);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@phone", phone);
        command.Parameters.AddWithValue("@workingDays", workingDays);
        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
        command.Parameters.AddWithValue("@gender", gender);

        return command.ExecuteNonQuery();
    }

    /// <inheritdoc/>
    public int PopulateClassrooms(
        int floor,
        int capacity,
        string description)
    {
        using var command = new MySqlCommand(IT_QUERIES.InsertClassrooms, Connection);

        command.Parameters.AddWithValue("@floor", floor);
        command.Parameters.AddWithValue("@capacity", capacity);
        command.Parameters.AddWithValue("@description", description);

        return command.ExecuteNonQuery();
    }

    /// <inheritdoc/>
    public int PopulateClasses(
        int classNumber,
        char classLetter,
        int classTeacherId,
        int classroomId)
    {
        using var command = new MySqlCommand(IT_QUERIES.InsertClasses, Connection);

        command.Parameters.AddWithValue("@classNumber", classNumber);
        command.Parameters.AddWithValue("@classLetter", classLetter);
        command.Parameters.AddWithValue("@classTeacherId", classTeacherId);
        command.Parameters.AddWithValue("@classroomId", classroomId);

        return command.ExecuteNonQuery();
    }

    /// <inheritdoc/>
    public int PopulateStudents(
        string studentCode,
        string fullName,
        string email,
        string phone,
        int classId,
        bool isActive,
        string? gender,
        string? dateOfBirth)
    {
        using var command = new MySqlCommand(IT_QUERIES.InsertStudents, Connection);

        command.Parameters.AddWithValue("@studentCode", studentCode);
        command.Parameters.AddWithValue("@fullName", fullName);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@phone", phone);
        command.Parameters.AddWithValue("@gender", gender);
        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
        command.Parameters.AddWithValue("@classId", classId);
        command.Parameters.AddWithValue("@isActive", isActive);

        return command.ExecuteNonQuery();
    }

    /// <inheritdoc/>
    public int PopulateTeachersSubjects(
        int teacherId,
        int subjectId)
    {
        using var command = new MySqlCommand(IT_QUERIES.InsertTeachersSubjects, Connection);

        command.Parameters.AddWithValue("@teacherId", teacherId);
        command.Parameters.AddWithValue("@subjectId", subjectId);

        return command.ExecuteNonQuery();
    }

    /// <inheritdoc/>
    public int PopulateClassesSubjects(
        int classId,
        int subjectId)
    {
        using var command = new MySqlCommand(IT_QUERIES.InsertClassesSubjects, Connection);

        command.Parameters.AddWithValue("@classId", classId);
        command.Parameters.AddWithValue("@subjectId", subjectId);

        return command.ExecuteNonQuery();
    }

    /// <inheritdoc/>
    public int PopulateStudentsParents(
        int studentId,
        int parentId)
    {
        using var command = new MySqlCommand(IT_QUERIES.InsertStudentsParents, Connection);

        command.Parameters.AddWithValue("@studentId", studentId);
        command.Parameters.AddWithValue("@parentId", parentId);

        return command.ExecuteNonQuery();
    }
}