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
        
        L_INTERFACES.ILogger logger = new LOGGERS.TextLogger("log.txt");

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

                            switch (functionalityChoice)
                            {
                                case "1":
                                    {
                                        break;
                                    }
                                case "2":
                                    {
                                        break;
                                    }
                                case "3":
                                    {
                                        break;
                                    }
                                case "4":
                                    {
                                        break;
                                    }
                                case "5":
                                    {
                                        break;
                                    }
                                case "6":
                                    {
                                        break;
                                    }
                                case "7":
                                    {
                                        break;
                                    }
                                case "8":
                                    {
                                        break;
                                    }
                                case "9":
                                    {
                                        break;
                                    }
                                case "10":
                                    {
                                        break;
                                    }
                                case "11":
                                    {
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