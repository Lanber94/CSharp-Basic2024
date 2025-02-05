// sazdavame promenlici za vhod double vacationPrice = double.Parse(Console.ReadLine());
double vacationPrice = double.Parse(Console.ReadLine());
int puzzles = int .Parse(Console.ReadLine());
int talkingDolls=int .Parse(Console.ReadLine());
int teddyBears = int .Parse(Console.ReadLine());
int minions=int .Parse(Console.ReadLine());
int trucks=int .Parse(Console.ReadLine());

// presmqtame kolko sa vsicki igrachki
int totalToys = puzzles + talkingDolls + teddyBears + minions + trucks;
// kolko sa sumata na vsickite igrachki
double sum = puzzles * 2.60 + talkingDolls * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;

// proverqvame dali igrackite sa povece ili ravni na 50=> pravim otstipka
if (totalToys >= 50)
{
    sum *= 0.75; //sum=sum*0.75  sum=sum-(sum*0.25)
}
// presmqtame naema
double rest = sum * 0.1;
double profit = sum - rest;
// proverqvame dali parite i stigat
if (profit >= vacationPrice)
{
    Console.WriteLine($"Yes! {profit - vacationPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {vacationPrice - profit:f2} lv needed.");
}