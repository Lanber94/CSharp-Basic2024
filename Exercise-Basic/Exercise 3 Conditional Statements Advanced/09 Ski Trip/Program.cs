using System.Transactions;

int dayOfprestoy = int.Parse(Console.ReadLine());
string vidPomestenie = Console.ReadLine();  
string ocenka = Console.ReadLine();

double day = dayOfprestoy - 1;
double price = 0;


switch (vidPomestenie)
{
    case "room for one person":
        price = day * 18.00;
        if (ocenka == "positive" || ocenka == "negative")
        {
            if (ocenka == "positive")
            {
                price *= 1.25;
            }
            else if (ocenka == "negative")
            {
                price *= 0.9;
            }
        }           
    break;
    case "apartment":
        price = day * 25.00;
        if (ocenka == "positive" || ocenka == "negative")
        {
            if (ocenka == "positive")
            {
                price *= 1.25;
                if (day < 10)
                {
                    price *= 0.70;
                }    
                if (day >= 10 && day <= 15)
                {
                    price *= 0.65;
                }    
                if (day > 15)
                {
                    price *= 0.50;
                }
            }
            else if (ocenka == "negative")
            {
                price *= 0.9;
                if (day < 10)
                {
                    price *= 0.70;
                }
                if (day >= 10 && day <= 15)
                {
                    price *= 0.65;
                }
                if (day > 15)
                {
                    price *= 0.50;
                }
            }
        }
                    
    break;
    case "president apartment":
        price = day * 35.00;
        if (ocenka == "positive" || ocenka == "negative")
        {
            if (ocenka == "positive")
            {
                price *= 1.25;
                if (day < 10)
                {
                    price *= 0.90;
                }
                if (day >= 10 && day <= 15)
                {
                    price *= 0.85;
                }
                if (day > 15)
                {
                    price *= 0.80;
                }
            }
            else if (ocenka == "negative")
            {
                price *= 0.9;
                if (day < 10)
                {
                    price *= 0.90;
                }
                if (day >= 10 && day <= 15)
                {
                    price *= 0.85;
                }
                if (day > 15)
                {
                    price *= 0.80;
                }
            }
        }   
    break;
}
Console.WriteLine($"{price:f2}");



