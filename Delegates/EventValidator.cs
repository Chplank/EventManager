
using EventPlanningSystem.Records;

namespace EventPlanningSystem.Delegates;

/// <summary>
/// Delegate for validating events based on specific criteria.
/// </summary>
/// <param name="evt">The event to validate.</param>
/// <returns>
/// A boolean value indicating whether the event passed the validation criteria.
/// </returns>
public delegate bool EventValidator(Event evt);
