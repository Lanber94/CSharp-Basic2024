int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int count = int.Parse(Console.ReadLine());


double totalSum = 0;


if (count <= 6)
{
    switch (season)
    {
        case "Autumn":
            totalSum = 4200 * 0.90;


            break;
        case "Spring":
            totalSum = 3000 * 0.90;
            if (count % 2 == 0)
            {
                totalSum *= 0.95;
            }
            break;
        case "Summer":
            totalSum = 4200 * 0.90;
            if (count % 2 == 0)
            {
                totalSum *= 0.95;
            }
            break;
        case "Winter":
            totalSum = 2600 * 0.90;
            if (count % 2 == 0)
            {
                totalSum *= 0.95;
            }
            break;

    }
}
if (count >= 7 && count <= 11)
{
    switch (season)
    {
        case "Autumn":
            totalSum = 4200 * 0.85;


            break;
        case "Spring":
            totalSum = 3000 * 0.85;
            if (count % 2 == 0)
            {
                totalSum *= 0.95;
            }
            break;
        case "Summer":
            totalSum = 4200 * 0.85;
            if (count % 2 == 0)
            {
                totalSum *= 0.95;
            }
            break;
        case "Winter":
            totalSum = 2600 * 0.85;
            if (count % 2 == 0)
            {
                totalSum *= 0.95;
            }
            break;

    }
}
if (count >= 12)
{
    switch (season)
    {
        case "Autumn":
            totalSum = 4200 * 0.75;


            break;
        case "Spring":
            totalSum = 3000 * 0.75;
            if (count % 2 == 0)
            {
                totalSum *= 0.95;
            }
            break;
        case "Summer":
            totalSum = 4200 * 0.75;
            if (count % 2 == 0)
            {
                totalSum *= 0.95;
            }
            break;
        case "Winter":
            if (count % 2 == 0)
            {
                totalSum *= 0.95;
            }
            totalSum = 2600 * 0.75;
            break;

    }
}

if (budget >= totalSum)
    Console.WriteLine($"Yes! You have {budget - totalSum:F2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {totalSum - budget:F2} leva.");