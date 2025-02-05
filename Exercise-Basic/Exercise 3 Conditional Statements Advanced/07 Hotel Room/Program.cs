using System;

string month = Console.ReadLine();  
int numNight = int.Parse(Console.ReadLine());

double priceStudio = 0;
double priceApartment = 0;



switch (month)
{

    case "May":
    case "October":
        priceStudio = numNight * 50;
        priceApartment = numNight * 65;
        if (numNight > 7 && numNight < 14)
        {
            priceStudio *= 0.95;

        }
        if (numNight > 14)
        {
            priceStudio *= 0.70;
            priceApartment *= 0.90;
        }
       

        break;
    case "June":
    case "September":
        priceStudio = numNight * 75.20;
        priceApartment = numNight * 68.70;
        if( numNight > 14)
        {
            priceStudio *= 0.80;
            priceApartment *= 0.90;
        }
        
        break;
    case "July":
    case "August":
        priceStudio = numNight * 76;
        priceApartment = numNight * 77;
        if ( numNight > 14)
        {
            priceApartment *= 0.90;
        }
            
            break ;
       
}

Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
Console.WriteLine($"Studio: {priceStudio:F2} lv.");