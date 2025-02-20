using MI_MESSAGES = MySQLSchool.Common.Messages.MenuMessages.MainPanelMessages.InfoMessages;
using FI_MESSAGES = MySQLSchool.Common.Messages.MenuMessages.FunctionalityPanelMessages.InfoMessages;

namespace MySQLSchool.Helpers;

public static class MenuHelper
{
    public static void ShowMainMenu()
    {
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
    }

    public static void ShowFunctionalityMenu()
    {
        Console.WriteLine(FI_MESSAGES.HeaderMessage);
        Console.WriteLine(FI_MESSAGES.AllStudentsFromClass11BOptionMessage);
        Console.WriteLine(FI_MESSAGES.TeachersAndSubjectsGroupedBySubjectOptionMessage);
        Console.WriteLine(FI_MESSAGES.ClassesByTeacherIdOptionMessage);
        Console.WriteLine(FI_MESSAGES.SubjectsWithTeacherCountOptionMessage);
        Console.WriteLine(FI_MESSAGES.ClassroomsOrderedByFloorOptionMessage);
        Console.WriteLine(FI_MESSAGES.StudentsGroupedByClassOptionMessage);
        Console.WriteLine(FI_MESSAGES.StudentsFromSelectedClassOptionMessage);
        Console.WriteLine(FI_MESSAGES.StudentsWithSpecificBirthdayOptionMessage);
        Console.WriteLine(FI_MESSAGES.CountOfSubjectsByStudentOptionMessage);
        Console.WriteLine(FI_MESSAGES.TeachersAndSubjectsByStudentOptionMessage);
        Console.WriteLine(FI_MESSAGES.ClassesByParentEmailOptionMessage);
        Console.WriteLine(FI_MESSAGES.ExitOptionMessage);
    }
}