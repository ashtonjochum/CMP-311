//interfaces
public interface IGraduation
{
    public void PrintGraduationInfo();
}

public interface IRetirement
{
    public void PrintRetirementInfo();
}


//classes
public class EventInfo
{
    private string eventId;
    private string eventDescription;
    private double eventCost;

    public EventInfo(string newEventId, string newEventDescription, double newEventCost)
    {
        eventId = newEventId;
        eventDescription = newEventDescription;
        eventCost = newEventCost;
    }

    public string EventId
    {
        get { return eventId; }
        set { eventId = value; }
    }
    public string EventDescription
    {
        get { return eventDescription; }
        set { eventDescription = value; }
    }
    public double EventCost
    {
        get { return eventCost; }
        set { eventCost = value; }
    }

    public override string ToString()
    {
        return "Id: " + eventId.ToString() + " " + "Description: " + eventDescription.ToString() + " " + "Cost: " + eventCost.ToString();
    }
}

public class Event : IGraduation, IRetirement
{
    private EventInfo theEvent;

    public Event(string newEventId, string newEventDescription, double newEventCost)
    {
        theEvent = new EventInfo(newEventId, newEventDescription, newEventCost);
    }

    public void PrintGraduationInfo()
    {
        Console.WriteLine("Graduation Party Information:" + theEvent.ToString());
    }

    public void PrintRetirementInfo()
    {
        Console.WriteLine("Retirement Party Information:" + theEvent.ToString());
    }

    public void PrintEventCost()
    {
        Console.WriteLine("Event Cost: " + theEvent.EventCost);
    }
    public override string ToString()
    {
        return theEvent.ToString();
    }
}



public class Program
{
    static void Main(string[] args)
    {
        string gradDescription = "Little Jimmy is graduating High School this weekend. Come out to the barbeque afterwords to congradualte him on his success.";
        IGraduation graduationEvent = new Event("Jimmy's Graduation", gradDescription, 500.67);
        string retirementDescription = "Jimothy is finally out the door from Ol Bob's lumber yard after 79 years of hard work. Come on down to the bowling alley after work on Friday and enjoy some pizza and wings.";
        IRetirement retirementEvent = new Event("Jimothy's Retirement", retirementDescription, 355.65);
        Event myEvent = new Event("Test Event", "This is a test of the Event class", 1000000.00);

        graduationEvent.PrintGraduationInfo();
        retirementEvent.PrintRetirementInfo();
        myEvent.PrintEventCost();
        myEvent.ToString();

        Console.WriteLine("Graduation: " + graduationEvent + "\nRetirement: " + retirementEvent + "\nTest: " + myEvent);
    }
}