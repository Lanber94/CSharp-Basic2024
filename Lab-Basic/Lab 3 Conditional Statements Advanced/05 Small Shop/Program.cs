﻿using System;

string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

//град / продукт   coffee  water	beer	sweets	peanuts
//Sofia	            0.50	0.80	1.20	1.45	1.60
//Plovdiv     	    0.40	0.70	1.15	1.30	1.50
//Varna	            0.45	0.70	1.10	1.35	1.55

double calculation = 0;

if (city == "Sofia")
{

    switch (product)
    {
        case "coffee":
            calculation = quantity * 0.5;
            
            break;
        case "water":
            calculation = quantity * 0.8;
            
            break;
        case "beer":
            calculation = quantity * 1.2;
            
             break;
        case "sweets":
            calculation = quantity * 1.45;
            
            break;
        case "peanuts":
            calculation = quantity * 1.6;
            
            break;
    }
}
else if (city == "Plovdiv")
{
    switch (product)
    {
        case "coffee":
            calculation = quantity * 0.4;
           
            break;
        case "water":
            calculation = quantity * 0.7;
            
            break;
        case "beer":
            calculation = quantity * 1.15;
            
            break;
        case "sweets":
            calculation = quantity * 1.3;
            
            break;
        case "peanuts":
            calculation = quantity * 1.5;
            
            break;
    }
}
else if (city == "Varna")
{

      switch (product) 
      {
        case "coffee":
            calculation = quantity * 0.45;
           
            break;
        case "water":
            calculation = quantity * 0.7;
            
            break;
        case "beer":
            calculation = quantity * 1.10;
            
            break;
        case "sweets":
            calculation = quantity * 1.35;
            
            break;
        case "peanuts":
            calculation = quantity * 1.55;
            
         break;
      }
}
Console.WriteLine(calculation);