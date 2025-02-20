using DATA = MySQLSchool.Data;
using COMMON = MySQLSchool.Common;
using HELPERS = MySQLSchool.Helpers;
using INTERFACES = MySQLSchool.Infrastructure.Interfaces;
using IMPLEMENTATIONS = MySQLSchool.Infrastructure.Implementation;
using LOGGERS = MySQLSchool.Logging.Loggers;
using L_INTERFACES = MySQLSchool.Logging.Interfaces;

#region Messages

using P_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.ParentsMessages;
using SJ_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.SubjectsMessages;
using T_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.TeachersMessages;
using CR_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.ClassroomsMessages;
using C_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.ClassesMessages;
using S_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.StudentsMessages;
using TSJ_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.TeachersSubjectsMessages;
using CSJ_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.ClassesSubjectsMessages;
using PI_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.GeneralInfoMessages;
using PE_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.GeneralErrorMessages;
using SP_MESSAGES = MySQLSchool.Common.Messages.InsertMessages.StudentsParentsMessages;

using CI_MESSAGES = MySQLSchool.Common.Messages.CreateMessages.InfoMessages;
using CE_MESSAGES = MySQLSchool.Common.Messages.CreateMessages.ErrorMessages;

using SI_MESSAGES = MySQLSchool.Common.Messages.SelectMessages.SelectInputMessages;

using MI_MESSAGES = MySQLSchool.Common.Messages.MenuMessages.MainPanelMessages.InfoMessages;
using FI_MESSAGES = MySQLSchool.Common.Messages.MenuMessages.FunctionalityPanelMessages.InfoMessages;

#endregion

namespace MySQLSchool;

public static class Program
{
    //TODO: Add suggestions
    //TODO: Validation
    //TODO: XML boc boc
    //TODO: Add logging to second menu
    //TODO: Constants for second menu panel
    //TODO: Press key to exit
    //TODO: Interface for logging
    //TODO: Interface for options
    //TODO: Implement welcome message
    //TODO: Option for Default Insert
    //TODO: Validation to capacity in insert

    private static void Main()
    {
        #region I/O Settings

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        #endregion

        #region Welcome Message

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
                logger.Log(CI_MESSAGES.ParentsMessage);

                createService.CreateParents();
            }
            catch (Exception ex)
            {
                Console.WriteLine(CE_MESSAGES.ParentsMessage + ex.Message);
                logger.Log(CE_MESSAGES.ParentsMessage + ex.Message);
            }

            try
            {
                logger.Log(CI_MESSAGES.SubjectsMessage);

                createService.CreateSubjects();
            }
            catch (Exception ex)
            {
                Console.WriteLine(CE_MESSAGES.SubjectsMessage + ex.Message);
                logger.Log(CE_MESSAGES.SubjectsMessage + ex.Message);
            }

            try
            {
                logger.Log(CI_MESSAGES.TeachersMessage);

                createService.CreateTeachers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(CE_MESSAGES.TeachersMessage + ex.Message);
                logger.Log(CE_MESSAGES.TeachersMessage + ex.Message);
            }

            try
            {
                logger.Log(CI_MESSAGES.ClassroomsMessage);
                
                createService.CreateClassrooms();
            }
            catch (Exception ex)
            {
                Console.WriteLine(CE_MESSAGES.ClassroomsMessage + ex.Message);
                logger.Log(CE_MESSAGES.ClassroomsMessage + ex.Message);
            }

            try
            {
                logger.Log(CI_MESSAGES.ClassesMessage);

                createService.CreateClasses();
            }
            catch (Exception ex)
            {
                Console.WriteLine(CE_MESSAGES.ClassesMessage + ex.Message);
                logger.Log(CE_MESSAGES.ClassesMessage + ex.Message);
            }

            try
            {
                logger.Log(CI_MESSAGES.StudentsMessage);

                createService.CreateStudents();
            }
            catch (Exception ex)
            {
                Console.WriteLine(CE_MESSAGES.StudentsMessage + ex.Message);
                logger.Log(CE_MESSAGES.StudentsMessage + ex.Message);
            }

