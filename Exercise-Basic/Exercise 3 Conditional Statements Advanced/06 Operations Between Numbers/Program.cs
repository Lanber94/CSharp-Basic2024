int N1 = int.Parse(Console.ReadLine());
double N2 = int.Parse(Console.ReadLine());
char Operator = char.Parse(Console.ReadLine());

double calculation = 0;


if (Operator == '+')
{
    calculation = N1 + N2;

    if (calculation % 2 == 0)
    {
        
        Console.WriteLine($"{N1} + {N2} = {calculation} - even");
    }
    else
        Console.WriteLine($"{N1} + {N2} = {calculation} - odd");

}
if (Operator == '-')
{
    calculation = N1 - N2;

    if (calculation % 2 == 0)
    {

        Console.WriteLine($"{N1} - {N2} = {calculation} - even");
    }
    else
        Console.WriteLine($"{N1} - {N2} = {calculation} - odd");

}
if (Operator == '*')
{
    calculation = N1 * N2;

    if (calculation % 2 == 0)
    {

        Console.WriteLine($"{N1} * {N2} = {calculation} - even");
    }
    else
        Console.WriteLine($"{N1} * {N2} = {calculation} - odd");
}
if (Operator == '/')
{
    calculation = N1 / N2;

    if (N2 == 0)
    {
        Console.WriteLine($"Cannot divide {N1} by zero");
    }
    else 
        Console.WriteLine($"{N1} / {N2} = {calculation:F2}");
}
if (Operator =='%')
{
    calculation = N1 % N2;

    if (N2 == 0)
    {
        Console.WriteLine($"Cannot divide {N1} by zero");
    }
    else
        Console.WriteLine($"{N1} % {N2} = {calculation}");
}