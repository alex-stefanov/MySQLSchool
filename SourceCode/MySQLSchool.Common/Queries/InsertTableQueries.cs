namespace MySQLSchool.Common.Queries;

/// <summary>
/// Provides SQL queries for inserting data into the school database tables.
/// </summary>
public static class InsertTableQueries
{
    /// <summary>
    /// SQL query to insert a new parent into the <c>parents</c> table.
    /// </summary>
    public const string InsertParents = @"
        INSERT INTO parents (parent_code, full_name, phone, email) 
        VALUES (@parentCode, @fullName, @phone, @email)";

    /// <summary>
    /// SQL query to insert a new subject into the <c>subjects</c> table.
    /// </summary>
    public const string InsertSubjects = @"
        INSERT INTO subjects (title, level) 
        VALUES (@title, @level)";

    /// <summary>
    /// SQL query to insert a new teacher into the <c>teachers</c> table.
    /// </summary>
    public const string InsertTeachers = @"
        INSERT INTO teachers (teacher_code, full_name, email, phone, working_days, date_of_birth, gender)
        VALUES (@teacherCode, @fullName, @email, @phone, @workingDays, @dateOfBirth, @gender)";

    /// <summary>
    /// SQL query to insert a new classroom into the <c>classrooms</c> table.
    /// </summary>
    public const string InsertClassrooms = @"
        INSERT INTO classrooms (floor, capacity, description) 
        VALUES (@floor, @capacity, @description)";

    /// <summary>
    /// SQL query to insert a new class into the <c>classes</c> table.
    /// </summary>
    public const string InsertClasses = @"
        INSERT INTO classes (class_number, class_letter, class_teacher_id, classroom_id)
        VALUES (@classNumber, @classLetter, @classTeacherId, @classroomId)";

    /// <summary>
    /// SQL query to insert a new student into the <c>students</c> table.
    /// </summary>
    public const string InsertStudents = @"
        INSERT INTO students (student_code, full_name, email, phone, gender, date_of_birth, class_id, is_active)
        VALUES (@studentCode, @fullName, @email, @phone, @gender, @dateOfBirth, @classId, @isActive)";

    /// <summary>
    /// SQL query to assign a subject to a teacher in the <c>teachers_subjects</c> table.
    /// </summary>
    public const string InsertTeachersSubjects = @"
        INSERT INTO teachers_subjects (teacher_id, subject_id) 
        VALUES (@teacherId, @subjectId)";

    /// <summary>
    /// SQL query to assign a subject to a class in the <c>classes_subjects</c> table.
    /// </summary>
    public const string InsertClassesSubjects = @"
        INSERT INTO classes_subjects (class_id, subject_id) 
        VALUES (@classId, @subjectId)";

    /// <summary>
    /// SQL query to associate a student with a parent in the <c>students_parents</c> table.
    /// </summary>
    public const string InsertStudentsParents = @"
        INSERT INTO students_parents (student_id, parent_id) 
        VALUES (@studentId, @parentId)";

    /// <summary>
    /// SQL query to insert default parents into the <c>parents</c> table.
    /// </summary>
    public const string InsertDefaultParents = @"
        INSERT INTO parents (parent_code, full_name, phone, email)
        VALUES 
        ('P001', 'Мария Иванова', '0888123456', 'maria.ivanova@example.com'),
        ('P002', 'Георги Петров', '0877123456', 'georgi.petroff@example.com'),
        ('P003', 'Иван Димитров', '0899123456', 'ivan.dimitrov@example.com');";

    /// <summary>
    /// SQL query to insert default subjects into the <c>subjects</c> table.
    /// </summary>
    public const string InsertDefaultSubjects = @"
        INSERT INTO subjects (title, level)
        VALUES 
        ('Математика', 'Основно'),
        ('Български език', 'Основно'),
        ('Физика', 'Средно'),
        ('История', 'Основно');";

    /// <summary>
    /// SQL query to insert default teachers into the <c>teachers</c> table.
    /// </summary>
    public const string InsertDefaultTeachers = @"
        INSERT INTO teachers (teacher_code, full_name, email, phone, working_days, date_of_birth, gender)
        VALUES
        ('T001', 'Мария Петрова', 'maria.petrova@example.com', '0882345678', 5, '1980-02-15', 'Жена'),
        ('T002', 'Иван Колев', 'ivan.kolev@example.com', '0892345678', 4, '1975-06-20', 'Мъж'),
        ('T003', 'Георги Георгиев', 'georgi.georgiev@example.com', '0872345678', 5, '1983-11-10', 'Мъж');";

    /// <summary>
    /// SQL query to insert default classrooms into the <c>classrooms</c> table.
    /// </summary>
    public const string InsertDefaultClassrooms = @"
        INSERT INTO classrooms (floor, capacity, description)
        VALUES
        (1, 30, 'Класна стая с проектор'),
        (2, 25, 'Стая с висока осветеност'),
        (3, 20, 'Малка стая за специализирани занятия');";

    /// <summary>
    /// SQL query to insert default classes into the <c>classes</c> table.
    /// </summary>
    public const string InsertDefaultClasses = @"
        INSERT INTO classes (class_number, class_letter, class_teacher_id, classroom_id)
        VALUES
        (11, 'б', 1, 1), 
        (11, 'в', 2, 2), 
        (11, 'г', 3, 3);";

    /// <summary>
    /// SQL query to insert default students into the <c>students</c> table.
    /// </summary>
    public const string InsertDefaultStudents = @"
        INSERT INTO students (student_code, full_name, email, phone, is_active, gender, date_of_birth, class_id)
        VALUES
        ('S001', 'Петър Петров', 'peter.petroff@example.com', '0881234567', TRUE, 'Мъж', '2005-09-10', 1),
        ('S002', 'Иван Иванов', 'ivan.ivanov@example.com', '0891234567', TRUE, 'Мъж', '2005-12-15', 1),
        ('S003', 'Мария Петрова', 'maria.petrova@example.com', '0871234567', TRUE, 'Жена', '2005-07-20', 2);";

    /// <summary>
    /// SQL query to assign default subjects to teachers in the <c>teachers_subjects</c> table.
    /// </summary>
    public const string InsertDefaultTeachersSubjects = @"
        INSERT INTO teachers_subjects (teacher_id, subject_id)
        VALUES
        (1, 1),
        (2, 2),
        (3, 3);";

    /// <summary>
    /// SQL query to assign default subjects to classes in the <c>classes_subjects</c> table.
    /// </summary>
    public const string InsertDefaultClassesSubjects = @"
        INSERT INTO classes_subjects (class_id, subject_id)
        VALUES
        (1, 1),
        (1, 2),
        (2, 3);";

    /// <summary>
    /// SQL query to associate default students with parents in the <c>students_parents</c> table.
    /// </summary>
    public const string InsertDefaultStudentsParents = @"
        INSERT INTO students_parents (student_id, parent_id)
        VALUES
        (1, 1),
        (2, 2),
        (3, 3);";
}