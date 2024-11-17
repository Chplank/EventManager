using EventPlanningSystem.Records;
using EventPlanningSystem;
using EventPlanningSystem.Extensions;

// Example of how the completed implementation should work
var manager = new EventManager();

// Add validation rules using anonymous functions
manager.AddValidationRule(evt => evt.Date > DateTime.Now);
manager.AddValidationRule(evt => evt.TicketPrice > 0);

// Set price calculator using anonymous function
manager.SetPriceCalculator((evt, quantity) => {
    var basePrice = evt.TicketPrice * quantity;
    return quantity >= 5 ? basePrice * 0.9m : basePrice;
});

// Subscribe to event notifications using anonymous function
manager.OnEventAdded += (evt, message) =>
    Console.WriteLine($"New event added: {evt.Title} - {message}");

// Create and add an event
var location = new EventLocation("Tech Hub", "123 Main St", 100);
var speaker = new EventSpeaker("John Doe", "Tech Expert", "C# Modern Features");
var newEvent = new Event(
    "C# Workshop",
    DateTime.Now.AddDays(30),
    location,
    new List<EventSpeaker> { speaker },
    199.99m
);

manager.AddEvent(newEvent);

// Use extension methods
Console.WriteLine(newEvent.ToDetailedString());
Console.WriteLine($"Is sold out: {newEvent.IsSoldOut()}");