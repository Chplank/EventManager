namespace EventPlanningSystem.Records;

/// <summary>
/// Represents an event with its associated details.
/// </summary>
/// <param name="Title">The title of the event.</param>
/// <param name="Date">The date and time of the event.</param>
/// <param name="Location">The location details of the event, including venue and capacity.</param>
/// <param name="Speakers">A list of speakers participating in the event.</param>
/// <param name="TicketPrice">The price of a single ticket for the event.</param>
public record Event(
    string Title,
    DateTime Date,
    EventLocation Location,
    List<EventSpeaker> Speakers,
    decimal TicketPrice
);