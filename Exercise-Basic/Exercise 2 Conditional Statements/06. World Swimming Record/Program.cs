// zazdavame promenlivi za vhodnite danni
double worldRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timePerOneMetres = double.Parse(Console.ReadLine());
// presmqtame vremeto na Ivan bez zabavqne
double timeByIvan = distance*timePerOneMetres;
// presmqta kolko piti se e zabavil
// presmqtame vremeto na zabavqne
double delayTime =Math.Floor (distance / 15) * 12.5;
// presmqtame kolko e obstoto vreme sas zabavqneto
double allTime = timeByIvan + delayTime;
// proverqvame dali e podobril rekorda
if (allTime < worldRecord)// (worldRecord-allTime > 0)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {allTime:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecord - allTime):f2} seconds slower.");
}