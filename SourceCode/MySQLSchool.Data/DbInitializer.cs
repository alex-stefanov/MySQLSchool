using MySqlConnector;
using COMMON = MySQLSchool.Common;

namespace MySQLSchool.Data;

/// <summary>
/// Initializes the database connection for the application.
/// </summary>
public static class DbInitializer
{
    private static readonly MySqlConnection Connection
        = new(COMMON.SchoolOptions.ConnectionString);

    /// <summary>
    /// Opens the database connection to the configured MySQL database.
    /// </summary>
    public static void Initialize()
    {
        Connection.Open();
    }

    //TODO: Remove it from here and put it in the PopulateService
    public static void DefaultSeed(
        bool isDatabaseCreated,
        MySqlConnection connection)
    {
        var seed = new string[]
        {
            @"INSERT INTO parents (parent_code, full_name, phone, email)
                VALUES 
                ('P001', 'Мария Иванова', '0888123456', 'maria.ivanova@example.com'),
                ('P002', 'Георги Петров', '0877123456', 'georgi.petroff@example.com'),
                ('P003', 'Иван Димитров', '0899123456', 'ivan.dimitrov@example.com');",

            @"INSERT INTO subjects (title, level)
                VALUES 
                ('Математика', 'Основно'),
                ('Български език', 'Основно'),
                ('Физика', 'Средно'),
                ('История', 'Основно');",

            @"INSERT INTO teachers (teacher_code, full_name, email, phone, working_days, date_of_birth, gender)
                VALUES
                ('T001', 'Мария Петрова', 'maria.petrova@example.com', '0882345678', 5, '1980-02-15', 'Жена'),
                ('T002', 'Иван Колев', 'ivan.kolev@example.com', '0892345678', 4, '1975-06-20', 'Мъж'),
                ('T003', 'Георги Георгиев', 'georgi.georgiev@example.com', '0872345678', 5, '1983-11-10', 'Мъж');",

            @"INSERT INTO classrooms (floor, capacity, description)
                VALUES
                (1, 30, 'Класна стая с проектор'),
                (2, 25, 'Стая с висока осветеност'),
                (3, 20, 'Малка стая за специализирани занятия');",

            @"INSERT INTO classes (class_number, class_letter, class_teacher_id, classroom_id)
                VALUES
                (11, 'б', 1, 1), 
                (11, 'в', 2, 2), 
                (11, 'г', 3, 3);",

            @"INSERT INTO students (student_code, full_name, email, phone, is_active, gender, date_of_birth, class_id)
                VALUES
                ('S001', 'Петър Петров', 'peter.petroff@example.com', '0881234567', TRUE, 'Мъж', '2005-09-10', 1),
                ('S002', 'Иван Иванов', 'ivan.ivanov@example.com', '0891234567', TRUE, 'Мъж', '2005-12-15', 1),
                ('S003', 'Мария Петрова', 'maria.petrova@example.com', '0871234567', TRUE, 'Жена', '2005-07-20', 2);",

            @"INSERT INTO teachers_subjects (teacher_id, subject_id)
                VALUES
                (1, 1),
                (2, 2),
                (3, 3);",

            @"INSERT INTO classes_subjects (class_id, subject_id)
                VALUES
                (1, 1),
                (1, 2),
                (2, 3);",

            @"INSERT INTO students_parents (student_id, parent_id)
                VALUES
                (1, 1),
                (2, 2),
                (3, 3);",
        };

        foreach (var info in seed)
        {
            using var command = new MySqlCommand(info, connection);

            var a = command.ExecuteNonQuery();
        }
    }

    /// <summary>
    /// Gets the current database connection.
    /// </summary>
    /// <returns>The MySQL connection.</returns>
    public static MySqlConnection GetConnection()
        => Connection;
}