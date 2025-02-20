namespace MySQLSchool.Common.Messages.MenuMessages.FunctionalityPanelMessages;

/// <summary>
/// Provides predefined informational messages for interacting with a user interface.
/// </summary>
public static class InfoMessages
{
    /// <summary>
    /// Header message prompting the user to select a functionality.
    /// </summary>
    public const string HeaderMessage = "Изведи:";
    
    /// <summary>
    /// Message for showing the option to get the names of all students from class 11б.
    /// </summary>
    public const string AllStudentsFromClass11BOptionMessage = "1. Имената на всички ученици от 11б";

    /// <summary>
    /// Message for showing the option to get the names of all teachers and their subjects, grouped by subject.
    /// </summary>
    public const string TeachersAndSubjectsGroupedBySubjectOptionMessage = "2. Имената на всички учители и предмета, по който преподава, групирани по предмети";

    /// <summary>
    /// Message for showing the option to get all classes of a specific teacher by their ID.
    /// </summary>
    public const string ClassesByTeacherIdOptionMessage = "3. Всички класове на даден учител по идентификатора му";

    /// <summary>
    /// Message for showing the option to get all subjects and the count of teachers teaching each subject.
    /// </summary>
    public const string SubjectsWithTeacherCountOptionMessage = "4. Всички учебни предмети и броят на преподаващите учители";

    /// <summary>
    /// Message for showing the option to get the IDs and capacities of classrooms with a capacity greater than 26, ordered by floor in ascending order.
    /// </summary>
    public const string ClassroomsOrderedByFloorOptionMessage = "5. Идентификатора и капацитета на класните стаи с капацитет повече от 26, подредени във възходящ ред по етажи";

    /// <summary>
    /// Message for showing the option to get the names and classes of all students grouped by classes in ascending order.
    /// </summary>
    public const string StudentsGroupedByClassOptionMessage = "6. Имената и класът на всички ученици групирани по класове във възходящ ред на класовете";

    /// <summary>
    /// Message for showing the option to get the names of students from a selected class and section.
    /// </summary>
    public const string StudentsFromSelectedClassOptionMessage = "7. Имената на ученици от избран клас и паралелка";

    /// <summary>
    /// Message for showing the option to get the names of all students born on a specific date.
    /// </summary>
    public const string StudentsWithSpecificBirthdayOptionMessage = "8. Имената на всички ученици родени на специфична дата";

    /// <summary>
    /// Message for showing the option to get the number of subjects for a specific student by their name.
    /// </summary>
    public const string CountOfSubjectsByStudentOptionMessage = "9. Броят на предметите на съответен ученик по името му";

    /// <summary>
    /// Message for showing the option to get the names of all teachers and the subjects they teach for a specific student by their name.
    /// </summary>
    public const string TeachersAndSubjectsByStudentOptionMessage = "10. Имената на всички учители и предметите, по които преподават на съответен ученик по името му";

    /// <summary>
    /// Message for showing the option to get the classes in which the children of a specific parent study based on their email.
    /// </summary>
    public const string ClassesByParentEmailOptionMessage = "11. Класовете, в които учат децата на специфичен родител по негов имейл";

    /// <summary>
    /// Message for showing the option to exit the menu.
    /// </summary>
    public const string ExitOptionMessage = "0. Изход";
    
    /// <summary>
    /// Message to navigate the user back to the previous menu or option.
    /// </summary>
    public const string BackMessage = "Назад капитане!";

    /// <summary>
    /// Error message indicating an invalid input choice.
    /// </summary>
    public const string InvаlidInputMessage = "Невалиден избор. Опитайте отново.";
}