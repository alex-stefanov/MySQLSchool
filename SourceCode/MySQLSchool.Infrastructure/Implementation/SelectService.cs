using System.Text;
using MySqlConnector;
using DATA = MySQLSchool.Data;
using INTERFACES = MySQLSchool.Infrastructure.Interfaces;

namespace MySQLSchool.Infrastructure.Implementation;

//TODO: Move selects in queries constants
public class SelectService
    : INTERFACES.ISelectService
{
    private static readonly MySqlConnection Connection
       = DATA.DbInitializer.GetConnection();

    public string GetStudentsNames()
    {
        using MySqlCommand command = new("SELECT s.full_name FROM students s JOIN classes c ON s.class_id = c.id WHERE c.class_number = 11 AND c.class_letter = 'б'",
            Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetTeachersNamesAndSubject()
    {
        using MySqlCommand command = new("SELECT sub.title AS subject_name, GROUP_CONCAT(t.full_name SEPARATOR ', ') AS teachers FROM teachers_subjects ts JOIN teachers t ON ts.teacher_id = t.id JOIN subjects sub ON ts.subject_id = sub.id GROUP BY sub.title",
           Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetClassesAndTeacher()
    {
        using MySqlCommand command = new("SELECT c.class_number, c.class_letter, t.full_name FROM classes c JOIN teachers t ON t.id = c.class_teacher_id",
            Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}{sqlDataReader[1]} - {sqlDataReader[2]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetSubjectsWithTeacherCount()
    {
        using MySqlCommand command = new("SELECT s.title AS 'Предмет на учителя', COUNT(ts.teacher_id) AS 'Броят на учителите' FROM teachers t JOIN teachers_subjects ts ON t.id = ts.teacher_id JOIN subjects s ON ts.subject_id = s.id GROUP BY s.title",
            Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetClassroomsOrderedByFloor()
    {
        using MySqlCommand command = new("SELECT classrooms.id, classrooms.capacity FROM classrooms WHERE classrooms.capacity > 26 ORDER BY classrooms.floor ASC",
             Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetStudentsByClasses()
    {
        using MySqlCommand command = new("SELECT CONCAT(c.class_number, c.class_letter) AS class_name, GROUP_CONCAT(s.full_name SEPARATOR ', ') AS student_names FROM students s JOIN classes c ON s.class_id = c.id GROUP BY c.class_number, c.class_letter ORDER BY c.class_number ASC, c.class_letter ASC; ",
            Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetAllStudentsByClass(
        int classNumber,
        char classLetter)
    {
        using MySqlCommand command = new($"SELECT s.full_name FROM students s JOIN classes c ON s.class_id = c.id WHERE c.class_number = {classNumber} AND c.class_letter = '{classLetter}'",
            Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetStudentsWithSpecificBirthday(
        string dateOfBirth)
    {
        using MySqlCommand command = new($"SELECT students.full_name FROM students WHERE students.date_of_birth = '{dateOfBirth}'",
            Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetCountOfSubjectsByStudent(
        string studentName)
    {
        using MySqlCommand command = new($"SELECT COUNT(sj.id) AS subject_count FROM students s JOIN classes c ON c.id = s.class_id JOIN classes_subjects cs ON c.id = cs.class_id JOIN subjects sj ON sj.id = cs.subject_id WHERE s.full_name = '{studentName}';",
            Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetTeachersAndSubjectsByStudent(
        string studentName)
    {
        using MySqlCommand command = new($"SELECT t.full_name AS 'Учител', sj.title AS 'Предмет' FROM students s JOIN classes c ON c.id = s.id JOIN teachers t ON t.id = c.class_teacher_id JOIN teachers_subjects ts ON ts.teacher_id = t.id JOIN subjects sj ON sj.id = ts.subject_id WHERE s.full_name = '{studentName}'",
            Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string GetClassByParentEmail(
        string parentEmail)
    {
        using MySqlCommand command = new($"SELECT c.class_number, c.class_letter FROM parents p JOIN students_parents sp ON p.id = sp.parent_id JOIN students s ON s.id = sp.student_id JOIN classes c ON s.class_id = c.id WHERE p.email = '{parentEmail}'",
            Connection);

        using var sqlDataReader = command.ExecuteReader();

        var stringBuilder = new StringBuilder();

        while (sqlDataReader.Read())
        {
            stringBuilder.AppendLine($"{sqlDataReader[0]}{sqlDataReader[1]}");
        }

        return stringBuilder.ToString().Trim();
    }
}