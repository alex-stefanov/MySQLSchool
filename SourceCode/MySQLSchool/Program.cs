using COMMON = MySQLSchool.Common;
using DATA = MySQLSchool.Data;
using INTERFACES = MySQLSchool.Infrastructure.Interfaces;
using IMPLEMENTATIONS = MySQLSchool.Infrastructure.Implementation;
using LOGGERS = MySQLSchool.Logging.Loggers;
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
using II_MESSAGES = MySQLSchool.Common.Messages.InitializersMessages.InfoMessages;
using IE_MESSAGES = MySQLSchool.Common.Messages.InitializersMessages.ErrorMessages;
using MI_MESSAGES = MySQLSchool.Common.Messages.MenuMessages.MainPanelMessages.InfoMessages;
using FI_MESSAGES = MySQLSchool.Common.Messages.MenuMessages.FunctionalityPanelMessages.InfoMessages;
using PI_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.GeneralInfoMessages;
using PE_MESSAGES = MySQLSchool.Common.Messages.PopulateMessages.GeneralErrorMessages;

namespace MySQLSchool;

public class Program
{
    //TODO: Add suggestions
    //TODO:Validation
    //TODO:XML boc boc
    static void Main()
    {
        #region I/O Settings

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        #endregion

        #region Welcome Message

        //TODO:Implement welcome message

        #endregion

        DATA.DbInitializer.Initialize();

        //TODO: Change the logger type to the desired one
        //L_INTERFACES.ILogger logger = new LOGGERS.TextLogger("../../../log.txt");
        L_INTERFACES.ILogger logger = new LOGGERS.ExcelLogger("../../../log.xlsx");

        //TODO: Configure options
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
            INTERFACES.ISelectService selectService = new IMPLEMENTATIONS.SelectService();

            switch (choice)
            {
                case "1":
                    {
                        try
                        {
                            logger.Log(PI_MESSAGES.ParentsMessage);

                            Console.Clear();

                            Console.WriteLine(P_MESSAGES.StartMessage);
                            logger.Log(P_MESSAGES.StartMessage);

                            string? parentCode, fullName, phone, email;

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

                            populateService.PopulateParents(
                                parentCode: parentCode,
                                fullName: fullName,
                                phone: phone,
                                email: email);

                            Console.WriteLine(P_MESSAGES.EndMessage);
                            logger.Log(P_MESSAGES.EndMessage);

                            Console.ReadLine();
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

                            populateService.PopulateSubjects(
                                title: title,
                                level: level);

                            Console.WriteLine(SJ_MESSAGES.EndMessage);
                            logger.Log(SJ_MESSAGES.EndMessage);

                            Console.ReadLine();
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
                            Console.Clear();

                            Console.WriteLine(T_MESSAGES.StartMessage);
                            logger.Log(T_MESSAGES.StartMessage);

                            string? teacherCode, fullName, email, phone, workingDaysAsString, dateOfBirth, gender;

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

                            logger.Log(PI_MESSAGES.TeachersMessage);

                            populateService.PopulateTeachers(
                                teacherCode: teacherCode,
                                fullName: fullName,
                                email: email,
                                phone: phone,
                                workingDays: workingDays,
                                dateOfBirth: dateOfBirth,
                                gender: gender);

                            Console.WriteLine(T_MESSAGES.EndMessage);
                            logger.Log(T_MESSAGES.EndMessage);

                            Console.ReadLine();
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

                            Console.Clear();

                            Console.WriteLine(CR_MESSAGES.StartMessage);
                            logger.Log(T_MESSAGES.StartMessage);

                            string? floorAsString, capacityAsString, description;

                            int floor, capacity;

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

                            populateService.PopulateClassrooms(
                                floor: floor,
                                capacity: capacity,
                                description: description);

                            Console.WriteLine(CR_MESSAGES.EndMessage);
                            logger.Log(T_MESSAGES.EndMessage);

                            Console.ReadLine();
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

                            Console.Clear();

                            Console.WriteLine(C_MESSAGES.StartMessage);
                            logger.Log(T_MESSAGES.StartMessage);

                            string? classNumberAsString, classLetterAsString, classTeacherIdAsString, classroomIdAsString;

                            int classNumber, classTeacherId, classroomId;

                            char classLetter;

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

                            populateService.PopulateClasses(
                                classNumber: classNumber,
                                classLetter: classLetter,
                                classTeacherId: classTeacherId,
                                classroomId: classroomId);

                            Console.WriteLine(C_MESSAGES.EndMessage);
                            logger.Log(C_MESSAGES.EndMessage);

                            Console.ReadLine();
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

                            Console.Clear();

                            Console.WriteLine(S_MESSAGES.StartMessage);
                            logger.Log(T_MESSAGES.StartMessage);

                            string? studentCode, fullName, email, phone, classIdAsString, isActiveAsString, gender, dateOfBirth;

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

                            populateService.PopulateStudents(
                                studentCode: studentCode,
                                fullName: fullName,
                                email: email,
                                phone: phone,
                                classId: classId,
                                isActive: isActive,
                                gender: gender,
                                dateOfBirth: dateOfBirth);

                            Console.WriteLine(S_MESSAGES.EndMessage);
                            logger.Log(C_MESSAGES.EndMessage);

                            Console.ReadLine();
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

                            populateService.PopulateTeachersSubjects(
                                teacherId: teacherId,
                                subjectId: subjectId);

                            Console.WriteLine(TSJ_MESSAGES.EndMessage);
                            logger.Log(C_MESSAGES.EndMessage);

                            Console.ReadLine();
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

                            populateService.PopulateClassesSubjects(
                                classId: classId,
                                subjectId: subjectId);

                            Console.WriteLine(CSJ_MESSAGES.EndMessage);
                            logger.Log(C_MESSAGES.EndMessage);

                            Console.ReadLine();
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

                            populateService.PopulateStudentsParents(
                                studentId: studentId,
                                parentId: parentId);

                            Console.WriteLine(SP_MESSAGES.EndMessage);
                            logger.Log(C_MESSAGES.EndMessage);

                            Console.ReadLine();
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

                            switch (functionalityChoice)
                            {
                                case "1":
                                    {
                                        selectService.GetStudentsNames();

                                        Console.ReadLine();

                                        break;
                                    }
                                case "2":
                                    {
                                        selectService.GetTeachersNamesAndSubject();

                                        Console.ReadLine();

                                        break;
                                    }
                                case "3":
                                    {
                                        selectService.GetClassesAndTeacher();

                                        Console.ReadLine();

                                        break;
                                    }
                                case "4":
                                    {
                                        selectService.GetSubjectsWithTeacherCount();

                                        Console.ReadLine();

                                        break;
                                    }
                                case "5":
                                    {
                                        selectService.GetClassroomsOrderedByFloor();

                                        Console.ReadLine();

                                        break;
                                    }
                                case "6":
                                    {
                                        selectService.GetStudentsByClasses();

                                        Console.ReadLine();

                                        break;
                                    }
                                case "7":
                                    {
                                        Console.Write("Въведи клас: ");
                                        int classNumber = int.Parse(Console.ReadLine());

                                        Console.WriteLine();

                                        Console.Write("Въведи буква на класа: ");
                                        char classLetter = char.Parse(Console.ReadLine());

                                        selectService.GetAllStudentsByClass(
                                            classNumber: classNumber,
                                            classLetter: classLetter);

                                        Console.ReadLine();

                                        break;
                                    }
                                case "8":
                                    {
                                        Console.Write("Въведи рожден ден(yyyy-MM-dd): ");
                                        string dateOfBirth = Console.ReadLine();

                                        selectService.GetStudentsWithSpecificBirthday(
                                            dateOfBirth: dateOfBirth);

                                        Console.ReadLine();

                                        break;
                                    }
                                case "9":
                                    {
                                        Console.Write("Въведи име на ученик: ");
                                        string studentName = Console.ReadLine();

                                        selectService.GetCountOfSubjectsByStudent(
                                            studentName: studentName);

                                        Console.ReadLine();

                                        break;
                                    }
                                case "10":
                                    {
                                        Console.Write("Въведи име на ученик: ");
                                        string studentName = Console.ReadLine();

                                        selectService.GetTeachersAndSubjectsByStudent(
                                            studentName: studentName);

                                        Console.ReadLine();

                                        break;
                                    }
                                case "11":
                                    {
                                        Console.Write("Въведи имейл на родител: ");
                                        string parentEmail = Console.ReadLine();

                                        selectService.GetClassByParentEmail(
                                            parentEmail: parentEmail);

                                        Console.ReadLine();

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
}