using System.Numerics;

int packOfPens=int.Parse(Console.ReadLine());
int packOfMarkers=int.Parse(Console.ReadLine());
int litres =int.Parse(Console.ReadLine());
int discount=int.Parse(Console.ReadLine());
double penPrice = 5.80;
double markersPrice = 7.20;
double litresPrice = 1.20;
double sumOfPens = packOfPens * penPrice;
double sumOfMarkers = packOfMarkers * markersPrice;
double sumOfLitres = litres * litresPrice;
double sumWithoutDiscount = sumOfPens + sumOfMarkers + sumOfLitres;
//double sumWithoutDiscount = packOfPens * 5.80 + packOfMarkers * 7.20 + litres * 1.20;
 
double sumWithDiscount = sumWithoutDiscount - sumWithoutDiscount * discount / 100;
 
Console.WriteLine(sumWithDiscount);
DivideByZeroException