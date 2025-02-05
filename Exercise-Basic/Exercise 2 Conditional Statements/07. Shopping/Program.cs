double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processor = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

double sumOfVideoCards = videoCards * 250;
double sumOfProcessor = processor * (sumOfVideoCards * 0.35);
double sumOfRam = ram * (sumOfVideoCards * 0.1);
double allSum = sumOfRam + sumOfProcessor + sumOfVideoCards;

if (videoCards > processor)
{
      allSum = allSum - (allSum * 0.15); //allSum=allSum*0.85; //allSum *= 0.85
}

if (budget >= allSum)
{
    Console.WriteLine($"You have {budget - allSum:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {allSum-budget:f2} leva more!");
}