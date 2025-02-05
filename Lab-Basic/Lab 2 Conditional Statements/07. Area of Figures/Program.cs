string figure = Console.ReadLine();

double area;


if (figure == "square")
{
    double a = double.Parse(Console.ReadLine());
    area = a * a;
    Console.WriteLine($"{area:f3}");

}

else if (figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    area = a * b;
    Console.WriteLine($"{area:f3}");

}


else if (figure == "circle")
{
    double r = double.Parse(Console.ReadLine());
    area = Math.PI * r * r;
    Console.WriteLine($"{area:f3}");

}


else if (figure == "triangle") 

{
    double h = double.Parse(Console.ReadLine());
    double a = double.Parse(Console.ReadLine());
    area = a * h / 2;
    Console.WriteLine($"{area:f3}");

}





