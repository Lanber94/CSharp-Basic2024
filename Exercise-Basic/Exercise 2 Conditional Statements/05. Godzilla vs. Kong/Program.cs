//Sazdavame promenlivi za vhodnite danni
using System;
using System.ComponentModel.Design;

double budgetFilm = double.Parse(Console.ReadLine());
int numberOfStatist = int.Parse(Console.ReadLine());
double preisOblekloOneStatist = double.Parse(Console.ReadLine());


double preisDekor = budgetFilm * 0.1;

if (numberOfStatist > 150)
{
    double discountObleklo = preisOblekloOneStatist * 0.9;
    double totalCost = discountObleklo * numberOfStatist + preisDekor;

    if (totalCost <= budgetFilm)
    {
        Console.WriteLine("Action!");
        Console.WriteLine($"Wingard starts filming wirh {budgetFilm - totalCost:F2} leva more.");
    }
}

else
{
    double totalCost = preisOblekloOneStatist * numberOfStatist + preisDekor;

    if (totalCost > budgetFilm)
    {
        Console.WriteLine("Not enough money!");
        Console.WriteLine($"Wingard needs {totalCost-budgetFilm:f2} leva more.");
    }
    
}

//double preisObleklo = numberOfStatist * preisOblekloOneStatist;
//double discountPreisObleklo = preisObleklo * 0.9; 
       

//double totalSumFilm = preisDekor + preisObleklo;
//double totalSumFilmDiscount = preisDekor + discountPreisObleklo;

//double more150;


//if (numberOfStatist > 150) 
//{ 
//    double grandTotal = totalSumFilmDiscount;
//    Console.WriteLine("Action!");
//    Console.WriteLine($"Wingard starts filming {budgetFilm - grandTotal:F2} leva more.");

//}

//else if (numberOfStatist <= 150)
//{
//    double grandTotal2 = totalSumFilm;
//}


// if (grandTotal  

//else if (budgetFilm < totalSumFilm1)




//{
//    Console.WriteLine("Not enough money!");
//    Console.WriteLine($"Wingard needs {budgetFilm - totalSumFilm1:F2} leva more.");
//}
//     }



//if (budgetFilm <= totalSumFilm)
//{
//    Console.WriteLine("Action!");
//    Console.WriteLine($"Wingard starts filming with {budgetFilm - totalSumFilm:F2} leva left.");

//}
 
 

     