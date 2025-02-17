namespace MySQLSchool.Common.Queries;

public static class InsertTableQueries
{
    public const string InsertParentsQuery =
        @"INSERT INTO parents (parent_code, full_name, phone, email) 
          VALUES (@parentCode, @fullName, @phone, @email)";

    public const string InsertSubjects =
        @"INSERT INTO subjects (title, level) 
          VALUES (@title, @level)";

    public const string InsertTeachers =
        @"INSERT INTO teachers (teacher_code, full_name, email, phone, working_days, date_of_birth, gender)
          VALUES (@teacherCode, @fullName, @email, @phone, @workingDays, @dateOfBirth, @gender)";

    public const string InsertClassrooms =
        @"INSERT INTO classrooms (floor, capacity, description) 
          VALUES (@floor, @capacity, @description)";

    public const string InsertClasses =
        @"INSERT INTO classes (class_number, class_letter, class_teacher_id, classroom_id)
          VALUES (@classNumber, @classLetter, @classTeacherId, @classroomId)";

    public const string InsertStudents =
        @"INSERT INTO students (student_code, full_name, email, phone, gender, date_of_birth, class_id, is_active)
          VALUES (@studentCode, @fullName, @email, @phone, @gender, @dateOfBirth, @classId, @isActive)";

    public const string InsertTeachersSubjects =
        @"INSERT INTO teachers_subjects (teacher_id, subject_id) 
          VALUES (@teacherId, @subjectId)";

    public const string InsertClassesSubjects =
        @"INSERT INTO classes_subjects (classe_id, subject_id) 
          VALUES (@classId, @subjectId)";

    public const string InsertStudentsParents =
        @"INSERT INTO students_parents (student_id, parent_id) 
          VALUES (@studentId, @parentId)";
}