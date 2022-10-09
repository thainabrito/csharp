using System.Globalization;
namespace calendar_events;

public class Event : IEvent
{
    public string? Title { get; set; }
    public DateTime EventDate { get; set; }
    public string? Description { get; set; }


    public Event(string title, string date, string description)
    {
        Title = title;
        EventDate = DateTime.Parse(date, CultureInfo.InvariantCulture);
        Description = description;
    }

    public Event(string title, string date)
    {
        Title = title;
        EventDate = DateTime.Parse(date, CultureInfo.InvariantCulture);
    }

    public void DelayDate(int days) => EventDate = EventDate.AddDays(days);

    public string PrintEvent(string format)
    {
        var basePrint = $"Evento = {Title}\nDate = {EventDate.ToString("d", DateTimeFormatInfo.InvariantInfo)}\n";
        if (format == "normal") return basePrint;
        return basePrint + $"Description = {Description}";
    }
}
