namespace EventAppWithDI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Wedding Event with late fee
            IEvent currentEvent1 = new WeddingEvent("1", "Wedding", 1000);
            EventService eventService1 = new EventService(currentEvent1);
            Console.WriteLine(currentEvent1);
            Console.WriteLine("Cost Modifier: Late (*110%)");
            Console.WriteLine("Modified Cost: $" + eventService1.modifiedCost("L"));

            //Graduation Event with employee discount
            IEvent currentEvent2 = new GraduationEvent("2", "Graduation", 500);
            EventService eventService2 = new EventService(currentEvent2);
            Console.WriteLine(currentEvent2);
            Console.WriteLine("Cost Modifier: Employee Discount (*75%)");
            Console.WriteLine("Modified Cost: $" + eventService2.modifiedCost("e"));

            //Wedding Event with base discount
            IEvent currentEvent3 = new WeddingEvent("3", "Wedding", 1000);
            EventService eventService3 = new EventService(currentEvent3);
            Console.WriteLine(currentEvent3);
            Console.WriteLine("Cost Modifier: Discount (*90%)");
            Console.WriteLine("Modified Cost: $" + eventService3.modifiedCost("d"));

            //Graduation Event with free discount
            IEvent currentEvent4 = new GraduationEvent("4", "Graduation", 500);
            EventService eventService4 = new EventService(currentEvent4);
            Console.WriteLine(currentEvent4);
            Console.WriteLine("Cost Modifier: Free (*0%)");
            Console.WriteLine("Modified Cost: $" + eventService4.modifiedCost("F"));

            //Wedding Event with no modifer
            IEvent currentEvent5 = new WeddingEvent("5", "Wedding", 1000);
            EventService eventService5 = new EventService(currentEvent5);
            Console.WriteLine(currentEvent5);
            Console.WriteLine("Cost Modifier: No modifier");
            Console.WriteLine("Modified Cost: $" + eventService5.modifiedCost("No modifer"));
        }
    }
}