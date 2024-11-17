using EventPlanningSystem.Records;

namespace EventPlanningSystem.Delegates;

/// <summary>
/// Delegate for calculating the total price of tickets for an event.
/// </summary>
/// <param name="evt">The event for which the price is being calculated.</param>
/// <param name="quantity">The number of tickets being purchased.</param>
/// <returns>
/// The total price for the specified number of tickets.
/// </returns>
public delegate decimal PriceCalculator(Event evt, int quantity);