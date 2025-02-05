using System.ComponentModel.Design;

double budgetFilm = double.Parse(Console.ReadLine());
int numberOfStatist = int.Parse(Console.ReadLine());
double preisOblekloOneStatist = double.Parse(Console.ReadLine());


double preisDekor = budgetFilm * 0.1;

if (numberOfStatist > 150)
{
    double discountObleklo = preisOblekloOneStatist * 0.9;
    double totalCost = (discountObleklo * numberOfStatist) + preisDekor;

    if (totalCost <= budgetFilm)
    {
        Console.WriteLine("Action!");
        Console.WriteLine($"Wingard starts filming with {budgetFilm - totalCost:F2} leva left.");
    }

     else if (totalCost > budgetFilm)
    {
        Console.WriteLine("Not enough money!");
        Console.WriteLine($"Wingard needs {totalCost - budgetFilm:f2} leva more.");
    }
}

  else if (numberOfStatist < 150)
{
    double totalCost = (preisOblekloOneStatist * numberOfStatist) + preisDekor;

    if (totalCost <= budgetFilm)
    {
        Console.WriteLine("Action!");
        Console.WriteLine($"Wingard starts filming with {Math.Abs(totalCost - budgetFilm):F2)} leva left.");
    }
    
    else if (totalCost > budgetFilm)
    {
        Console.WriteLine("Not enough money!");
        Console.WriteLine($"Wingard needs {totalCost - budgetFilm:f2} leva more.");
    }

}
