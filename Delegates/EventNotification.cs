using EventPlanningSystem.Records;

namespace EventPlanningSystem.Delegates;

/// <summary>
/// Delegate for notifying about event-related actions.
/// </summary>
/// <param name="evt">The event that triggered the notification.</param>
/// <param name="message">The message describing the notification details.</param>
public delegate void EventNotification(Event evt, string message);
