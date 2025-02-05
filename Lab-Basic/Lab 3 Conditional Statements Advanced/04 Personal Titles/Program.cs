double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

//•	"Mr." – мъж(пол 'm') на 16 или повече години
//•	"Master" – момче (пол 'm') под 16 години
//•	"Ms." – жена (пол 'f') на 16 или повече години
//•	"Miss" – момиче (пол 'f') под 16 години

if (gender == 'm')
{
    if (age >= 16)
    {
        Console.WriteLine("Mr.");
    }
    if (age < 16)
    {
        Console.WriteLine("Master");
    }
    
}
if (gender == 'f')
{
    if (age >= 16)
    {
        Console.WriteLine("Ms.");
    }
    if(age < 16)
    {
        Console.WriteLine("Miss");
    }
}
