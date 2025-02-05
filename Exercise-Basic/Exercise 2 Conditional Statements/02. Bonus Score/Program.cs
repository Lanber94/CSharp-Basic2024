//da zazdadem promenlivi za broq tock
int num = int.Parse(Console.ReadLine());
//promenliva za bonus tocki
double bonus = 0;
//proverka na cisloto dali e <=100, 100 1000 vkl. >1000
if (num <= 100)
{
    bonus = 5;
}
else if (num > 1000)
{
    bonus = num * 0.1;
}
else
{
    bonus = num * 0.2;
}
//proverka naseto cislo e cetno ili zavursva na 5
if (num % 2 == 0)
{
    bonus = bonus + 1; //bonus +=1
}
else if (num%10==5)
{
    bonus += 2; //bonus=bonus +2
}
//printirame rezultata
Console.WriteLine(bonus);
Console.WriteLine(num + bonus);
