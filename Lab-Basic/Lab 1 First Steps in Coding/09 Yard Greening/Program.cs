double m2 = double.Parse(Console.ReadLine());
double m2Preis = m2 * 7.61;
double discount = m2Preis * 18/100;
double finalPreis = m2Preis - discount;
Console.WriteLine($"The final price is: {finalPreis} lv.");
Console.WriteLine($"The discount is: {discount} lv."); 