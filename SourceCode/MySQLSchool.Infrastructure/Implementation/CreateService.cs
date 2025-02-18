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
        => InternalCreate(CT_QUERIES.CreateParentsQuery);

    /// <inheritdoc/>
    public int CreateSubjects()
        => InternalCreate(CT_QUERIES.CreateSubjects);

    /// <inheritdoc/>
    public int CreateTeachers()
        => InternalCreate(CT_QUERIES.CreateTeachers);

    /// <inheritdoc/>
    public int CreateClassrooms()
        => InternalCreate(CT_QUERIES.CreateClassrooms);

    /// <inheritdoc/>
    public int CreateClasses()
        => InternalCreate(CT_QUERIES.CreateClasses);

    /// <inheritdoc/>
    public int CreateStudents()
        => InternalCreate(CT_QUERIES.CreateStudents);

    /// <inheritdoc/>
    public int CreateTeachersSubjects()
        => InternalCreate(CT_QUERIES.CreateTeachersSubjects);

    /// <inheritdoc/>
    public int CreateClassesSubjects()
        => InternalCreate(CT_QUERIES.CreateClassesSubjects);

    /// <inheritdoc/>
    public int CreateStudentsParents()
        => InternalCreate(CT_QUERIES.CreateStudentsParents);

    private static int InternalCreate(
        string sqlQuery)
    {
        using var command = new MySqlCommand(sqlQuery, Connection);

        return command.ExecuteNonQuery();
    }
}