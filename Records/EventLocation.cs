namespace EventPlanningSystem.Records;

/// <summary>
/// Represents the location details for an event.
/// </summary>
/// <param name="Venue">The name of the venue where the event is held.</param>
/// <param name="Address">The address of the event location.</param>
/// <param name="Capacity">The maximum number of attendees the venue can accommodate.</param>
public record EventLocation(string Venue, string Address, int Capacity);
