// sizdavae promenlivi za vhodni danni
double deposit=double.Parse(Console.ReadLine());
int periodOFDeposit=int.Parse(Console.ReadLine());
double persenPerYear=double.Parse(Console.ReadLine());


double final = deposit + deposit * persenPerYear / 100 / 12 * periodOFDeposit;
Console.WriteLine(final);

//double yearProfit = deposit * percentPerYear / 100;
//double monthProfit = yearProfit / 12;
//double final = deposit + monthProfit * periodOfDeposit;