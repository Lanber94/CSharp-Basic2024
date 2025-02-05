int timeOfDay = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

if (timeOfDay >= 10 && timeOfDay <= 18)
{
    switch (dayOfWeek)
    {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
        case "Saturday":
            Console.WriteLine("open");
            break;
        default:
        case "Sunday":
            Console.WriteLine("closed");
            break;
    }
}
else if (timeOfDay <= 10 || timeOfDay >= 18)
{
    switch (dayOfWeek)
    {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
        case "Saturday":
        case "Sunday":
            Console.WriteLine("closed");
            break;
    }
}