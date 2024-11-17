namespace EventPlanningSystem.Records;

/// <summary>
/// Represents a speaker participating in an event.
/// </summary>
/// <param name="name">The name of the speaker.</param>
/// <param name="Bio">A brief biography of the speaker.</param>
/// <param name="Topic">The topic the speaker will discuss at the event.</param>
public record EventSpeaker(string name, string Bio, string Topic);