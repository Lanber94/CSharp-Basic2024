int allOfpages = int.Parse(Console.ReadLine());
int pagesfor1hour = int.Parse(Console.ReadLine());
int allDays = int.Parse(Console.ReadLine());

int alltime = allOfpages / pagesfor1hour;


int totalHours = alltime / allDays;


Console.WriteLine(totalHours);
