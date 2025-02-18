namespace MySQLSchool.Common.Messages.MenuMessages.MainPanelMessages;

/// <summary>
/// Provides predefined informational messages for interacting with a user interface.
/// </summary>
public static class InfoMessages
{
    /// <summary>
    /// Header message prompting the user to select a table for data entry.
    /// </summary>
    public const string HeaderMessage = "Изберете таблицата за попълване на данни:";

    /// <summary>
    /// Option message for selecting the "Parents" table.
    /// </summary>
    public const string ParentsOptionMessage = "1. Родители (parents)";

    /// <summary>
    /// Option message for selecting the "Subjects" table.
    /// </summary>
    public const string SubjectsOptionMessage = "2. Предмети (subjects)";

    /// <summary>
    /// Option message for selecting the "Teachers" table.
    /// </summary>
    public const string TeachersOptionMessage = "3. Учители (teachers)";

    /// <summary>
    /// Option message for selecting the "Classrooms" table.
    /// </summary>
    public const string ClassroomsOptionMessage = "4. Класни стаи (classrooms)";

    /// <summary>
    /// Option message for selecting the "Classes" table.
    /// </summary>
    public const string ClassesOptionMessage = "5. Класове (classes)";

    /// <summary>
    /// Option message for selecting the "Students" table.
    /// </summary>
    public const string StudentsOptionMessage = "6. Студенти (students)";

    /// <summary>
    /// Option message for selecting the "TeachersSubjects" table.
    /// </summary>
    public const string TeachersSubjectsOptionMessage = "7. Учители и предмети (teachers_subjects)";

    /// <summary>
    /// Option message for selecting the "ClassesSubjects" table.
    /// </summary>
    public const string ClassesSubjectsOptionMessage = "8. Класове и предмети (classes_subjects)";

    /// <summary>
    /// Option message for selecting the "StudentsParents" table.
    /// </summary>
    public const string StudentsParentsOptionMessage = "9. Студенти и родители (students_parents)";

    /// <summary>
    /// Option message for selecting the "Functionalities" table.
    /// </summary>
    public const string FunctionalitiesOptionMessage = "10.Функционалности (functionalities)";

    /// <summary>
    /// Option message for exiting the program.
    /// </summary>
    public const string ExitOptionMessage = "0. Изход (exit)";

    /// <summary>
    /// Message to bid farewell when exiting the program.
    /// </summary>
    public const string ByeMessage = "Ще се видим скоро капитане!";

    /// <summary>
    /// Error message indicating an invalid input choice.
    /// </summary>
    public const string InvаlidInputMessage = "Невалиден избор. Опитайте отново.";
}