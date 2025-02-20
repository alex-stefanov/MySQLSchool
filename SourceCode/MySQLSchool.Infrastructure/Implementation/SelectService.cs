using System.Text;
using MySqlConnector;
using DATA = MySQLSchool.Data;
using INTERFACES = MySQLSchool.Infrastructure.Interfaces;
using S_QUERIES = MySQLSchool.Common.Queries.SelectQueries;

namespace MySQLSchool.Infrastructure.Implementation;

public class SelectService
    : INTERFACES.ISelectService
{
    private static readonly MySqlConnection Connection
       = DATA.DbInitializer.GetConnection();

    /// <inheritdoc/>
    public string GetStudentsNames()
    {
        using MySqlCommand command = new(S_QUERIES.SelectStudentsByClass, Connection);
        
        command.Parameters.AddWithValue("@classNumber", 11);
        command.Parameters.AddWithValue("@classLetter", 'б');

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetTeachersNamesAndSubject()
    {
        using MySqlCommand command = new(S_QUERIES.SelectSubjectsWithTeachers, Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetClassesAndTeacher()
    {
        using MySqlCommand command = new(S_QUERIES.SelectClassesWithTeachers, Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}{sqlDataReader[1]} - {sqlDataReader[2]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetSubjectsWithTeacherCount()
    {
        using MySqlCommand command = new(S_QUERIES.SelectTeacherCountBySubject, Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetClassroomsOrderedByFloor()
    {
        using MySqlCommand command = new(S_QUERIES.SelectClassroomsWithCapacity, Connection);
        
        command.Parameters.AddWithValue("@capacityThreshold", 26);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetStudentsByClasses()
    {
        using MySqlCommand command = new(S_QUERIES.SelectStudentsGroupedByClass, Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetAllStudentsByClass(
        int classNumber,
        char classLetter)
    {
        using MySqlCommand command = new(S_QUERIES.SelectStudentsByClass, Connection);
        
        command.Parameters.AddWithValue("@classNumber", classNumber);
        command.Parameters.AddWithValue("@classLetter", classLetter);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetStudentsWithSpecificBirthday(
        string dateOfBirth)
    {
        using MySqlCommand command = new(S_QUERIES.SelectStudentsByDateOfBirth, Connection);
        
        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetCountOfSubjectsByStudent(
        string studentName)
    {
        using MySqlCommand command = new(S_QUERIES.SelectSubjectCountByStudent, Connection);
        
        command.Parameters.AddWithValue("@studentName", studentName);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetTeachersAndSubjectsByStudent(
        string studentName)
    {
        using MySqlCommand command = new(S_QUERIES.SelectTeacherAndSubjectsByStudent, Connection);
        
        command.Parameters.AddWithValue("@studentName", studentName);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }

    /// <inheritdoc/>
    public string GetClassByParentEmail(
        string parentEmail)
    {
        using MySqlCommand command = new(S_QUERIES.SelectClassByParentEmail, Connection);
        
        command.Parameters.AddWithValue("@parentEmail", parentEmail);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}{sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }
}