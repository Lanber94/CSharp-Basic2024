using System;

//string nameCity = Console.ReadLine();
//double volumeSales = double.Parse(Console.ReadLine());

//double calculation = 0;

//if (volumeSales >= 0 && volumeSales <= 500)
//{
//    switch (nameCity)
//    {
//        case "Sofia":
//            calculation = (volumeSales / 100) * 5;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        case "Varna":
//            calculation = (volumeSales / 100) * 4.5;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        case "Plovdiv":
//            calculation = (volumeSales / 100) * 5.5;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        default:
//            Console.WriteLine("error");
//            break;


//    }

//}

//else if (volumeSales > 500 && volumeSales <= 1000)
//{
//    switch (nameCity)
//    {
//        case "Sofia":
//            calculation = (volumeSales / 100) * 7;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        case "Varna":
//            calculation = (volumeSales / 100) * 7.5;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        case "Plovdiv":
//            calculation = (volumeSales / 100) * 8;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        default:
//            Console.WriteLine("error");
//            break;


//    }
//    Console.WriteLine($"{calculation:F2}");
//}
//else if (volumeSales > 1000 && volumeSales <= 10000)
//{
//    switch (nameCity)
//    {
//        case "Sofia":
//            calculation = (volumeSales / 100) * 8;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        case "Varna":
//            calculation = (volumeSales / 100) * 10;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        case "Plovdiv":
//            calculation = (volumeSales / 100) * 12;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        default:
//            Console.WriteLine("error");
//            break;


//    }
//    Console.WriteLine($"{calculation:F2}");
//}
//else if (volumeSales > 10000)
//{
//    switch (nameCity)
//    {
//        case "Sofia":
//            calculation = (volumeSales / 100) * 12;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        case "Varna":
//            calculation = (volumeSales / 100) * 13;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        case "Plovdiv":
//            calculation = (volumeSales / 100) * 14.5;
//            Console.WriteLine($"{calculation:F2}");
//            break;
//        default:
//            Console.WriteLine("error");
//            break;


//    }


//}

//else
//    Console.WriteLine("error");


string city = Console.ReadLine();
double s = double.Parse(Console.ReadLine());
double commision = 0;

bool invalidInput = false;

if (s >= 0 && s <= 500)
{
    switch (city)
    {
        case "Sofia":
            commision = s * 0.05;
            break;
        case "Varna":
            commision = s * 0.045;
            break;
        case "Plovdiv":
            commision = s * 0.055;
            break;
        default:
            invalidInput = true;
            break;
    }
}
else if (s > 500 && s <= 1000)
{
    switch (city)
    {
        case "Sofia":
            commision = s * 0.07;
            break;
        case "Varna":
            commision = s * 0.075;
            break;
        case "Plovdiv":
            commision = s * 0.08;
            break;
        default:
            invalidInput = true;
            break;
    }
}
else if (s > 1000 && s <= 10000)
{
    switch (city)
    {
        case "Sofia":
            commision = s * 0.08;
            break;
        case "Varna":
            commision = s * 0.10;
            break;
        case "Plovdiv":
            commision = s * 0.12;
            break;
        default:
            invalidInput = true;
            break;
    }
}
else if (s > 10000)
{
    switch (city)
    {
        case "Sofia":
            commision = s * 0.12;
            break;
        case "Varna":
            commision = s * 0.13;
            break;
        case "Plovdiv":
            commision = s * 0.145;
            break;
        default:
            invalidInput = true;
            break;
    }
}
else
{
    invalidInput = true;
}

if (invalidInput)
{
    Console.WriteLine("error");
}
else
{
    Console.WriteLine($"{commision:f2}");
}