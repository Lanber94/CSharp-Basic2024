//string typeFlowers = Console.ReadLine();
//int quantity = int.Parse(Console.ReadLine());
//int budget = int.Parse(Console.ReadLine());

//// Rose-5 , Dalia-3.80 , Lale-2.80 , Narcis-3 , Gladiola-2.50


//if (typeFlowers == "Roses" && quantity > 80)
//{
//    double needBudget = quantity * 5;
//    double discountBudget = needBudget * 0.9;

//    double leftBudget = discountBudget - budget;

//    if (budget > discountBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {discountBudget - budget:F2} leva more.");
//    }

//}


//else if (typeFlowers == "Roses" && quantity <= 80)
//{
//    double needBudget = quantity * 5;
//    double leftBudget = needBudget - budget;



//    if (budget > needBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {needBudget - budget:F2} leva more.");
//    }

//}

//else if (typeFlowers == "Dahlias" && quantity > 90)
//{
//    double needBudget = quantity * 3.80;
//    double discountBudget = needBudget * 0.85;

//    double leftBudget = discountBudget - budget;

//    if (budget > discountBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {discountBudget - budget:F2} leva more.");
//    }

//}

//else if (typeFlowers == "Dahlias" && quantity <= 90)
//{
//    double needBudget = quantity * 3.80;
//    double leftBudget = needBudget - budget;



//    if (budget > needBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {needBudget - budget:F2} leva more.");
//    }
//}

//else if (typeFlowers == "Tulips" && quantity > 80)
//{
//    double needBudget = quantity * 2.80;
//    double discountBudget = needBudget * 0.85;

//    double leftBudget = discountBudget - budget;

//    if (budget > discountBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {discountBudget - budget:F2} leva more.");
//    }

//}

//else if (typeFlowers == "Tulips" && quantity <= 80)
//{
//    double needBudget = quantity * 2.80;
//    double leftBudget = needBudget - budget;



//    if (budget > needBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {needBudget - budget:F2} leva more.");
//    }
//}

//else if (typeFlowers == "Narcissus" && quantity < 120)
//{
//    double needBudget = quantity * 3;
//    double discountBudget = needBudget * 0.15 + needBudget;

//    double leftBudget = discountBudget - budget;

//    if (budget > discountBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {discountBudget - budget:F2} leva more.");
//    }

//}

//else if (typeFlowers == "Narcissus" && quantity >= 120)
//{
//    double needBudget = quantity * 3;
//    double leftBudget = needBudget - budget;

//    if (budget > leftBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {leftBudget - budget:F2} leva more.");
//    }

//}

//else if (typeFlowers == "Gladiolus" && quantity < 80)
//{
//    double needBudget = quantity * 2.50;
//    double discountBudget = needBudget * 0.20 + needBudget;

//    double leftBudget = discountBudget - budget;

//    if (budget > discountBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {discountBudget - budget:F2} leva more.");
//    }

//}

//else if (typeFlowers == "Gladiolus" && quantity >= 80)
//{
//    double needBudget = quantity * 2.50;
//    double leftBudget = needBudget - budget;

//    if (budget > leftBudget)
//    {
//        Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {Math.Abs(leftBudget):F2} leva left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money, you need {leftBudget - budget:F2} leva more.");
//    }

//}




string flowers = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine()); 

double finalSum = 0;

switch (flowers)
{
    case "Roses":
        finalSum = count * 5;
        if (count > 80)
        {
            finalSum *= 0.9;
        }
        break;
    case "Dahlias":
        finalSum = count * 3.80;
        if (count > 90)
        {
            finalSum *= 0.85;
        }
        break;
    case "Tulips":
        finalSum = count * 2.80;
        if (count > 80)
        {
            finalSum *= 0.85;
        }
        break;
    case "Narcissus":
        finalSum = count * 3;
        if (count < 120)
        {
            finalSum *= 1.15;
        }
        break;
    case "Gladiolus":
        finalSum = count * 2.50;
        if (count < 80)
        {
            finalSum *= 1.20;
        }
        break;
}

if (budget >= finalSum)
{
    Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {budget - finalSum:F2} leva left.");
}    
else
{
    Console.WriteLine($"Not enough money, you need {finalSum-budget:F2} leva more.");
}
 
