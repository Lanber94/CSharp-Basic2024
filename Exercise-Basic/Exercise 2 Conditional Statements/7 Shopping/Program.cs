double budgetPetir = double.Parse(Console.ReadLine());
int broyVideoCards = int.Parse(Console.ReadLine());
int broyProccesor = int.Parse(Console.ReadLine());
int broyRam = int.Parse(Console.ReadLine());

double videoCard = 250 * broyVideoCards;
double procesor = videoCard * 0.35 * broyProccesor;
double ram = videoCard * 0.1 * broyRam;

double sum = videoCard + procesor + ram;

if (broyVideoCards > broyProccesor)
{
    //double discount = sum * 0.15;
    //double discountedSum = sum - discount;
    //sum = discountedSum;

    sum *= 0.85;
}

if (sum <= budgetPetir)
{
    Console.WriteLine($"You have {budgetPetir - sum:F2} leva left!");
}

if (sum > budgetPetir)
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(sum - budgetPetir):f2} leva more!");
}




//double budget = double.Parse(Console.ReadLine());
//int videoCard = int.Parse(Console.ReadLine());
//int processors = int.Parse(Console.ReadLine());
//int ram = int.Parse(Console.ReadLine());

//double videoCardPrice = videoCard * 250;
//double sum = (videoCardPrice) + (videoCardPrice * processors * 0.35) + (videoCardPrice * ram * 0.1);

//if (videoCard > processors)
//{
//    sum *= 0.85;
//}

//if (budget >= sum)
//{
//    Console.WriteLine($"You have {budget - sum:f2} leva left!");
//}
//else if (budget < sum)
//    Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");