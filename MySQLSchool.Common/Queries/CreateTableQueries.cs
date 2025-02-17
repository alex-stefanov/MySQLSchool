namespace MySQLSchool.Common.Queries;

public static class CreateTableQueries
{
    public const string CreateParentsQuery =
        @"CREATE TABLE parents (
            id INT PRIMARY KEY AUTO_INCREMENT,
            parent_code NVARCHAR(50) NOT NULL,
            full_name NVARCHAR(100) NOT NULL,
            phone NVARCHAR(20) NOT NULL,
            email NVARCHAR(100) NOT NULL
        );";

    public const string CreateSubjects =
        @"CREATE TABLE subjects (
            id INT PRIMARY KEY AUTO_INCREMENT,
            title NVARCHAR(100) NOT NULL,
            level NVARCHAR(50) NOT NULL
        );";

    public const string CreateTeachers =
        @"CREATE TABLE teachers (
            id INT PRIMARY KEY AUTO_INCREMENT,
            teacher_code NVARCHAR(50) NOT NULL,
            full_name NVARCHAR(100) NOT NULL,
            email NVARCHAR(100) NOT NULL,
            phone NVARCHAR(20) NOT NULL,
            working_days INT NOT NULL,
            date_of_birth DATE,
            gender NVARCHAR(10)
        );";

    public const string CreateClassrooms =
        @"CREATE TABLE classrooms (
            id INT PRIMARY KEY AUTO_INCREMENT,
            floor INT NOT NULL,
            capacity INT NOT NULL,
            description NVARCHAR(255) NOT NULL
        );";

    public const string CreateClasses =
        @"CREATE TABLE classes (
            id INT PRIMARY KEY AUTO_INCREMENT,
            class_number INT NOT NULL,
            class_letter CHAR(1) NOT NULL,
            class_teacher_id INT NOT NULL,
            classroom_id INT NOT NULL,
            FOREIGN KEY (class_teacher_id) REFERENCES teachers(id),
            FOREIGN KEY (classroom_id) REFERENCES classrooms(id)
        );";

    public const string CreateStudents =
        @"CREATE TABLE students (
            id INT PRIMARY KEY AUTO_INCREMENT,
            student_code NVARCHAR(50) NOT NULL,
            full_name NVARCHAR(100) NOT NULL,
            email NVARCHAR(100) NOT NULL,
            phone NVARCHAR(20) NOT NULL,
            is_active BOOLEAN NOT NULL,
            gender NVARCHAR(10),
            date_of_birth DATE,
            class_id INT NOT NULL,
            FOREIGN KEY (class_id) REFERENCES classes(id)
        );";

    public const string CreateTeachersSubjects =
        @"CREATE TABLE teachers_subjects (
            teacher_id INT NOT NULL,
            subject_id INT NOT NULL,
            PRIMARY KEY (teacher_id, subject_id),
            FOREIGN KEY (teacher_id) REFERENCES teachers(id),
            FOREIGN KEY (subject_id) REFERENCES subjects(id)
        );";

    public const string CreateClassesSubjects =
        @"CREATE TABLE classes_subjects (
            classe_id INT NOT NULL,
            subject_id INT NOT NULL,
            PRIMARY KEY (classe_id, subject_id),
            FOREIGN KEY (classe_id) REFERENCES classes(id),
            FOREIGN KEY (subject_id) REFERENCES subjects(id)
        );";

    public const string CreateStudentsParents =
        @"CREATE TABLE students_parents (
            student_id INT NOT NULL,
            parent_id INT NOT NULL,
            PRIMARY KEY (student_id, parent_id),
            FOREIGN KEY (student_id) REFERENCES students(id),
            FOREIGN KEY (parent_id) REFERENCES parents(id)
        );";
}