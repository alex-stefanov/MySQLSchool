namespace MySQLSchool.Common.Messages.InsertMessages;

/// <summary>
/// Provides predefined messages for inserting classroom data.
/// </summary>
public static class ClassroomsMessages
{
    /// <summary>
    /// Message prompting the user to start entering classroom data.
    /// </summary>
    public const string StartMessage = "Попълнете данни за класната стая:";

    /// <summary>
    /// Message requesting the floor information for the classroom.
    /// </summary>
    public const string FloorInfoMessage = "Етаж: ";

    /// <summary>
    /// Error message indicating that the floor information for the classroom is required.
    /// </summary>
    public const string FloorErrorMessage = "Етажът на стаята е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Message requesting the capacity information for the classroom.
    /// </summary>
    public const string CapacityInfoMessage = "Капацитет: ";

    /// <summary>
    /// Error message indicating that the capacity information for the classroom is required.
    /// </summary>
    public const string CapacityErrorMessage = "Капацитетът на стаята е задължителен. Моля, въведете отново.";

    /// <summary>
    /// Message requesting the description information for the classroom.
    /// </summary>
    public const string DescriptionInfoMessage = "Описание: ";

    /// <summary>
    /// Error message indicating that the description for the classroom is required.
    /// </summary>
    public const string DescriptionErrorMessage = "Описанието на стаята е задължително. Моля, въведете отново.";

    /// <summary>
    /// Message confirming that the classroom data has been successfully recorded.
    /// </summary>
    public const string EndMessage = "Данните за класната стая са успешно записани.";
}