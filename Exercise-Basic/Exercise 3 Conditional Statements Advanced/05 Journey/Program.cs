double budget = double.Parse(Console.ReadLine());
string seaseon = Console.ReadLine();

string vidPocivkaCamp = "";
string vidPocivkaHotel = "";


if (budget <= 100)

{
    switch (seaseon)
    {
        case "summer":
            budget *= 0.3;
            vidPocivkaCamp = "Camp";
            Console.WriteLine($"Somewhere in Bulgaria");
            Console.WriteLine($"{vidPocivkaCamp} - {budget:F2}");
            break;
        case "winter":
            budget *= 0.7;
            vidPocivkaHotel = "Hotel";
            Console.WriteLine($"Somewhere in Bulgaria");
            Console.WriteLine($"{vidPocivkaHotel} - {budget:F2}");
            break;
    }
}
if (budget <= 1000 && budget >= 100)
{
    switch (seaseon)
    {
        case "summer":
            budget *= 0.4;
            vidPocivkaCamp = "Camp";
            Console.WriteLine($"Somewhere in Balkans");
            Console.WriteLine($"{vidPocivkaCamp} - {budget:F2}");
            break;
        case "winter":
            budget *= 0.8;
            vidPocivkaHotel = "Hotel";
            Console.WriteLine($"Somewhere in Balkans");
            Console.WriteLine($"{vidPocivkaHotel} - {budget:F2}");
            break;
    }
}
if (budget >= 1000)
{
    switch (seaseon)
    {
        case "summer":
            budget *= 0.9;
            vidPocivkaHotel = "Hotel";
            Console.WriteLine($"Somewhere in Europe");
            Console.WriteLine($"{vidPocivkaHotel} - {budget:F2}");
            break;
        case "winter":
            budget *= 0.9;
            vidPocivkaHotel = "Hotel";
            Console.WriteLine($"Somewhere in Europe");
            Console.WriteLine($"{vidPocivkaHotel} - {budget:F2}");
            break;
    }
}