﻿//int num = int.Parse(Console.ReadLine());


//if (num >= 100 && num <= 200 || num == 0)
//{
//}
//else
//{
//    Console.WriteLine("invalid");
//}

int num = int.Parse(Console.ReadLine());

bool isValid = (num >= 100 && num <= 200 || num == 0);

if (!isValid)
{
    Console.WriteLine("invalid");
}