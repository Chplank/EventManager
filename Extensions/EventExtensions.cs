using EventPlanningSystem.Records;

namespace EventPlanningSystem.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Event"/> class.
/// </summary>
public static class EventExtensions
{
    /// <summary>
    /// Determines whether an event is sold out based on its capacity.
    /// </summary>
    /// <param name="evt">The event to check.</param>
    /// <returns>
    /// <c>true</c> if the event is sold out (i.e., the number of speakers equals or exceeds the venue's capacity); otherwise, <c>false</c>.
    /// </returns>
    public static bool IsSoldOut(this Event evt) 
        => evt.Location.Capacity <= evt.Speakers.Count;

    /// <summary>
    /// Calculates the duration of an event in hours based on the provided end time.
    /// </summary>
    /// <param name="evt">The event whose duration is being calculated.</param>
    /// <param name="endTime">The end time of the event.</param>
    /// <returns>
    /// The duration of the event in hours as a <see cref="double"/>.
    /// </returns>
    public static double GetDurationInHours(this Event evt, DateTime endTime)
        => (endTime - evt.Date).TotalHours;

    /// <summary>
    /// Formats the details of an event into a readable string.
    /// </summary>
    /// <param name="evt">The event to format.</param>
    /// <returns>
    /// A string containing the event's title, date, venue, speakers, and ticket price.
    /// </returns>
    public static string ToDetailedString(this Event evt)
 => $"Event: {evt.Title}, Date: {evt.Date}, Venue: {evt.Location.Venue}, " +
           $"Speakers: {string.Join(", ", evt.Speakers.Select(s => s.name))}, Price: ${evt.TicketPrice:F2}";
}
