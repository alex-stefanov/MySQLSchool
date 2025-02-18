using COMMON = MySQLSchool.Common;
using DATA = MySQLSchool.Data;
using INTERFACES = MySQLSchool.Infrastructure.Interfaces;
using IMPLEMENTATIONS = MySQLSchool.Infrastructure.Implementation;
using LOGGERS = MySQLSchool.Logging.Loggers;
using L_INTERFACES = MySQLSchool.Logging.Interfaces;
using II_MESSAGES = MySQLSchool.Common.Messages.InitializersMessages.InfoMessages;
using IE_MESSAGES = MySQLSchool.Common.Messages.InitializersMessages.ErrorMessages;
using MI_MESSAGES = MySQLSchool.Common.Messages.MenuMessages.MainPanelMessages.InfoMessages;
using FI_MESSAGES = MySQLSchool.Common.Messages.MenuMessages.FunctionalityPanelMessages.InfoMessages;
using PI_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.GeneralInfoMessages;
using PE_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.GeneralErrorMessages;
using MySqlConnector;
using MySQLSchool.Data;

namespace MySQLSchool;

public class Program
{
    static void Main()
    {
        #region I/O Settings

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        #endregion

        DATA.DbInitializer.Initialize();

        //L_INTERFACES.ILogger logger = new LOGGERS.TextLogger("../../../log.txt");
        L_INTERFACES.ILogger logger = new LOGGERS.ExcelLogger("../../../log.xlsx");

        var isDatabaseCreated = COMMON.SchoolOptions.IsDatabaseCreated;

        if (!isDatabaseCreated)
        {
            INTERFACES.ICreateService createService = new IMPLEMENTATIONS.CreateService();

            #region Initializers

            try
            {
                logger.Log(II_MESSAGES.ParentsMessage);

                createService.CreateParents();
            }
            catch (Exception ex)
            {
                Console.WriteLine(IE_MESSAGES.ParentsMessage + ex.Message);
                logger.Log(IE_MESSAGES.ParentsMessage + ex.Message);
            }

            try
            {
                logger.Log(II_MESSAGES.SubjectsMessage);

                createService.CreateSubjects();
            }
            catch (Exception ex)
            {
                Console.WriteLine(IE_MESSAGES.SubjectsMessage + ex.Message);
                logger.Log(IE_MESSAGES.SubjectsMessage + ex.Message);
            }

            try
            {
                logger.Log(II_MESSAGES.TeachersMessage);

                createService.CreateTeachers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(IE_MESSAGES.TeachersMessage + ex.Message);
                logger.Log(IE_MESSAGES.TeachersMessage + ex.Message);
            }

            try
            {
                logger.Log(II_MESSAGES.ClassroomsMessage);
                createService.CreateClassrooms();
            }
            catch (Exception ex)
            {
                Console.WriteLine(IE_MESSAGES.ClassroomsMessage + ex.Message);
                logger.Log(IE_MESSAGES.ClassroomsMessage + ex.Message);
            }

            try
            {
                logger.Log(II_MESSAGES.ClassesMessage);

                createService.CreateClasses();
            }
            catch (Exception ex)
            {
                Console.WriteLine(IE_MESSAGES.ClassesMessage + ex.Message);
                logger.Log(IE_MESSAGES.ClassesMessage + ex.Message);
            }

            try
            {
                logger.Log(II_MESSAGES.StudentsMessage);

                createService.CreateStudents();
            }
            catch (Exception ex)
            {
                Console.WriteLine(IE_MESSAGES.StudentsMessage + ex.Message);
                logger.Log(IE_MESSAGES.StudentsMessage + ex.Message);
            }

            try
            {
                logger.Log(II_MESSAGES.TeachersSubjectsMessage);

                createService.CreateTeachersSubjects();
            }
            catch (Exception ex)
            {
                Console.WriteLine(IE_MESSAGES.TeachersSubjectsMessage + ex.Message);
                logger.Log(IE_MESSAGES.TeachersSubjectsMessage + ex.Message);
            }

            try
            {
                logger.Log(II_MESSAGES.ClassesSubjectsMessage);

                createService.CreateClassesSubjects();
            }
            catch (Exception ex)
            {
                Console.WriteLine(IE_MESSAGES.ClassesSubjectsMessage + ex.Message);
                logger.Log(IE_MESSAGES.ClassesSubjectsMessage + ex.Message);
            }

            try
            {
                logger.Log(II_MESSAGES.StudentsParentsMessage);
                createService.CreateStudentsParents();
            }
            catch (Exception ex)
            {
                Console.WriteLine(IE_MESSAGES.StudentsParentsMessage + ex.Message);
                logger.Log(IE_MESSAGES.StudentsParentsMessage + ex.Message);
            }

            #endregion
        }

        while (true)
        {
            #region Menu Panel

            Console.Clear();
            Console.WriteLine(MI_MESSAGES.HeaderMessage);
            Console.WriteLine(MI_MESSAGES.ParentsOptionMessage);
            Console.WriteLine(MI_MESSAGES.SubjectsOptionMessage);
            Console.WriteLine(MI_MESSAGES.TeachersOptionMessage);
            Console.WriteLine(MI_MESSAGES.ClassroomsOptionMessage);
            Console.WriteLine(MI_MESSAGES.ClassesOptionMessage);
            Console.WriteLine(MI_MESSAGES.StudentsOptionMessage);
            Console.WriteLine(MI_MESSAGES.TeachersSubjectsOptionMessage);
            Console.WriteLine(MI_MESSAGES.ClassesSubjectsOptionMessage);
            Console.WriteLine(MI_MESSAGES.StudentsParentsOptionMessage);
            Console.WriteLine(MI_MESSAGES.FunctionalitiesOptionMessage);
            Console.WriteLine(MI_MESSAGES.ExitOptionMessage);

            #endregion

            var choice = Console.ReadLine();

            if (string.IsNullOrEmpty(choice))
            {
                return;
            }

            INTERFACES.IPopulateService populateService = new IMPLEMENTATIONS.PopulateService();

            switch (choice)
            {
                case "1":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.ParentsMessage);

                            populateService.PopulateParents(logger);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.ParentsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.ParentsMessage + ex.Message);
                        }
                        break;
                    }
                case "2":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.SubjectsMessage);

                            populateService.PopulateSubjects(logger);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.SubjectsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.SubjectsMessage + ex.Message);
                        }
                        break;
                    }
                case "3":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.TeachersMessage);

                            populateService.PopulateTeachers(logger);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.TeachersMessage + ex.Message);
                            logger.Log(PE_MESSAGES.TeachersMessage + ex.Message);
                        }
                        break;
                    }
                case "4":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.ClassroomsMessage);

                            populateService.PopulateClassrooms(logger);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.ClassroomsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.ClassroomsMessage + ex.Message);
                        }
                        break;
                    }
                case "5":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.ClassesMessage);

                            populateService.PopulateClasses(logger);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.ClassesMessage + ex.Message);
                            logger.Log(PE_MESSAGES.ClassesMessage + ex.Message);
                        }
                        break;
                    }
                case "6":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.StudentsMessage);

                            populateService.PopulateStudents(logger);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.StudentsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.StudentsMessage + ex.Message);
                        }
                        break;
                    }
                case "7":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.TeachersSubjectsMessage);

                            populateService.PopulateTeachersSubjects(logger);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.TeachersSubjectsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.TeachersSubjectsMessage + ex.Message);
                        }
                        break;
                    }
                case "8":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.ClassesSubjectsMessage);

                            populateService.PopulateClassesSubjects(logger);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.ClassesSubjectsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.ClassesSubjectsMessage + ex.Message);
                        }
                        break;
                    }
                case "9":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.StudentsParentsMessage);

                            populateService.PopulateStudentsParents(logger);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.StudentsParentsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.StudentsParentsMessage + ex.Message);
                        }
                        break;
                    }
                case "10":
                    {
                        while (true)
                        {
                            #region Menu Panel

                            Console.Clear();
                            Console.WriteLine("Изведи:");
                            Console.WriteLine("1. Имената на всички ученици от 11б");
                            Console.WriteLine("2. Имената на всички учители и предмета, по който преподава, групирани по предмети");
                            Console.WriteLine("3. Всички класове на даден учител по идентификатора му");
                            Console.WriteLine("4. Всички учебни предмети и броят на преподаващите учители");
                            Console.WriteLine("5. Идентификатора и капацитета на класните стаи с капацитет повече от 26, подредени във възходящ ред по етажи");
                            Console.WriteLine("6. Имената и класът на всички ученици групирани по класове във възходящ ред на класовете");
                            Console.WriteLine("7. Имената на ученици от избран клас и паралелка");
                            Console.WriteLine("8. Имената на всички ученици родени на специфична дата");
                            Console.WriteLine("9. Броят на предметите на съответен ученик по името му");
                            Console.WriteLine("10. Имената на всички учители и предметите, по които преподават на съответен ученик по името му");
                            Console.WriteLine("11. Класовете, в които учат децата на специфичен родител по негов имейл");
                            Console.WriteLine("0. Изход");

                            #endregion

                            string? functionalityChoice = Console.ReadLine();

                            if (string.IsNullOrEmpty(functionalityChoice))
                            {
                                return;
                            }

                            var mySqlConnection = DbInitializer.GetConnection();

                            switch (functionalityChoice)
                            {
                                case "1":
                                    {
                                        try
                                        {
                                            logger.Log(PI_MESSAGES.StudentsParentsMessage);

                                            populateService.PopulateStudentsParents(logger);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(PE_MESSAGES.StudentsParentsMessage + ex.Message);
                                            logger.Log(PE_MESSAGES.StudentsParentsMessage + ex.Message);
                                        }
                                        break;

                                        GetStudentsNames(mySqlConnection);
                                        break;
                                    }
                                case "2":
                                    {
                                        GetTeachersNamesAndSubject(mySqlConnection);
                                        break;
                                    }
                                case "3":
                                    {
                                        GetClassesAndTeacher(mySqlConnection);
                                        break;
                                    }
                                case "4":
                                    {
                                        GetSubjectsWithTeacherCount(mySqlConnection);
                                        break;
                                    }
                                case "5":
                                    {
                                        GetClassroomsOrderedByFloor(mySqlConnection);
                                        break;
                                    }
                                case "6":
                                    {
                                        GetStudentsByClasses(mySqlConnection);
                                        break;
                                    }
                                case "7":
                                    {
                                        GetAllStudentsByClass(mySqlConnection);
                                        break;
                                    }
                                case "8":
                                    {
                                        GetStudentsWithSpecificBirthday(mySqlConnection);
                                        break;
                                    }
                                case "9":
                                    {
                                        GetCountOfSubjectsByStudent(mySqlConnection);
                                        break;
                                    }
                                case "10":
                                    {
                                        GetTeachersAndSubjectsByStudent(mySqlConnection);
                                        break;
                                    }
                                case "11":
                                    {
                                        GetClassByParentEmail(mySqlConnection);
                                        break;
                                    }
                                case "0":
                                    {
                                        Console.WriteLine(FI_MESSAGES.BackMessage);
                                        logger.Log(FI_MESSAGES.BackMessage);

                                        return;
                                    }
                                default:
                                    {
                                        Console.WriteLine(FI_MESSAGES.InvаlidInputMessage);
                                        logger.Log(FI_MESSAGES.InvаlidInputMessage);
                                        break;
                                    }
                            }
                        }
                    }
                case "0":
                    {
                        Console.WriteLine(MI_MESSAGES.ByeMessage);
                        logger.Log(MI_MESSAGES.ByeMessage);

                        return;
                    }
                default:
                    {
                        Console.WriteLine(MI_MESSAGES.InvаlidInputMessage);
                        logger.Log(MI_MESSAGES.InvаlidInputMessage);

                        break;
                    }
            }

            logger.SaveLog();
        }
    }

    private static void DefaultSeed(
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

    static void GetStudentsNames(
        MySqlConnection connection)
    {
        using MySqlCommand command = new("SELECT s.full_name FROM students s JOIN classes c ON s.class_id = c.id WHERE c.class_number = 11 AND c.class_letter = 'б'",
            connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]}");
        }

        Console.ReadLine();
    }

    static void GetTeachersNamesAndSubject(
        MySqlConnection connection)
    {
        using MySqlCommand command = new("SELECT sub.title AS subject_name, GROUP_CONCAT(t.full_name SEPARATOR ', ') AS teachers FROM teachers_subjects ts JOIN teachers t ON ts.teacher_id = t.id JOIN subjects sub ON ts.subject_id = sub.id GROUP BY sub.title",
           connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        Console.ReadLine();
    }

    static void GetClassesAndTeacher(
        MySqlConnection connection)
    {
        using MySqlCommand command = new("SELECT c.class_number, c.class_letter, t.full_name FROM classes c JOIN teachers t ON t.id = c.class_teacher_id",
            connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]}{sqlDataReader[1]} - {sqlDataReader[2]}");
        }

        Console.ReadLine();
    }

    static void GetSubjectsWithTeacherCount(
        MySqlConnection connection)
    {
        using MySqlCommand command = new("SELECT s.title AS 'Предмет на учителя', COUNT(ts.teacher_id) AS 'Броят на учителите' FROM teachers t JOIN teachers_subjects ts ON t.id = ts.teacher_id JOIN subjects s ON ts.subject_id = s.id GROUP BY s.title",
            connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        Console.ReadLine();
    }

    static void GetClassroomsOrderedByFloor(
        MySqlConnection connection)
    {
        using MySqlCommand command = new("SELECT classrooms.id, classrooms.capacity FROM classrooms WHERE classrooms.capacity > 26 ORDER BY classrooms.floor ASC",
             connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        Console.ReadLine();
    }

    static void GetStudentsByClasses(
        MySqlConnection connection)
    {
        using MySqlCommand command = new("SELECT CONCAT(c.class_number, c.class_letter) AS class_name, GROUP_CONCAT(s.full_name SEPARATOR ', ') AS student_names FROM students s JOIN classes c ON s.class_id = c.id GROUP BY c.class_number, c.class_letter ORDER BY c.class_number ASC, c.class_letter ASC; ",
            connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
        }

        Console.ReadLine();
    }

    static void GetAllStudentsByClass(
        MySqlConnection connection)
    {
        Console.Write("Въведи клас: ");
        int classNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Въведи буква на класа: ");
        char classLetter = char.Parse(Console.ReadLine());

        using MySqlCommand command = new($"SELECT s.full_name FROM students s JOIN classes c ON s.class_id = c.id WHERE c.class_number = {classNumber} AND c.class_letter = '{classLetter}'",
                connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]}");
        }

        Console.ReadLine();
    }

    static void GetStudentsWithSpecificBirthday(
        MySqlConnection connection)
    {
        Console.Write("Въведи рожден ден(yyyy-MM-dd): ");
        string dateOfBirth = Console.ReadLine();

        using MySqlCommand command = new($"SELECT students.full_name FROM students WHERE students.date_of_birth = '{dateOfBirth}'",
                connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]}");
        }

        Console.ReadLine();
    }

    static void GetCountOfSubjectsByStudent(
        MySqlConnection connection)
    {
        Console.Write("Въведи име на ученик: ");
        string studentName = Console.ReadLine();

        using MySqlCommand command = new($"SELECT COUNT(sj.id) AS subject_count FROM students s JOIN classes c ON c.id = s.class_id JOIN classes_subjects cs ON c.id = cs.class_id JOIN subjects sj ON sj.id = cs.subject_id WHERE s.full_name = '{studentName}';",
                connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]}");
        }

        Console.ReadLine();
    }

    static void GetTeachersAndSubjectsByStudent(
        MySqlConnection connection)
    {
        Console.Write("Въведи име на ученик: ");
        string studentName = Console.ReadLine();

        using MySqlCommand command = new($"SELECT t.full_name AS 'Учител', sj.title AS 'Предмет' FROM students s JOIN classes c ON c.id = s.id JOIN teachers t ON t.id = c.class_teacher_id JOIN teachers_subjects ts ON ts.teacher_id = t.id JOIN subjects sj ON sj.id = ts.subject_id WHERE s.full_name = '{studentName}'",
            connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]}");
        }

        Console.ReadLine();
    }

    static void GetClassByParentEmail(
        MySqlConnection connection)
    {
        Console.Write("Въведи имейл на родител: ");
        string parentEmail = Console.ReadLine();

        using MySqlCommand command = new($"SELECT c.class_number, c.class_letter FROM parents p JOIN students_parents sp ON p.id = sp.parent_id JOIN students s ON s.id = sp.student_id JOIN classes c ON s.class_id = c.id WHERE p.email = '{parentEmail}'",
            connection);

        using MySqlDataReader sqlDataReader = command.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader[0]}{sqlDataReader[1]}");
        }

        Console.ReadLine();
    }
}