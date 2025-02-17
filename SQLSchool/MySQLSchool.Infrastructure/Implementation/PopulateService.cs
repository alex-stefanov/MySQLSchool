using MySqlConnector;
using DATA = MySQLSchool.Data;
using INTERFACES = MySQLSchool.Infrastructure.Interfaces;
using L_INTERFACES = MySQLSchool.Logging.Interfaces;
using P_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.ParentsMessages;
using SJ_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.SubjectsMessages;
using T_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.TeachersMessages;
using CR_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.ClassroomsMessages;
using C_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.ClassesMessages;
using S_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.StudentsMessages;
using TSJ_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.TeachersSubjectsMessages;
using CSJ_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.ClassesSubjectsMessages;
using SP_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.StudentsParentsMessages;
using IT_QUERIES = MySQLSchool.Common.Queries.InsertTableQueries;

namespace MySQLSchool.Infrastructure.Implementation;

public class PopulateService
    : INTERFACES.IPopulateService
{
    private static readonly MySqlConnection Connection 
        = DATA.DbInitializer.GetConnection();

    public void PopulateParents(
        L_INTERFACES.ILogger logger)
    {
        Console.Clear();

        Console.WriteLine(P_MESSAGES.StartMessage);
        logger.Log(P_MESSAGES.StartMessage);

        string? parentCode;
        string? fullName;
        string? phone;
        string? email;

        do
        {
            Console.Write(P_MESSAGES.CodeInfoMessage);
            parentCode = Console.ReadLine();
            
            logger.Log(P_MESSAGES.CodeInfoMessage + parentCode);

            if (!string.IsNullOrWhiteSpace(parentCode)) continue;
            
            Console.Write(P_MESSAGES.CodeErrorMessage);
            logger.Log(P_MESSAGES.CodeErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(parentCode));

        do
        {
            Console.Write(P_MESSAGES.FullNameInfoMessage);
            fullName = Console.ReadLine();
            
            logger.Log(P_MESSAGES.FullNameInfoMessage + fullName);

            if (!string.IsNullOrWhiteSpace(fullName)) continue;
            
            Console.WriteLine(P_MESSAGES.FullNameErrorMessage);
            logger.Log(P_MESSAGES.FullNameErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(fullName));

        do
        {
            Console.Write(P_MESSAGES.PhoneInfoMessage);
            phone = Console.ReadLine();
            
            logger.Log(P_MESSAGES.PhoneInfoMessage + phone);

            if (!string.IsNullOrWhiteSpace(phone)) continue;
            
            Console.WriteLine(P_MESSAGES.PhoneErrorMessage);
            logger.Log(P_MESSAGES.PhoneErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(phone));

        do
        {
            Console.Write(P_MESSAGES.EmailInfoMessage);
            email = Console.ReadLine();
            
            logger.Log(P_MESSAGES.EmailInfoMessage + email);

            if (!string.IsNullOrWhiteSpace(email)) continue;
            
            Console.WriteLine(P_MESSAGES.EmailErrorMessage);
            logger.Log(P_MESSAGES.EmailErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(email));

        using var command = new MySqlCommand(IT_QUERIES.InsertParentsQuery, Connection);

        command.Parameters.AddWithValue("@parentCode", parentCode);
        command.Parameters.AddWithValue("@fullName", fullName);
        command.Parameters.AddWithValue("@phone", phone);
        command.Parameters.AddWithValue("@email", email);

        command.ExecuteNonQuery();

        Console.WriteLine(P_MESSAGES.EndMessage);
        logger.Log(P_MESSAGES.EndMessage);
        
        Console.ReadLine();
    }

    public void PopulateSubjects(
        L_INTERFACES.ILogger logger)
    {
        Console.Clear();
        
        Console.WriteLine(SJ_MESSAGES.StartMessage);
        logger.Log(SJ_MESSAGES.StartMessage);

        string? title;
        string? level;

        do
        {
            Console.Write(SJ_MESSAGES.TitleInfoMessage);
            title = Console.ReadLine();
            
            logger.Log(SJ_MESSAGES.TitleInfoMessage + title);

            if (!string.IsNullOrWhiteSpace(title)) continue;
            
            Console.WriteLine(SJ_MESSAGES.TitleErrorMessage);
            logger.Log(SJ_MESSAGES.TitleErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(title));

        do
        {
            Console.Write(SJ_MESSAGES.LevelInfoMessage);
            level = Console.ReadLine();
            
            logger.Log(SJ_MESSAGES.LevelInfoMessage + level);

            if (!string.IsNullOrWhiteSpace(level)) continue;
            
            Console.WriteLine(SJ_MESSAGES.LevelErrorMessage);
            logger.Log(SJ_MESSAGES.LevelErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(level));

        using var command = new MySqlCommand(IT_QUERIES.InsertSubjects, Connection);

        command.Parameters.AddWithValue("@title", title);
        command.Parameters.AddWithValue("@level", level);

        command.ExecuteNonQuery();

        Console.WriteLine(SJ_MESSAGES.EndMessage);
        logger.Log(SJ_MESSAGES.EndMessage);
        
        Console.ReadLine();
    }

    public void PopulateTeachers(
        L_INTERFACES.ILogger logger)
    {
        Console.Clear();
        
        Console.WriteLine(T_MESSAGES.StartMessage);
        logger.Log(T_MESSAGES.StartMessage);

        string? teacherCode;
        string? fullName;
        string? email;
        string? phone;
        string? workingDaysAsString;
        string? dateOfBirth;
        string? gender;

        int workingDays;

        do
        {
            Console.Write(T_MESSAGES.CodeInfoMessage);
            teacherCode = Console.ReadLine();
            
            logger.Log(T_MESSAGES.CodeInfoMessage + teacherCode);

            if (!string.IsNullOrWhiteSpace(teacherCode)) continue;
            
            Console.WriteLine(T_MESSAGES.CodeErrorMessage);
            logger.Log(T_MESSAGES.CodeErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(teacherCode));

        do
        {
            Console.Write(T_MESSAGES.FullNameInfoMessage);
            fullName = Console.ReadLine();
            
            logger.Log(T_MESSAGES.FullNameInfoMessage + fullName);

            if (!string.IsNullOrWhiteSpace(fullName)) continue;
            
            Console.WriteLine(T_MESSAGES.FullNameErrorMessage);
            logger.Log(T_MESSAGES.FullNameErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(fullName));

        do
        {
            Console.Write(T_MESSAGES.EmailInfoMessage);
            email = Console.ReadLine();
            
            logger.Log(T_MESSAGES.EmailInfoMessage + email);

            if (!string.IsNullOrWhiteSpace(email)) continue;
            
            Console.WriteLine(T_MESSAGES.EmailErrorMessage);
            logger.Log(T_MESSAGES.EmailErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(email));

        do
        {
            Console.Write(T_MESSAGES.PhoneInfoMessage);
            phone = Console.ReadLine();
            
            logger.Log(T_MESSAGES.PhoneInfoMessage + phone);

            if (!string.IsNullOrWhiteSpace(phone)) continue;
            
            Console.WriteLine(T_MESSAGES.PhoneErrorMessage);
            logger.Log(T_MESSAGES.PhoneErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(phone));

        do
        {
            Console.Write(T_MESSAGES.WorkingDaysInfoMessage);
            workingDaysAsString = Console.ReadLine();
            
            logger.Log(T_MESSAGES.WorkingDaysInfoMessage + workingDaysAsString);

            if (!string.IsNullOrWhiteSpace(workingDaysAsString)) continue;
            
            Console.WriteLine(T_MESSAGES.WorkingDaysErrorMessage);
            logger.Log(T_MESSAGES.WorkingDaysErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(workingDaysAsString));

        workingDays = int.Parse(workingDaysAsString);

        Console.Write(T_MESSAGES.DateOfBirthInfoMessage);
        dateOfBirth = Console.ReadLine();
        
        logger.Log(T_MESSAGES.DateOfBirthInfoMessage + dateOfBirth);

        Console.Write(T_MESSAGES.GenderInfoMessage);
        gender = Console.ReadLine();
        
        logger.Log(T_MESSAGES.GenderInfoMessage + gender);

        using var command = new MySqlCommand(IT_QUERIES.InsertTeachers, Connection);

        command.Parameters.AddWithValue("@teacherCode", teacherCode);
        command.Parameters.AddWithValue("@fullName", fullName);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@phone", phone);
        command.Parameters.AddWithValue("@workingDays", workingDays);
        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
        command.Parameters.AddWithValue("@gender", gender);

        command.ExecuteNonQuery();

        Console.WriteLine(T_MESSAGES.EndMessage);
        logger.Log(T_MESSAGES.EndMessage);
        
        Console.ReadLine();
    }

    public void PopulateClassrooms(
        L_INTERFACES.ILogger logger)
    {
        Console.Clear();
        
        Console.WriteLine(CR_MESSAGES.StartMessage);
        logger.Log(T_MESSAGES.StartMessage);

        string? floorAsString;
        string? capacityAsString;
        string? description;

        int floor;
        int capacity;

        do
        {
            Console.Write(CR_MESSAGES.FloorInfoMessage);
            floorAsString = Console.ReadLine();
            
            logger.Log(CR_MESSAGES.FloorInfoMessage + floorAsString);

            if (!string.IsNullOrWhiteSpace(floorAsString)) continue;
            
            Console.WriteLine(CR_MESSAGES.FloorErrorMessage);
            logger.Log(CR_MESSAGES.FloorErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(floorAsString));

        floor = int.Parse(floorAsString);

        do
        {
            Console.Write(CR_MESSAGES.CapacityInfoMessage);
            capacityAsString = Console.ReadLine();
            
            logger.Log(CR_MESSAGES.CapacityInfoMessage + capacityAsString);

            if (!string.IsNullOrWhiteSpace(capacityAsString)) continue;
            
            Console.WriteLine(CR_MESSAGES.CapacityErrorMessage);
            logger.Log(CR_MESSAGES.CapacityErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(capacityAsString));

        capacity = int.Parse(capacityAsString);

        do
        {
            Console.Write(CR_MESSAGES.DescriptionInfoMessage);
            description = Console.ReadLine();
            
            logger.Log(CR_MESSAGES.DescriptionInfoMessage + description);

            if (!string.IsNullOrWhiteSpace(description)) continue;
            
            Console.WriteLine(CR_MESSAGES.DescriptionErrorMessage);
            logger.Log(CR_MESSAGES.DescriptionErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(description));

        using var command = new MySqlCommand(IT_QUERIES.InsertClassrooms, Connection);

        command.Parameters.AddWithValue("@floor", floor);
        command.Parameters.AddWithValue("@capacity", capacity);
        command.Parameters.AddWithValue("@description", description);

        command.ExecuteNonQuery();

        Console.WriteLine(CR_MESSAGES.EndMessage);
        logger.Log(T_MESSAGES.EndMessage);
        
        Console.ReadLine();
    }

    public void PopulateClasses(
        L_INTERFACES.ILogger logger)
    {
        Console.Clear();
        
        Console.WriteLine(C_MESSAGES.StartMessage);
        logger.Log(T_MESSAGES.StartMessage);

        string? classNumberAsString;
        string? classLetterAsString;
        string? classTeacherIdAsString;
        string? classroomIdAsString;

        int classNumber;
        char classLetter;
        int classTeacherId;
        int classroomId;

        do
        {
            Console.Write(C_MESSAGES.NumberInfoMessage);
            classNumberAsString = Console.ReadLine();
            
            logger.Log(C_MESSAGES.NumberInfoMessage + classNumberAsString);

            if (!string.IsNullOrWhiteSpace(classNumberAsString)) continue;
            
            Console.WriteLine(C_MESSAGES.NumberErrorMessage);
            logger.Log(C_MESSAGES.NumberErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(classNumberAsString));

        classNumber = int.Parse(classNumberAsString);

        do
        {
            Console.Write(C_MESSAGES.LetterInfoMessage);
            classLetterAsString = Console.ReadLine();
            
            logger.Log(C_MESSAGES.LetterInfoMessage + classLetterAsString);

            if (!string.IsNullOrWhiteSpace(classLetterAsString)) continue;
            
            Console.WriteLine(C_MESSAGES.LetterErrorMessage);
            logger.Log(C_MESSAGES.LetterErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(classLetterAsString));

        classLetter = char.Parse(classLetterAsString);

        do
        {
            Console.Write(C_MESSAGES.TeacherIdInfoMessage);
            classTeacherIdAsString = Console.ReadLine();
            
            logger.Log(C_MESSAGES.TeacherIdInfoMessage + classTeacherIdAsString);

            if (!string.IsNullOrWhiteSpace(classTeacherIdAsString)) continue;
            
            Console.WriteLine(C_MESSAGES.TeacherIdErrorMessage);
            logger.Log(C_MESSAGES.TeacherIdErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(classTeacherIdAsString));

        classTeacherId = int.Parse(classTeacherIdAsString);

        do
        {
            Console.Write(C_MESSAGES.ClassroomIdInfoMessage);
            classroomIdAsString = Console.ReadLine();
            
            logger.Log(C_MESSAGES.ClassroomIdInfoMessage + classroomIdAsString);

            if (!string.IsNullOrWhiteSpace(classroomIdAsString)) continue;

            Console.WriteLine(C_MESSAGES.ClassroomIdErrorMessage);
            logger.Log(C_MESSAGES.ClassroomIdErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(classroomIdAsString));

        classroomId = int.Parse(classroomIdAsString);

        using var command = new MySqlCommand(IT_QUERIES.InsertClasses, Connection);

        command.Parameters.AddWithValue("@classNumber", classNumber);
        command.Parameters.AddWithValue("@classLetter", classLetter);
        command.Parameters.AddWithValue("@classTeacherId", classTeacherId);
        command.Parameters.AddWithValue("@classroomId", classroomId);

        command.ExecuteNonQuery();
        
        Console.WriteLine(C_MESSAGES.EndMessage);
        logger.Log(C_MESSAGES.EndMessage);
        
        Console.ReadLine();
    }

    public void PopulateStudents(
        L_INTERFACES.ILogger logger)
    {
        Console.Clear();
        
        Console.WriteLine(S_MESSAGES.StartMessage);
        logger.Log(T_MESSAGES.StartMessage);

        string? studentCode;
        string? fullName;
        string? email;
        string? phone;
        string? classIdAsString;
        string? isActiveAsString;
        string? gender;
        string? dateOfBirth;

        int classId;
        bool isActive;

        do
        {
            Console.Write(S_MESSAGES.CodeInfoMessage);
            studentCode = Console.ReadLine();
            
            logger.Log(S_MESSAGES.CodeInfoMessage + studentCode);

            if (!string.IsNullOrWhiteSpace(studentCode)) continue;
            
            Console.WriteLine(S_MESSAGES.CodeErrorMessage);
            logger.Log(S_MESSAGES.CodeErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(studentCode));

        do
        {
            Console.Write(S_MESSAGES.FullNameInfoMessage);
            fullName = Console.ReadLine();
            
            logger.Log(S_MESSAGES.FullNameInfoMessage + fullName);

            if (!string.IsNullOrWhiteSpace(fullName)) continue;
            
            Console.WriteLine(S_MESSAGES.FullNameErrorMessage);
            logger.Log(S_MESSAGES.FullNameErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(fullName));

        do
        {
            Console.Write(S_MESSAGES.EmailInfoMessage);
            email = Console.ReadLine();
            
            logger.Log(S_MESSAGES.EmailInfoMessage + email);

            if (!string.IsNullOrWhiteSpace(email)) continue;
            
            Console.WriteLine(S_MESSAGES.EmailErrorMessage);
            logger.Log(S_MESSAGES.EmailErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(email));

        do
        {
            Console.Write(S_MESSAGES.PhoneInfoMessage);
            phone = Console.ReadLine();
            
            logger.Log(S_MESSAGES.PhoneInfoMessage + phone);

            if (!string.IsNullOrWhiteSpace(phone)) continue;
            
            Console.WriteLine(S_MESSAGES.PhoneErrorMessage);
            logger.Log(S_MESSAGES.PhoneErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(phone));

        do
        {
            Console.Write(S_MESSAGES.ClassIdInfoMessage);
            classIdAsString = Console.ReadLine();
            
            logger.Log(S_MESSAGES.ClassIdInfoMessage + classIdAsString);

            if (!string.IsNullOrWhiteSpace(classIdAsString)) continue;
            
            Console.WriteLine(S_MESSAGES.ClassIdErrorMessage);
            logger.Log(S_MESSAGES.ClassIdErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(classIdAsString));

        classId = int.Parse(classIdAsString);

        do
        {
            Console.Write(S_MESSAGES.IsActiveInfoMessage);
            isActiveAsString = Console.ReadLine();
            
            logger.Log(S_MESSAGES.IsActiveInfoMessage + isActiveAsString);

            if (!string.IsNullOrWhiteSpace(isActiveAsString)
                && isActiveAsString is "1" or "0") continue;
            
            Console.WriteLine(S_MESSAGES.IsActiveErrorMessage);
            logger.Log(S_MESSAGES.IsActiveErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(isActiveAsString));

        isActive = isActiveAsString == "1";

        Console.Write(S_MESSAGES.GenderInfoMessage);
        gender = Console.ReadLine();
        
        logger.Log(S_MESSAGES.GenderInfoMessage + gender);

        Console.Write(S_MESSAGES.DateOfBirthInfoMessage);
        dateOfBirth = Console.ReadLine();
        
        logger.Log(S_MESSAGES.DateOfBirthInfoMessage + dateOfBirth);

        using var command = new MySqlCommand(IT_QUERIES.InsertStudents, Connection);

        command.Parameters.AddWithValue("@studentCode", studentCode);
        command.Parameters.AddWithValue("@fullName", fullName);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@phone", phone);
        command.Parameters.AddWithValue("@gender", gender);
        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
        command.Parameters.AddWithValue("@classId", classId);
        command.Parameters.AddWithValue("@isActive", isActive);

        command.ExecuteNonQuery();
        
        Console.WriteLine(S_MESSAGES.EndMessage);
        logger.Log(C_MESSAGES.EndMessage);
        
        Console.ReadLine();
    }

    public void PopulateTeachersSubjects(
        L_INTERFACES.ILogger logger)
    {
        Console.Clear();
        
        Console.WriteLine(TSJ_MESSAGES.StartMessage);
        logger.Log(TSJ_MESSAGES.StartMessage);

        string? teacherIdAsString;
        string? subjectIdAsString;

        int teacherId;
        int subjectId;

        do
        {
            Console.Write(TSJ_MESSAGES.TeacherIdInfoMessage);
            teacherIdAsString = Console.ReadLine();
            
            logger.Log(TSJ_MESSAGES.TeacherIdInfoMessage);

            if (!string.IsNullOrWhiteSpace(teacherIdAsString)) continue;
            
            Console.WriteLine(TSJ_MESSAGES.TeacherIdErrorMessage);
            logger.Log(TSJ_MESSAGES.TeacherIdErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(teacherIdAsString));

        teacherId = int.Parse(teacherIdAsString);

        do
        {
            Console.Write(TSJ_MESSAGES.SubjectIdInfoMessage);
            subjectIdAsString = Console.ReadLine();
            
            logger.Log(TSJ_MESSAGES.SubjectIdInfoMessage);

            if (!string.IsNullOrWhiteSpace(subjectIdAsString)) continue;
            
            Console.WriteLine(TSJ_MESSAGES.SubjectIdErrorMessage);
            logger.Log(TSJ_MESSAGES.SubjectIdErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(subjectIdAsString));

        subjectId = int.Parse(subjectIdAsString);

        using var command = new MySqlCommand(IT_QUERIES.InsertTeachersSubjects, Connection);

        command.Parameters.AddWithValue("@teacherId", teacherId);
        command.Parameters.AddWithValue("@subjectId", subjectId);

        command.ExecuteNonQuery();

        Console.WriteLine(TSJ_MESSAGES.EndMessage);
        logger.Log(C_MESSAGES.EndMessage);
        
        Console.ReadLine();
    }

    public void PopulateClassesSubjects(
        L_INTERFACES.ILogger logger)
    {
        Console.Clear();
        
        Console.WriteLine(CSJ_MESSAGES.StartMessage);
        logger.Log(CSJ_MESSAGES.StartMessage);

        string? classIdAsString;
        string? subjectIdAsString;

        int classId;
        int subjectId;

        do
        {
            Console.Write(CSJ_MESSAGES.ClassIdInfoMessage);
            classIdAsString = Console.ReadLine();
            
            logger.Log(CSJ_MESSAGES.ClassIdInfoMessage + classIdAsString);

            if (!string.IsNullOrWhiteSpace(classIdAsString)) continue;
            
            Console.WriteLine(CSJ_MESSAGES.ClassIdErrorMessage);
            logger.Log(CSJ_MESSAGES.ClassIdErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(classIdAsString));

        classId = int.Parse(classIdAsString);

        do
        {
            Console.Write(CSJ_MESSAGES.SubjectIdInfoMessage);
            subjectIdAsString = Console.ReadLine();
            
            logger.Log(CSJ_MESSAGES.SubjectIdInfoMessage + subjectIdAsString);

            if (!string.IsNullOrWhiteSpace(subjectIdAsString)) continue;
            
            Console.WriteLine(CSJ_MESSAGES.SubjectIdErrorMessage);
            logger.Log(CSJ_MESSAGES.SubjectIdErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(subjectIdAsString));

        subjectId = int.Parse(subjectIdAsString);

        using var command = new MySqlCommand(IT_QUERIES.InsertClassesSubjects, Connection);

        command.Parameters.AddWithValue("@classId", classId);
        command.Parameters.AddWithValue("@subjectId", subjectId);

        command.ExecuteNonQuery();

        Console.WriteLine(CSJ_MESSAGES.EndMessage);
        logger.Log(C_MESSAGES.EndMessage);
        
        Console.ReadLine();
    }

    public void PopulateStudentsParents(
        L_INTERFACES.ILogger logger)
    {
        Console.Clear();
        
        Console.WriteLine(SP_MESSAGES.StartMessage);
        logger.Log(SP_MESSAGES.StartMessage);

        string? studentIdAsString;
        string? parentIdAsString;

        int studentId;
        int parentId;

        do
        {
            Console.Write(SP_MESSAGES.StudentIdInfoMessage);
            studentIdAsString = Console.ReadLine();
            
            logger.Log(SP_MESSAGES.StudentIdInfoMessage + studentIdAsString);

            if (!string.IsNullOrWhiteSpace(studentIdAsString)) continue;
            
            Console.WriteLine(SP_MESSAGES.StudentIdErrorMessage);
            logger.Log(SP_MESSAGES.StudentIdErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(studentIdAsString));

        studentId = int.Parse(studentIdAsString);

        do
        {
            Console.Write(SP_MESSAGES.ParentIdInfoMessage);
            parentIdAsString = Console.ReadLine();
            
            logger.Log(SP_MESSAGES.ParentIdInfoMessage + parentIdAsString);

            if (!string.IsNullOrWhiteSpace(parentIdAsString)) continue;
            
            Console.WriteLine(SP_MESSAGES.ParentIdErrorMessage);
            logger.Log(SP_MESSAGES.ParentIdErrorMessage);
        }
        while (string.IsNullOrWhiteSpace(parentIdAsString));

        parentId = int.Parse(parentIdAsString);

        using var command = new MySqlCommand(IT_QUERIES.InsertStudentsParents, Connection);

        command.Parameters.AddWithValue("@studentId", studentId);
        command.Parameters.AddWithValue("@parentId", parentId);

        command.ExecuteNonQuery();

        Console.WriteLine(SP_MESSAGES.EndMessage);
        logger.Log(C_MESSAGES.EndMessage);
        
        Console.ReadLine();
    }
}