using COMMON = MySQLSchool.Common;
using DATA = MySQLSchool.Data;
using INTERFACES = MySQLSchool.Infrastructure.Interfaces;
using IMPLEMENTATIONS = MySQLSchool.Infrastructure.Implementation;

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

        bool isDatabaseCreated = COMMON.SchoolOptions.IsDatabaseCreated;

        if (!isDatabaseCreated)
        {
            INTERFACES.ICreateService createService = new IMPLEMENTATIONS.CreateService();

            #region Initializers

            try
            {
                createService.CreateParents();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateParents: {ex.Message}");
            }

            try
            {
                createService.CreateSubjects();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateSubjects: {ex.Message}");
            }

            try
            {
                createService.CreateTeachers();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateTeachers: {ex.Message}");
            }

            try
            {
                createService.CreateClassrooms();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateClassrooms: {ex.Message}");
            }

            try
            {
                createService.CreateClasses();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateClasses: {ex.Message}");
            }

            try
            {
                createService.CreateStudents();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateStudents: {ex.Message}");
            }

            try
            {
                createService.CreateTeachersSubjects();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateTeachersSubjects: {ex.Message}");
            }

            try
            {
                createService.CreateClassesSubjects();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateClassesSubjects: {ex.Message}");
            }

            try
            {
                createService.CreateStudentsParents();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateStudentsParents: {ex.Message}");
            }

            #endregion
        }

        while (true)
        {
            #region Menu Panel

            Console.Clear();
            Console.WriteLine("Изберете таблицата за попълване на данни:");
            Console.WriteLine("1. Родители (parents)");
            Console.WriteLine("2. Предмети (subjects)");
            Console.WriteLine("3. Учители (teachers)");
            Console.WriteLine("4. Класни стаи (classrooms)");
            Console.WriteLine("5. Класове (classes)");
            Console.WriteLine("6. Студенти (students)");
            Console.WriteLine("7. Учители и предмети (teachers_subjects)");
            Console.WriteLine("8. Класове и предмети (classes_subjects)");
            Console.WriteLine("9. Студенти и родители (students_parents)");
            Console.WriteLine("10.Функционалност (functionality)");
            Console.WriteLine("0. Изход");

            #endregion

            string? choice = Console.ReadLine();

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
                            populateService.PopulateParents();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error in PopulateParents: {ex.Message}");
                        }
                        break;
                    }
                case "2":
                    {
                        try
                        {
                            populateService.PopulateSubjects();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error in PopulateSubjects: {ex.Message}");
                        }
                        break;
                    }
                case "3":
                    {
                        try
                        {
                            populateService.PopulateTeachers();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error in PopulateTeachers: {ex.Message}");
                        }
                        break;
                    }
                case "4":
                    {
                        try
                        {
                            populateService.PopulateClassrooms();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error in PopulateClassrooms: {ex.Message}");
                        }
                        break;
                    }
                case "5":
                    {
                        try
                        {
                            populateService.PopulateClasses();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error in PopulateClasses: {ex.Message}");
                        }
                        break;
                    }
                case "6":
                    {
                        try
                        {
                            populateService.PopulateStudents();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error in PopulateStudents: {ex.Message}");
                        }
                        break;
                    }
                case "7":
                    {
                        try
                        {
                            populateService.PopulateTeachersSubjects();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error in PopulateTeachersSubjects: {ex.Message}");
                        }
                        break;
                    }
                case "8":
                    {
                        try
                        {
                            populateService.PopulateClassesSubjects();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error in PopulateClassesSubjects: {ex.Message}");
                        }
                        break;
                    }
                case "9":
                    {
                        try
                        {
                            populateService.PopulateStudentsParents();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error in PopulateStudentsParents: {ex.Message}");
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
                                        return;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Невалиден избор. Опитайте отново.");
                                        break;
                                    }
                            }
                        }
                    }
                case "0":
                    {
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Невалиден избор. Опитайте отново.");
                        break;
                    }
            }
        }
    }
}