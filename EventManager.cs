using EventPlanningSystem.Delegates;
using EventPlanningSystem.Records;

namespace EventPlanningSystem;

/// <summary>
/// Manages events, including validation, notifications, and price calculation.
/// </summary>
public class EventManager
{
    /// <summary>
    /// Internal storage for events. (Event List)
    /// </summary>
    private List<Event> _events = new();

    /// <summary>
    /// Event triggered when a new event is added successfully.
    /// Subscribers receive the event details and a success message.
    /// </summary>
    public event EventNotification OnEventAdded;

    /// <summary>
    /// List of validation rules for verifying event properties before adding.
    /// </summary>
    private List<EventValidator> _validationRules = new();

    /// <summary>
    /// Delegate for calculating event ticket prices.
    /// </summary>
    private PriceCalculator _priceCalculator;

    /// <summary>
    /// Adds a new event to the system after validating it against all registered rules.
    /// Triggers the <see cref="OnEventAdded"/> event if successful.
    /// </summary>
    /// <param name="e">The event to be added.</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown when one or more validation rules fail.
    /// </exception>
    public void AddEvent(Event e)
    {

        if (_validationRules.All(rule => rule(e)))
        {
            _events.Add(e);
            OnEventAdded?.Invoke(e, "Event successfully added!");
        }
        else
        {
            throw new InvalidOperationException("Event validation failed!");
        }

    }

    /// <summary>
    /// Registers a new validation rule for verifying events.
    /// </summary>
    /// <param name="validator">The validation rule to be added.</param>
    public void AddValidationRule(EventValidator validator) => _validationRules.Add(validator);

    /// <summary>
    /// Sets the delegate for calculating ticket prices based on event details and quantity.
    /// </summary>
    /// <param name="calculator">The price calculator delegate.</param>
    public void SetPriceCalculator(PriceCalculator calculator) => _priceCalculator = calculator;

    /// <summary>
    /// Retrieves all events currently managed by the system.
    /// </summary>
    /// <returns>A list of <see cref="Event"/> objects.</returns>
    public List<Event> GetEvents() => _events;
}
