using System.ComponentModel.Design;

string fruit = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double quantity=double.Parse(Console.ReadLine());

double calculation = 0;

if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
{
    switch (fruit)
    {
        case "banana":
            calculation = quantity * 2.50;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "apple":
            calculation = quantity * 1.20;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "orange":
            calculation = quantity * 0.85;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "grapefruit":
            calculation = quantity * 1.45;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "kiwi":
            calculation = quantity * 2.70;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "pineapple":
            calculation = quantity * 5.50;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "grapes":
            calculation = quantity * 3.85;
            Console.WriteLine($"{calculation:F2}");
            break;
        default:
            Console.WriteLine("error");
            break;
    }
      
}




else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
{
    switch (fruit)
    {
        case "banana":
            calculation = quantity * 2.70;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "apple":
            calculation = quantity * 1.25;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "orange":
            calculation = quantity * 0.90;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "grapefruit":
            calculation = quantity * 1.60;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "kiwi":
            calculation = quantity * 3.00;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "pineapple":
            calculation = quantity * 5.60;
            Console.WriteLine($"{calculation:F2}");
            break;
        case "grapes":
            calculation = quantity * 4.20;
            Console.WriteLine($"{calculation:F2}");
            break;
        default:
            Console.WriteLine("error");
            break;
    }
}

else
{
    Console.WriteLine("error"); 
}