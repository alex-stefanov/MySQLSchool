using MySqlConnector;
using DATA = MySQLSchool.Data;
using INTERFACES = MySQLSchool.Infrastructure.Interfaces;
using CT_QUERIES = MySQLSchool.Common.Queries.CreateTableQueries;

namespace MySQLSchool.Infrastructure.Implementation;

/// <summary>
/// Implements the <see cref="INTERFACES.ICreateService"/> interface for creating data entities in the system.
/// </summary>
public class CreateService
    : INTERFACES.ICreateService
{
    private static readonly MySqlConnection Connection
        = DATA.DbInitializer.GetConnection();

    /// <inheritdoc/>
    public int CreateParents()
        => InternalCommandExecute(CT_QUERIES.CreateParentsQuery);

    /// <inheritdoc/>
    public int CreateSubjects()
        => InternalCommandExecute(CT_QUERIES.CreateSubjects);

    /// <inheritdoc/>
    public int CreateTeachers()
        => InternalCommandExecute(CT_QUERIES.CreateTeachers);

    /// <inheritdoc/>
    public int CreateClassrooms()
        => InternalCommandExecute(CT_QUERIES.CreateClassrooms);

    /// <inheritdoc/>
    public int CreateClasses()
        => InternalCommandExecute(CT_QUERIES.CreateClasses);

    /// <inheritdoc/>
    public int CreateStudents()
        => InternalCommandExecute(CT_QUERIES.CreateStudents);

    /// <inheritdoc/>
    public int CreateTeachersSubjects()
        => InternalCommandExecute(CT_QUERIES.CreateTeachersSubjects);

    /// <inheritdoc/>
    public int CreateClassesSubjects()
        => InternalCommandExecute(CT_QUERIES.CreateClassesSubjects);

    /// <inheritdoc/>
    public int CreateStudentsParents()
        => InternalCommandExecute(CT_QUERIES.CreateStudentsParents);

    private static int InternalCommandExecute(
        string sqlQuery)
    {
        using var command = new MySqlCommand(sqlQuery, Connection);

        return command.ExecuteNonQuery();
    }
}