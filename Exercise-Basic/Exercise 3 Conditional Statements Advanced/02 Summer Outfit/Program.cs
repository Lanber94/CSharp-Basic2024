//int degree = int.Parse(Console.ReadLine());
//string timeOfDay = Console.ReadLine();

//if (degree >= 10 && degree <= 18)
//{
//    switch (timeOfDay)
//    {
//        case "Morning":
//            Console.WriteLine($"It's {degree} degrees, get your {"Sweatshirt"} and {"Sneakers"}.");
//            break;
//        case "Afternoon":
//            Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
//            break;
//        case "Evening":
//            Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
//            break ;
//    }    
//}

//else if ()
//{
//    switch (timeOfDay)
//    {
//        case "Morning":
//            Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
//            break;
//        case "Afternoon":
//            Console.WriteLine($"It's {degree} degrees, get your {"T-Shirt"} and {"Sandals"}.");
//            break;
//        case "Evening":
//            Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
//            break;
//    }
//}

//else if (degree >= 25)
//{
//    switch (timeOfDay)
//    {
//        case "Morning":
//            Console.WriteLine($"It's {degree} degrees, get your {"T-Shirt"} and {"Sandals"}.");
//            break;
//        case "Afternoon":
//            Console.WriteLine($"It's {degree} degrees, get your {"Swim Suit"} and {"Barefoot"}.");
//            break;
//        case "Evening":
//            Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
//            break;
//    }
//}









int degrees = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();

string outfit = "";
string shoes = "";

if (degrees >= 10 && degrees <= 18)
{
    if (timeOfDay == "Morning")
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}


else if (degrees >= 18 && degrees <= 24)
{
    if (timeOfDay == "Morning")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    if (timeOfDay == "Afternoon")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    if (timeOfDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }

}

else if (degrees >= 25)
{
    if (timeOfDay == "Morning")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    if (timeOfDay == "Afternoon")
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    if (timeOfDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");




