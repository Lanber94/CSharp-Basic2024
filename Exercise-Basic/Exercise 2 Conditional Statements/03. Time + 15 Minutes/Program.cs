// zazdadem promenlivi za casa i minuti
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
// dobavqme 15 minuti
minutes += 15; //minutes=minutes+15
// da pravim proverka dali minutite >60
if (minutes>=60)
{
    hours += 1; //hours=hours+1;
    minutes -= 60; //minutes=minutes-60;
}
// da pravim proverka dali casovoete sa >=24
if (hours >= 24)
{
    hours -= 24;
}
// da napravim proverka dali minutite sa <=9 ili ne 
if (minutes <= 9)
{
    Console.WriteLine($"{hours}:0{minutes}");
}
else
{
    Console.WriteLine($"{hours}:{minutes}");
}

