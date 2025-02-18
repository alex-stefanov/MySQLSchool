namespace MySQLSchool.Common.Queries;

/// <summary>
/// Provides SQL queries for inserting data into the school database tables.
/// </summary>
public static class InsertTableQueries
{
    /// <summary>
    /// SQL query to insert a new parent into the <c>parents</c> table.
    /// </summary>
    public const string InsertParentsQuery =
        @"INSERT INTO parents (parent_code, full_name, phone, email) 
          VALUES (@parentCode, @fullName, @phone, @email)";

    /// <summary>
    /// SQL query to insert a new subject into the <c>subjects</c> table.
    /// </summary>
    public const string InsertSubjects =
        @"INSERT INTO subjects (title, level) 
          VALUES (@title, @level)";

    /// <summary>
    /// SQL query to insert a new teacher into the <c>teachers</c> table.
    /// </summary>
    public const string InsertTeachers =
        @"INSERT INTO teachers (teacher_code, full_name, email, phone, working_days, date_of_birth, gender)
          VALUES (@teacherCode, @fullName, @email, @phone, @workingDays, @dateOfBirth, @gender)";

    /// <summary>
    /// SQL query to insert a new classroom into the <c>classrooms</c> table.
    /// </summary>
    public const string InsertClassrooms =
        @"INSERT INTO classrooms (floor, capacity, description) 
          VALUES (@floor, @capacity, @description)";

    /// <summary>
    /// SQL query to insert a new class into the <c>classes</c> table.
    /// </summary>
    public const string InsertClasses =
        @"INSERT INTO classes (class_number, class_letter, class_teacher_id, classroom_id)
          VALUES (@classNumber, @classLetter, @classTeacherId, @classroomId)";

    /// <summary>
    /// SQL query to insert a new student into the <c>students</c> table.
    /// </summary>
    public const string InsertStudents =
        @"INSERT INTO students (student_code, full_name, email, phone, gender, date_of_birth, class_id, is_active)
          VALUES (@studentCode, @fullName, @email, @phone, @gender, @dateOfBirth, @classId, @isActive)";

    /// <summary>
    /// SQL query to assign a subject to a teacher in the <c>teachers_subjects</c> table.
    /// </summary>
    public const string InsertTeachersSubjects =
        @"INSERT INTO teachers_subjects (teacher_id, subject_id) 
          VALUES (@teacherId, @subjectId)";

    /// <summary>
    /// SQL query to assign a subject to a class in the <c>classes_subjects</c> table.
    /// </summary>
    public const string InsertClassesSubjects =
        @"INSERT INTO classes_subjects (class_id, subject_id) 
          VALUES (@classId, @subjectId)";

    /// <summary>
    /// SQL query to associate a student with a parent in the <c>students_parents</c> table.
    /// </summary>
    public const string InsertStudentsParents =
        @"INSERT INTO students_parents (student_id, parent_id) 
          VALUES (@studentId, @parentId)";
}