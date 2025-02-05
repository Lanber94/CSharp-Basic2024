string typeProjection = Console.ReadLine();
int quantityLines = int.Parse(Console.ReadLine());
int quantityKolons = int.Parse(Console.ReadLine());

double income = 0.0;

if (typeProjection == "Premiere")
{
    income = quantityLines * quantityKolons * 12.00;
    Console.WriteLine($"{income:F2} leva");
}
if (typeProjection == "Normal")
{
    income = quantityLines * quantityKolons * 7.50;
    Console.WriteLine($"{income:F2} leva");
}
if (typeProjection == "Discount")
{
    income = quantityLines * quantityKolons * 5.00;
    Console.WriteLine($"{income:F2} leva");
}


