using MySqlConnector;
using MySQLSchool.Data;
using MySQLSchool.Infrastructure.Interfaces;
using CT_QUERIES = MySQLSchool.Common.Queries.CreateTableQueries;

namespace MySQLSchool.Infrastructure.Implementation;

public class CreateService
    : ICreateService
{
    public readonly static MySqlConnection connection = DbInitializer.GetConnection();

    public void CreateParents()
        => InternalCreate(CT_QUERIES.CreateParentsQuery);    

    public void CreateSubjects()
        => InternalCreate(CT_QUERIES.CreateSubjects);

    public void CreateTeachers()
        => InternalCreate(CT_QUERIES.CreateTeachers);

    public void CreateClassrooms()
        => InternalCreate(CT_QUERIES.CreateClassrooms);
        
    public void CreateClasses()
        => InternalCreate(CT_QUERIES.CreateClasses);

    public void CreateStudents()
        => InternalCreate(CT_QUERIES.CreateStudents);

    public void CreateTeachersSubjects()
        => InternalCreate(CT_QUERIES.CreateTeachersSubjects);

    public void CreateClassesSubjects()
        => InternalCreate(CT_QUERIES.CreateClassesSubjects);

    public void CreateStudentsParents()
        => InternalCreate(CT_QUERIES.CreateStudentsParents);

    private static void InternalCreate(
        string sqlQuery)
    {
        using var command = new MySqlCommand(sqlQuery, connection);

        command.ExecuteNonQuery();
    }
}