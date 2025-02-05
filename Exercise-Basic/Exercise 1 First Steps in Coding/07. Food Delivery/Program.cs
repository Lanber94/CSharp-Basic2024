int chickenMenuCount=int.Parse(Console.ReadLine());
int fishMenuCount=int.Parse(Console.ReadLine());
int veganMenuCount=int.Parse(Console.ReadLine());
double sumOFMenu = chickenMenuCount * 10.35 + fishMenuCount * 12.40 + veganMenuCount * 8.15;
double cakeSun = sumOFMenu * 0.2; //20/100
double allSUm = sumOFMenu + cakeSun + 2.50;
Console.WriteLine(allSUm);
