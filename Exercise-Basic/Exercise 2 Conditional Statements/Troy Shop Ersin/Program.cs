//double priceEkskurzia = double.Parse(Console.ReadLine());
//int broyPuzel = int.Parse(Console.ReadLine());
//int broyKukli = int.Parse(Console.ReadLine());
//int broyMeceta = int.Parse(Console.ReadLine());
//int broyMiniori = int.Parse(Console.ReadLine());
//int broyKamioni = int.Parse(Console.ReadLine());

//double allSum = (broyPuzel * 2.60) + (broyKukli * 3) + (broyMeceta * 4.10) + (broyMiniori * 8.20) + (broyKamioni * 2);
//double totalIgracki = broyPuzel + broyKukli + broyMeceta + broyMiniori + broyKamioni;

//double naem = allSum * 0.10;
//double allsum1 = allSum - naem;

//if (totalIgracki >= 50)
//{
//    double discountAllSum = allSum * 0.75;

//    double speceleniPariNaem = discountAllSum * 0.90;

//    if (speceleniPariNaem >= priceEkskurzia)
//    {
//        Console.WriteLine($"Yes! {speceleniPariNaem - priceEkskurzia:F2} lv left.");
//    }

//    if (speceleniPariNaem <= priceEkskurzia)
//    {

//        Console.WriteLine($"Not enough money! {Math.Abs(speceleniPariNaem - priceEkskurzia):F2} lv needed.");

//    }

//    }


double priceEkskurzia = double.Parse(Console.ReadLine());
int broyPuzel = int.Parse(Console.ReadLine());
int broyKukli = int.Parse(Console.ReadLine());
int broyMeceta = int.Parse(Console.ReadLine());
int broyMiniori = int.Parse(Console.ReadLine());
int broyKamioni = int.Parse(Console.ReadLine());

double allSum = (broyPuzel * 2.60) + (broyKukli * 3) + (broyMeceta * 4.10) + (broyMiniori * 8.20) + (broyKamioni * 2);
double totalIgracki = broyPuzel + broyKukli + broyMeceta + broyMiniori + broyKamioni;

//double naem = allSum * 0.10;
//double allsum1 = allSum - naem;


if (totalIgracki >= 50)
{
    allSum *= 0.75;
    
}

double allsumAfterRent = allSum * 0.9;

if (allsumAfterRent >= priceEkskurzia)

{
    Console.WriteLine($"Yes! {allsumAfterRent - priceEkskurzia:F2} lv left.");
}

else if (allsumAfterRent < priceEkskurzia)
{
    Console.WriteLine($"Not enough money! {Math.Abs(allsumAfterRent - priceEkskurzia):F2} lv needed.");
}