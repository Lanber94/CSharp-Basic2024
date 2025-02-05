using System.Reflection.Metadata;
// Materiali
double predPazenNaylon = 1.50; // lv za kv.m.
double boq = 14.50; // lv za litir
double razreditelboq = 5.00; // lv za litir

//Extra
// 10% ot kolicestvo boq
// 2 kv.m naylon
// 0.40 lv torbicki

// danni 
double needNaylon = double.Parse(Console.ReadLine());
double needBoq = double.Parse(Console.ReadLine());
double quantityRazreditel = double.Parse(Console.ReadLine());
double hoursMaisterneeded = double.Parse(Console.ReadLine());

// Vsicki sumi
double sumNaylon = (needNaylon + 2) * 1.50;

// + 10%
double boqprocent = needBoq + (needBoq * 0.10);
double sumBoq = boqprocent * 14.50;

double sumRazreditel = quantityRazreditel * 5.00;
double sumTorbicki = 0.40;

// Vsicki sumi za materiali
double allSumMaterial = sumNaylon + sumBoq + sumRazreditel + sumTorbicki;

// Sumi za maysori
double SumMaister = (allSumMaterial * 0.30) * hoursMaisterneeded;



// Krayna Suma
double totalSum = allSumMaterial + SumMaister;
                  
Console.WriteLine(totalSum);






