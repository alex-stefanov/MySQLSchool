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
    public void CreateParents()
        => InternalCreate(CT_QUERIES.CreateParentsQuery);

    /// <inheritdoc/>
    public void CreateSubjects()
        => InternalCreate(CT_QUERIES.CreateSubjects);

    /// <inheritdoc/>
    public void CreateTeachers()
        => InternalCreate(CT_QUERIES.CreateTeachers);

    /// <inheritdoc/>
    public void CreateClassrooms()
        => InternalCreate(CT_QUERIES.CreateClassrooms);

    /// <inheritdoc/>
    public void CreateClasses()
        => InternalCreate(CT_QUERIES.CreateClasses);

    /// <inheritdoc/>
    public void CreateStudents()
        => InternalCreate(CT_QUERIES.CreateStudents);

    /// <inheritdoc/>
    public void CreateTeachersSubjects()
        => InternalCreate(CT_QUERIES.CreateTeachersSubjects);

    /// <inheritdoc/>
    public void CreateClassesSubjects()
        => InternalCreate(CT_QUERIES.CreateClassesSubjects);

    /// <inheritdoc/>
    public void CreateStudentsParents()
        => InternalCreate(CT_QUERIES.CreateStudentsParents);

    private static void InternalCreate(
        string sqlQuery)
    {
        using var command = new MySqlCommand(sqlQuery, Connection);

        command.ExecuteNonQuery();
    }
}