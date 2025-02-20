namespace MySQLSchool.Common.Queries;

/// <summary>
/// Provides SQL queries for selecting data from the school database tables.
/// </summary>
public static class SelectQueries
{
    /// <summary>
    /// Selects students by class number and class letter.
    /// </summary>
    public const string SelectStudentsByClass = @"
        SELECT s.full_name 
        FROM students s 
        JOIN classes c ON s.class_id = c.id 
        WHERE c.class_number = @classNumber AND c.class_letter = @classLetter";

    /// <summary>
    /// Selects all subjects with their assigned teachers.
    /// </summary>
    public const string SelectSubjectsWithTeachers = @"
        SELECT sub.title AS subject_name, 
            GROUP_CONCAT(t.full_name SEPARATOR ', ') AS teachers 
        FROM teachers_subjects ts 
        JOIN teachers t ON ts.teacher_id = t.id 
        JOIN subjects sub ON ts.subject_id = sub.id 
        GROUP BY sub.title";

    /// <summary>
    /// Selects all classes along with their assigned class teachers.
    /// </summary>
    public const string SelectClassesWithTeachers = @"
        SELECT c.class_number, c.class_letter, t.full_name 
        FROM classes c 
        JOIN teachers t ON t.id = c.class_teacher_id";

    /// <summary>
    /// Selects the count of teachers for each subject.
    /// </summary>
    public const string SelectTeacherCountBySubject = @"
        SELECT s.title AS 'Предмет на учителя', 
            COUNT(ts.teacher_id) AS 'Броят на учителите' 
        FROM teachers t 
        JOIN teachers_subjects ts ON t.id = ts.teacher_id 
        JOIN subjects s ON ts.subject_id = s.id 
        GROUP BY s.title";

    /// <summary>
    /// Selects classrooms with a capacity greater than 26, ordered by floor.
    /// </summary>
    public const string SelectClassroomsWithCapacity = @"
        SELECT classrooms.id, classrooms.capacity 
        FROM classrooms 
        WHERE classrooms.capacity > @capacityThreshold 
        ORDER BY classrooms.floor ASC";

    /// <summary>
    /// Selects all students grouped by their class (class number + letter).
    /// </summary>
    public const string SelectStudentsGroupedByClass = @"
        SELECT CONCAT(c.class_number, c.class_letter) AS class_name, 
            GROUP_CONCAT(s.full_name SEPARATOR ', ') AS student_names 
        FROM students s 
        JOIN classes c ON s.class_id = c.id 
        GROUP BY c.class_number, c.class_letter 
        ORDER BY c.class_number ASC, c.class_letter ASC";

    /// <summary>
    /// Selects students by class number and letter using placeholders.
    /// </summary>
    public const string SelectStudentsByDynamicClass = @"
        SELECT s.full_name 
        FROM students s 
        JOIN classes c ON s.class_id = c.id 
        WHERE c.class_number = @classNumber AND c.class_letter = @classLetter";

    /// <summary>
    /// Selects students by their date of birth.
    /// </summary>
    public const string SelectStudentsByDateOfBirth = @"
        SELECT students.full_name 
        FROM students 
        WHERE students.date_of_birth = @dateOfBirth";

    /// <summary>
    /// Selects the count of subjects a student is enrolled in.
    /// </summary>
    public const string SelectSubjectCountByStudent = @"
        SELECT COUNT(sj.id) AS subject_count 
        FROM students s 
        JOIN classes c ON c.id = s.class_id 
        JOIN classes_subjects cs ON c.id = cs.class_id 
        JOIN subjects sj ON sj.id = cs.subject_id 
        WHERE s.full_name = @studentName";

    /// <summary>
    /// Selects a teacher's name and the subjects they teach for a given student.
    /// </summary>
    public const string SelectTeacherAndSubjectsByStudent = @"
        SELECT t.full_name AS 'Учител', sj.title AS 'Предмет' 
        FROM students s 
        JOIN classes c ON c.id = s.class_id 
        JOIN teachers t ON t.id = c.class_teacher_id 
        JOIN teachers_subjects ts ON ts.teacher_id = t.id 
        JOIN subjects sj ON sj.id = ts.subject_id 
        WHERE s.full_name = @studentName";

    /// <summary>
    /// Selects the class number and letter for a student based on the parent's email.
    /// </summary>
    public const string SelectClassByParentEmail = @"
        SELECT c.class_number, c.class_letter 
        FROM parents p 
        JOIN students_parents sp ON p.id = sp.parent_id 
        JOIN students s ON s.id = sp.student_id 
        JOIN classes c ON s.class_id = c.id 
        WHERE p.email = @parentEmail";
}