            try
            {
                logger.Log(CI_MESSAGES.TeachersSubjectsMessage);

                createService.CreateTeachersSubjects();
            }
            catch (Exception ex)
            {
                Console.WriteLine(CE_MESSAGES.TeachersSubjectsMessage + ex.Message);
                logger.Log(CE_MESSAGES.TeachersSubjectsMessage + ex.Message);
            }

            try
            {
                logger.Log(CI_MESSAGES.ClassesSubjectsMessage);

                createService.CreateClassesSubjects();
            }
            catch (Exception ex)
            {
                Console.WriteLine(CE_MESSAGES.ClassesSubjectsMessage + ex.Message);
                logger.Log(CE_MESSAGES.ClassesSubjectsMessage + ex.Message);
            }

            try
            {
                logger.Log(CI_MESSAGES.StudentsParentsMessage);
                
                createService.CreateStudentsParents();
            }
            catch (Exception ex)
            {
                Console.WriteLine(CE_MESSAGES.StudentsParentsMessage + ex.Message);
                logger.Log(CE_MESSAGES.StudentsParentsMessage + ex.Message);
            }

            #endregion
        }

        while (true)
        {
            Console.Clear();
            
            HELPERS.MenuHelper.ShowMainMenu();

            var choice = Console.ReadLine();

            if (string.IsNullOrEmpty(choice))
            {
                return;
            }

            INTERFACES.IInsertService insertService = new IMPLEMENTATIONS.InsertService();
            INTERFACES.ISelectService selectService = new IMPLEMENTATIONS.SelectService();

            switch (choice)
            {
                case "1":
                    {
                        #region Log
                        
                        logger.Log(PI_MESSAGES.ParentsMessage);

                        Console.Clear();

                        Console.WriteLine(P_MESSAGES.StartMessage);
                        logger.Log(P_MESSAGES.StartMessage);
                        
                        #endregion
                            
                        #region Parameters
                        
                        var parentCode = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: P_MESSAGES.CodeInfoMessage,
                            errorMessage: P_MESSAGES.CodeErrorMessage,
                            logger: logger);
                            
                        var fullName = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: P_MESSAGES.FullNameInfoMessage,
                            errorMessage: P_MESSAGES.FullNameErrorMessage,
                            logger: logger);
                            
                        var phone = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: P_MESSAGES.PhoneInfoMessage,
                            errorMessage: P_MESSAGES.PhoneErrorMessage,
                            logger: logger);
                            
                        var email = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: P_MESSAGES.EmailInfoMessage,
                            errorMessage: P_MESSAGES.EmailErrorMessage,
                            logger: logger);
                        
                        #endregion
                        
                        try
                        {
                            insertService.InsertParents(
                                parentCode: parentCode,
                                fullName: fullName,
                                phone: phone,
                                email: email);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.ParentsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.ParentsMessage + ex.Message);
                        }
                        
                        Console.WriteLine(P_MESSAGES.EndMessage);
                        logger.Log(P_MESSAGES.EndMessage);

                        Console.ReadLine();
                        
                        break;
                    }
                case "2":
                    {
                        #region Log
                        
                        logger.Log(PI_MESSAGES.SubjectsMessage);

                        Console.Clear();

                        Console.WriteLine(SJ_MESSAGES.StartMessage);
                        logger.Log(SJ_MESSAGES.StartMessage);
                        
                        #endregion
                        
                        #region Parameters 
                        
                        var title = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: SJ_MESSAGES.TitleInfoMessage,
                            errorMessage: SJ_MESSAGES.TitleErrorMessage,
                            logger: logger);
                            
                        var level = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: SJ_MESSAGES.TitleInfoMessage,
                            errorMessage: SJ_MESSAGES.LevelErrorMessage,
                            logger: logger);
                        
                        #endregion
                        
                        try
                        {
                            insertService.InsertSubjects(
                                title: title,
                                level: level);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.SubjectsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.SubjectsMessage + ex.Message);
                        }
                        
                        Console.WriteLine(SJ_MESSAGES.EndMessage);
                        logger.Log(SJ_MESSAGES.EndMessage);

                        Console.ReadLine();
                        
                        break;
                    }
                case "3":
                    {
                        #region Log
                        
                        logger.Log(PI_MESSAGES.TeachersMessage);
                            
                        Console.Clear();

                        Console.WriteLine(T_MESSAGES.StartMessage);
                        logger.Log(T_MESSAGES.StartMessage);
                        
                        #endregion
                        
                        #region Parameters

                        var teacherCode = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: T_MESSAGES.CodeInfoMessage,
                            errorMessage: T_MESSAGES.CodeErrorMessage, 
                            logger: logger);
                            
                        var fullName = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: T_MESSAGES.FullNameInfoMessage,
                            errorMessage: T_MESSAGES.FullNameErrorMessage,
                            logger: logger);
                            
                        var email = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: T_MESSAGES.EmailInfoMessage,
                            errorMessage: T_MESSAGES.EmailErrorMessage,
                            logger: logger);

                        var phone = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: T_MESSAGES.EmailInfoMessage,
                            errorMessage: T_MESSAGES.EmailErrorMessage,
                            logger: logger);
                            
                        var workingDays = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: T_MESSAGES.WorkingDaysInfoMessage,
                            errorMessage: T_MESSAGES.WorkingDaysErrorMessage,
                            logger: logger);
                            
                        string? dateOfBirth = HELPERS.ValidationHelper.GetNotValidatedInput(
                            infoMessage: T_MESSAGES.DateOfBirthInfoMessage,
                            logger: logger);

                        string? gender = HELPERS.ValidationHelper.GetNotValidatedInput(
                            infoMessage: T_MESSAGES.GenderInfoMessage,
                            logger: logger);
                            
                        #endregion
                        
                        try
                        {
                            insertService.InsertTeachers(
                                teacherCode: teacherCode,
                                fullName: fullName,
                                email: email,
                                phone: phone,
                                workingDays: workingDays,
                                dateOfBirth: dateOfBirth,
                                gender: gender);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.TeachersMessage + ex.Message);
                            logger.Log(PE_MESSAGES.TeachersMessage + ex.Message);
                        }
                        
                        Console.WriteLine(T_MESSAGES.EndMessage);
                        logger.Log(T_MESSAGES.EndMessage);

                        Console.ReadLine();
                        
                        break;
                    }
                case "4":
                    {
                        #region Log
                        
                        logger.Log(PI_MESSAGES.ClassroomsMessage);

                        Console.Clear();

                        Console.WriteLine(CR_MESSAGES.StartMessage);
                        logger.Log(T_MESSAGES.StartMessage);
                        
                        #endregion

                        #region Parameters
                        
                        var floor = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: CR_MESSAGES.FloorInfoMessage,
                            errorMessage: CR_MESSAGES.FloorErrorMessage, 
                            logger: logger);
                            
                        var capacity = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: CR_MESSAGES.CapacityInfoMessage,
                            errorMessage: CR_MESSAGES.CapacityErrorMessage, 
                            logger: logger);

                        var description = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: CR_MESSAGES.DescriptionInfoMessage,
                            errorMessage: CR_MESSAGES.DescriptionErrorMessage, 
                            logger: logger);
                        
                        #endregion
                        
                        try
                        {
                            insertService.InsertClassrooms(
                                floor: floor,
                                capacity: capacity,
                                description: description);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.ClassroomsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.ClassroomsMessage + ex.Message);
                        }
                        
                        Console.WriteLine(CR_MESSAGES.EndMessage);
                        logger.Log(T_MESSAGES.EndMessage);

                        Console.ReadLine();
                        
                        break;
                    }
                case "5":
                    {
                        #region Log
                        
                        logger.Log(PI_MESSAGES.ClassesMessage);

                        Console.Clear();

                        Console.WriteLine(C_MESSAGES.StartMessage);
                        logger.Log(T_MESSAGES.StartMessage);
                        
                        #endregion

                        #region Parameters
                        
                        var classNumber = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: C_MESSAGES.NumberInfoMessage,
                            errorMessage: C_MESSAGES.NumberErrorMessage, 
                            logger: logger);

                        var classLetter = HELPERS.ValidationHelper.GetValidatedInput<char>(
                            infoMessage: C_MESSAGES.LetterInfoMessage,
                            errorMessage: C_MESSAGES.LetterErrorMessage, 
                            logger: logger);

                        var classTeacherId = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: C_MESSAGES.TeacherIdInfoMessage,
                            errorMessage: C_MESSAGES.TeacherIdErrorMessage, 
                            logger: logger);

                        var classroomId = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: C_MESSAGES.ClassroomIdInfoMessage,
                            errorMessage: C_MESSAGES.ClassroomIdErrorMessage, 
                            logger: logger);
                        
                        #endregion
                        
                        try
                        {
                            insertService.InsertClasses(
                                classNumber: classNumber,
                                classLetter: classLetter,
                                classTeacherId: classTeacherId,
                                classroomId: classroomId);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.ClassesMessage + ex.Message);
                            logger.Log(PE_MESSAGES.ClassesMessage + ex.Message);
                        }
                        
                        Console.WriteLine(C_MESSAGES.EndMessage);
                        logger.Log(C_MESSAGES.EndMessage);

                        Console.ReadLine();
                        
                        break;
                    }
                case "6":
                    {
                        #region Log
                        
                        logger.Log(PI_MESSAGES.StudentsMessage);

                        Console.Clear();

                        Console.WriteLine(S_MESSAGES.StartMessage);
                        logger.Log(T_MESSAGES.StartMessage);
                            
                        #endregion
                        
                        #region Parameters
                        
                        var studentCode = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: S_MESSAGES.CodeInfoMessage,
                            errorMessage: S_MESSAGES.CodeErrorMessage, 
                            logger: logger);
                            
                        var fullName = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: S_MESSAGES.FullNameInfoMessage,
                            errorMessage: S_MESSAGES.FullNameErrorMessage, 
                            logger: logger);
                            
                        var email = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: S_MESSAGES.EmailInfoMessage,
                            errorMessage: S_MESSAGES.EmailErrorMessage, 
                            logger: logger);
                            
                        var phone = HELPERS.ValidationHelper.GetValidatedInput<string>(
                            infoMessage: S_MESSAGES.PhoneInfoMessage,
                            errorMessage: S_MESSAGES.PhoneErrorMessage, 
                            logger: logger);

                        var classId = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: S_MESSAGES.ClassIdInfoMessage,
                            errorMessage: S_MESSAGES.ClassIdErrorMessage, 
                            logger: logger);

                        var isActive = HELPERS.ValidationHelper.GetValidatedInput<bool>(
                            infoMessage: S_MESSAGES.IsActiveInfoMessage,
                            errorMessage: S_MESSAGES.IsActiveErrorMessage, 
                            logger: logger);
                            
                        string? gender = HELPERS.ValidationHelper.GetNotValidatedInput(
                            infoMessage: S_MESSAGES.GenderInfoMessage,
                            logger: logger);
                            
                        string? dateOfBirth = HELPERS.ValidationHelper.GetNotValidatedInput(
                            infoMessage: S_MESSAGES.DateOfBirthInfoMessage,
                            logger: logger);
                            
                        #endregion
                            
                        try
                        {
                            insertService.InsertStudents(
                                studentCode: studentCode,
                                fullName: fullName,
                                email: email,
                                phone: phone,
                                classId: classId,
                                isActive: isActive,
                                gender: gender,
                                dateOfBirth: dateOfBirth);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.StudentsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.StudentsMessage + ex.Message);
                        }
                        
                        Console.WriteLine(S_MESSAGES.EndMessage);
                        logger.Log(C_MESSAGES.EndMessage);

                        Console.ReadLine();
                        
                        break;
                    }
                case "7":
                    {
                        #region Log
                        
                        logger.Log(PI_MESSAGES.TeachersSubjectsMessage);

                        Console.Clear();

                        Console.WriteLine(TSJ_MESSAGES.StartMessage);
                        logger.Log(TSJ_MESSAGES.StartMessage);
                        
                        #endregion

                        #region Parameters
                        
                        var teacherId = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: TSJ_MESSAGES.TeacherIdInfoMessage,
                            errorMessage: TSJ_MESSAGES.TeacherIdErrorMessage, 
                            logger: logger);

                        var subjectId = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: TSJ_MESSAGES.SubjectIdInfoMessage,
                            errorMessage: TSJ_MESSAGES.SubjectIdErrorMessage, 
                            logger: logger);
                        
                        #endregion
                            
                        try
                        {
                            insertService.InsertTeachersSubjects(
                                teacherId: teacherId,
                                subjectId: subjectId);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.TeachersSubjectsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.TeachersSubjectsMessage + ex.Message);
                        }
                        
                        Console.WriteLine(TSJ_MESSAGES.EndMessage);
                        logger.Log(C_MESSAGES.EndMessage);

                        Console.ReadLine();
                        
                        break;
                    }
                case "8":
                    {
                        #region Log
                        
                        logger.Log(PI_MESSAGES.ClassesSubjectsMessage);

                        Console.Clear();

                        Console.WriteLine(CSJ_MESSAGES.StartMessage);
                        logger.Log(CSJ_MESSAGES.StartMessage);
                        
                        #endregion

                        #region Parameters
                        
                        var classId = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: CSJ_MESSAGES.ClassIdInfoMessage,
                            errorMessage: CSJ_MESSAGES.ClassIdErrorMessage, 
                            logger: logger);

                        var subjectId = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: CSJ_MESSAGES.SubjectIdInfoMessage,
                            errorMessage: CSJ_MESSAGES.SubjectIdErrorMessage, 
                            logger: logger);
                        
                        #endregion
                        
                        try
                        {
                            insertService.InsertClassesSubjects(
                                classId: classId,
                                subjectId: subjectId);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.ClassesSubjectsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.ClassesSubjectsMessage + ex.Message);
                        }
                        
                        Console.WriteLine(CSJ_MESSAGES.EndMessage);
                        logger.Log(C_MESSAGES.EndMessage);

                        Console.ReadLine();
                        
                        break;
                    }
                case "9":
                    {
                        #region Log
                        
                        logger.Log(PI_MESSAGES.StudentsParentsMessage);

                        Console.Clear();

                        Console.WriteLine(SP_MESSAGES.StartMessage);
                        logger.Log(SP_MESSAGES.StartMessage);
                        
                        #endregion
                        
                        #region Parameters
                            
                        var studentId = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: SP_MESSAGES.StudentIdInfoMessage,
                            errorMessage: SP_MESSAGES.StudentIdErrorMessage, 
                            logger: logger);

                        var parentId = HELPERS.ValidationHelper.GetValidatedInput<int>(
                            infoMessage: SP_MESSAGES.ParentIdInfoMessage,
                            errorMessage: SP_MESSAGES.ParentIdErrorMessage, 
                            logger: logger);
                        
                        #endregion
                        
                        try
                        {
                            insertService.InsertStudentsParents(
                                studentId: studentId,
                                parentId: parentId);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(PE_MESSAGES.StudentsParentsMessage + ex.Message);
                            logger.Log(PE_MESSAGES.StudentsParentsMessage + ex.Message);
                        }
                        
                        Console.WriteLine(SP_MESSAGES.EndMessage);
                        logger.Log(C_MESSAGES.EndMessage);

                        Console.ReadLine();
                        
                        break;
                    }
                case "10":
                    {
                        while (true)
                        {
                            Console.Clear();
                            
                            HELPERS.MenuHelper.ShowFunctionalityMenu();

                            string? functionalityChoice = Console.ReadLine();

                            if (string.IsNullOrEmpty(functionalityChoice))
                            {
                                return;
                            }

                            switch (functionalityChoice)
                            {
                                case "1":
                                    {
                                        try
                                        {
                                            selectService.GetStudentsNames();
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "2":
                                    {
                                        try
                                        {
                                            selectService.GetTeachersNamesAndSubject();
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "3":
                                    {
                                        try
                                        {
                                            selectService.GetClassesAndTeacher();
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "4":
                                    {
                                        try
                                        {
                                            selectService.GetSubjectsWithTeacherCount();
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "5":
                                    {
                                        try
                                        {
                                            selectService.GetClassroomsOrderedByFloor();
                                        }
                                        catch (Exception ex)
                                        {

                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "6":
                                    {
                                        try
                                        {
                                            selectService.GetStudentsByClasses();
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "7":
                                    {
                                        #region Parameters
                                        
                                        var classNumber = HELPERS.ValidationHelper.GetValidatedInput<int>(
                                            infoMessage: SI_MESSAGES.NumberInfoMessage,
                                            errorMessage: SI_MESSAGES.NumberErrorMessage, 
                                            logger: logger);
                                        
                                        var classLetter = HELPERS.ValidationHelper.GetValidatedInput<char>(
                                            infoMessage: SI_MESSAGES.LetterInfoMessage,
                                            errorMessage: SI_MESSAGES.LetterErrorMessage, 
                                            logger: logger);

                                        #endregion

                                        try
                                        {
                                            selectService.GetAllStudentsByClass(
                                                classNumber: classNumber,
                                                classLetter: classLetter);
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "8":
                                    {
                                        #region Parameters
                                        
                                        var dateOfBirth = HELPERS.ValidationHelper.GetValidatedInput<string>(
                                            infoMessage: SI_MESSAGES.DateOfBirthInfoMessage,
                                            errorMessage: SI_MESSAGES.DateOfBirthErrorMessage, 
                                            logger: logger);

                                        #endregion

                                        try
                                        {
                                            selectService.GetStudentsWithSpecificBirthday(
                                                dateOfBirth: dateOfBirth);
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "9":
                                    {
                                        #region Parameters
                                        
                                        var studentName = HELPERS.ValidationHelper.GetValidatedInput<string>(
                                            infoMessage: SI_MESSAGES.FullNameInfoMessage,
                                            errorMessage: SI_MESSAGES.FullNameErrorMessage, 
                                            logger: logger);

                                        #endregion

                                        try
                                        {
                                            selectService.GetCountOfSubjectsByStudent(
                                                studentName: studentName);
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "10":
                                    {
                                        #region Parameters
                                        
                                        var studentName = HELPERS.ValidationHelper.GetValidatedInput<string>(
                                            infoMessage: SI_MESSAGES.FullNameInfoMessage,
                                            errorMessage: SI_MESSAGES.FullNameErrorMessage, 
                                            logger: logger);

                                        #endregion

                                        try
                                        {
                                            selectService.GetTeachersAndSubjectsByStudent(
                                                studentName: studentName);
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

                                        Console.ReadLine();

                                        break;
                                    }
                                case "11":
                                    {
                                        #region Parameters
                                        
                                        var parentEmail = HELPERS.ValidationHelper.GetValidatedInput<string>(
                                            infoMessage: SI_MESSAGES.EmailInfoMessage,
                                            errorMessage: SI_MESSAGES.EmailErrorMessage, 
                                            logger: logger);

                                        #endregion

                                        try
                                        {
                                            selectService.GetClassByParentEmail(
                                                parentEmail: parentEmail);
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }

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

            //TODO: Try catch this
            logger.SaveLog();
        }
    }
}