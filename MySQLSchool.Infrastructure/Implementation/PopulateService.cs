using MySqlConnector;
using MySQLSchool.Data;
using MySQLSchool.Infrastructure.Interfaces;
using MySQLSchool.Logging.Interfaces;
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
    : IPopulateService
{
    public readonly static MySqlConnection connection = DbInitializer.GetConnection();

    public void PopulateParents()
    {
        Console.Clear();

        Console.WriteLine(P_MESSAGES.PopulateParentsStartMessage);

        string? parentCode;
        string? fullName;
        string? phone;
        string? email;

        do
        {
            Console.Write(P_MESSAGES.PopulateParentsParentCodeInfoMessage);

            parentCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(parentCode))
            {
                Console.Write(P_MESSAGES.PopulateParentsParentCodeErrorMessage);
            }
        }
        while (string.IsNullOrWhiteSpace(parentCode));

        do
        {
            Console.Write("Пълно име на родителя: ");
            fullName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Пълното име на родителя е задължително. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(fullName));

        do
        {
            Console.Write("Телефон: ");
            phone = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(phone))
            {
                Console.WriteLine("Телефонът е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(phone));

        do
        {
            Console.Write("Имейл: ");
            email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Имейлът е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(email));

        using var command = new MySqlCommand(IT_QUERIES.InsertParentsQuery, connection);

        command.Parameters.AddWithValue("@parentCode", parentCode);
        command.Parameters.AddWithValue("@fullName", fullName);
        command.Parameters.AddWithValue("@phone", phone);
        command.Parameters.AddWithValue("@email", email);

        command.ExecuteNonQuery();

        Console.WriteLine("Данните за родителя са успешно записани.");
        Console.ReadLine();
    }

    public void PopulateSubjects()
    {
        Console.Clear();
        Console.WriteLine("Попълнете данни за предмет:");

        string? title;
        string? level;

        do
        {
            Console.Write("Заглавие на предмета: ");
            title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Заглавието на предмета е задължително. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(title));

        do
        {
            Console.Write("Ниво на предмета: ");
            level = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(level))
            {
                Console.WriteLine("Нивото на предмета е задължително. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(level));

        using var command = new MySqlCommand(IT_QUERIES.InsertSubjects, connection);

        command.Parameters.AddWithValue("@title", title);
        command.Parameters.AddWithValue("@level", level);

        command.ExecuteNonQuery();

        Console.WriteLine("Данните за предмета са успешно записани.");
        Console.ReadLine();
    }

    public void PopulateTeachers()
    {
        Console.Clear();
        Console.WriteLine("Попълнете данни за учител:");

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
            Console.Write("Код на учителя: ");
            teacherCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(teacherCode))
            {
                Console.WriteLine("Кодът на учителя е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(teacherCode));

        do
        {
            Console.Write("Пълно име на учителя: ");
            fullName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Пълното име на учителя е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(fullName));

        do
        {
            Console.Write("Имейл: ");
            email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Имейлът на учителя е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(email));

        do
        {
            Console.Write("Телефон: ");
            phone = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(phone))
            {
                Console.WriteLine("Телефонът на учителя е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(phone));

        do
        {
            Console.Write("Работни дни: ");
            workingDaysAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(workingDaysAsString))
            {
                Console.WriteLine("Работните дни на предмета са задължителни. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(workingDaysAsString));

        workingDays = int.Parse(workingDaysAsString);

        Console.Write("Дата на раждане (YYYY-MM-DD): ");
        dateOfBirth = Console.ReadLine();

        Console.Write("Пол: ");
        gender = Console.ReadLine();

        using var command = new MySqlCommand(IT_QUERIES.InsertTeachers, connection);

        command.Parameters.AddWithValue("@teacherCode", teacherCode);
        command.Parameters.AddWithValue("@fullName", fullName);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@phone", phone);
        command.Parameters.AddWithValue("@workingDays", workingDays);
        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
        command.Parameters.AddWithValue("@gender", gender);

        command.ExecuteNonQuery();

        Console.WriteLine("Данните за учителя са успешно записани.");
        Console.ReadLine();
    }

    public void PopulateClassrooms()
    {
        Console.Clear();
        Console.WriteLine("Попълнете данни за класната стая:");

        string? floorAsString;
        string? capacityAsString;
        string? description;

        int floor;
        int capacity;

        do
        {
            Console.Write("Етаж: ");
            floorAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(floorAsString))
            {
                Console.WriteLine("Етажът на стаята е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(floorAsString));

        floor = int.Parse(floorAsString);

        do
        {
            Console.Write("Капацитет: ");
            capacityAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(capacityAsString))
            {
                Console.WriteLine("Капацитетът на стаята е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(capacityAsString));

        capacity = int.Parse(capacityAsString);

        do
        {
            Console.Write("Описание: ");
            description = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine("Описанието на стаята е задължително. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(description));

        using var command = new MySqlCommand(IT_QUERIES.InsertClassrooms, connection);

        command.Parameters.AddWithValue("@floor", floor);
        command.Parameters.AddWithValue("@capacity", capacity);
        command.Parameters.AddWithValue("@description", description);

        command.ExecuteNonQuery();

        Console.WriteLine("Данните за класната стая са успешно записани.");
        Console.ReadLine();
    }

    public void PopulateClasses()
    {
        Console.Clear();
        Console.WriteLine("Попълнете данни за клас:");

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
            Console.Write("Номер на клас: ");
            classNumberAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(classNumberAsString))
            {
                Console.WriteLine("Номерът на класа е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(classNumberAsString));

        classNumber = int.Parse(classNumberAsString);

        do
        {
            Console.Write("Буква на клас: ");
            classLetterAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(classLetterAsString))
            {
                Console.WriteLine("Буквата на класа е задължителна. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(classLetterAsString));

        classLetter = char.Parse(classLetterAsString);

        do
        {
            Console.Write("Идентификатор на учител на клас: ");
            classTeacherIdAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(classTeacherIdAsString))
            {
                Console.WriteLine("Идентификатор на учителя на класа е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(classTeacherIdAsString));

        classTeacherId = int.Parse(classTeacherIdAsString);

        do
        {
            Console.Write("Идентификатор на класна стая: ");
            classroomIdAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(classroomIdAsString))
            {
                Console.WriteLine("Идентификатор на класната стая е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(classroomIdAsString));

        classroomId = int.Parse(classroomIdAsString);

        using var command = new MySqlCommand(IT_QUERIES.InsertClasses, connection);

        command.Parameters.AddWithValue("@classNumber", classNumber);
        command.Parameters.AddWithValue("@classLetter", classLetter);
        command.Parameters.AddWithValue("@classTeacherId", classTeacherId);
        command.Parameters.AddWithValue("@classroomId", classroomId);

        command.ExecuteNonQuery();
        Console.WriteLine("Данните за класа са успешно записани.");
        Console.ReadLine();
    }

    public void PopulateStudents()
    {
        Console.Clear();
        Console.WriteLine("Попълнете данни за студент:");

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
            Console.Write("Код на студента: ");
            studentCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(studentCode))
            {
                Console.WriteLine("Кодът на студента е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(studentCode));

        do
        {
            Console.Write("Пълно име на студента: ");
            fullName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Пълното име на студента е задължително. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(fullName));

        do
        {
            Console.Write("Имейл: ");
            email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Имейлът на студента е задължително. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(email));

        do
        {
            Console.Write("Телефон: ");
            phone = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(phone))
            {
                Console.WriteLine("Телефонът на студента е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(phone));

        do
        {
            Console.Write("Идентификатор на клас: ");
            classIdAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(classIdAsString))
            {
                Console.WriteLine("Идентификаторът на класа е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(classIdAsString));

        classId = int.Parse(classIdAsString);

        do
        {
            Console.Write("Активен ли е студентът (1 за да, 0 за не): ");
            isActiveAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(isActiveAsString)
                || (isActiveAsString != "1" && isActiveAsString != "0"))
            {
                Console.WriteLine("Активността на студента е задължителна. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(isActiveAsString));

        if (isActiveAsString == "1")
        {
            isActive = true;
        }
        else
        {
            isActive = false;
        }

        Console.Write("Пол: ");
        gender = Console.ReadLine();

        Console.Write("Дата на раждане (YYYY-MM-DD): ");
        dateOfBirth = Console.ReadLine();

        using var command = new MySqlCommand(IT_QUERIES.InsertStudents, connection);

        command.Parameters.AddWithValue("@studentCode", studentCode);
        command.Parameters.AddWithValue("@fullName", fullName);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@phone", phone);
        command.Parameters.AddWithValue("@gender", gender);
        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
        command.Parameters.AddWithValue("@classId", classId);
        command.Parameters.AddWithValue("@isActive", isActive);

        command.ExecuteNonQuery();
        Console.WriteLine("Данните за студента са успешно записани.");
        Console.ReadLine();
    }

    public void PopulateTeachersSubjects()
    {
        Console.Clear();
        Console.WriteLine("Попълнете данни за учител и предмет:");

        string? teacherIdAsString;
        string? subjectIdAsString;

        int teacherId;
        int subjectId;

        do
        {
            Console.Write("Идентификатор на учител: ");
            teacherIdAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(teacherIdAsString))
            {
                Console.WriteLine("Идентификаторът на учителя е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(teacherIdAsString));

        teacherId = int.Parse(teacherIdAsString);

        do
        {
            Console.Write("Идентификатор на предмет: ");
            subjectIdAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(subjectIdAsString))
            {
                Console.WriteLine("Идентификаторът на предмета е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(subjectIdAsString));

        subjectId = int.Parse(subjectIdAsString);

        using var command = new MySqlCommand(IT_QUERIES.InsertTeachersSubjects, connection);

        command.Parameters.AddWithValue("@teacherId", teacherId);
        command.Parameters.AddWithValue("@subjectId", subjectId);

        command.ExecuteNonQuery();

        Console.WriteLine("Данните за учителя и предмета са успешно записани.");
        Console.ReadLine();
    }

    public void PopulateClassesSubjects()
    {
        Console.Clear();
        Console.WriteLine("Попълнете данни за клас и предмет:");

        string? classIdAsString;
        string? subjectIdAsString;

        int classId;
        int subjectId;

        do
        {
            Console.Write("Идентификатор на клас: ");
            classIdAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(classIdAsString))
            {
                Console.WriteLine("Идентификаторът на класа е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(classIdAsString));

        classId = int.Parse(classIdAsString);

        do
        {
            Console.Write("Идентификатор на предмет: ");
            subjectIdAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(subjectIdAsString))
            {
                Console.WriteLine("Идентификаторът на предмета е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(subjectIdAsString));

        subjectId = int.Parse(subjectIdAsString);

        using var command = new MySqlCommand(IT_QUERIES.InsertClassesSubjects, connection);

        command.Parameters.AddWithValue("@classId", classId);
        command.Parameters.AddWithValue("@subjectId", subjectId);

        command.ExecuteNonQuery();

        Console.WriteLine("Данните за класа и предмета са успешно записани.");
        Console.ReadLine();
    }

    public void PopulateStudentsParents()
    {
        Console.Clear();
        Console.WriteLine("Попълнете данни за студент и родител:");

        string? studentIdAsString;
        string? parentIdAsString;

        int studentId;
        int parentId;

        do
        {
            Console.Write("Идентификатор на студент: ");
            studentIdAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(studentIdAsString))
            {
                Console.WriteLine("Идентификаторът на студента е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(studentIdAsString));

        studentId = int.Parse(studentIdAsString);

        do
        {
            Console.Write("Идентификатор на родител: ");
            parentIdAsString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(parentIdAsString))
            {
                Console.WriteLine("Идентификаторът на родителя е задължителен. Моля, въведете отново.");
            }
        }
        while (string.IsNullOrWhiteSpace(parentIdAsString));

        parentId = int.Parse(parentIdAsString);

        using var command = new MySqlCommand(IT_QUERIES.InsertStudentsParents, connection);

        command.Parameters.AddWithValue("@studentId", studentId);
        command.Parameters.AddWithValue("@parentId", parentId);

        command.ExecuteNonQuery();

        Console.WriteLine("Данните за студента и родителя са успешно записани.");
        Console.ReadLine();
    }
}