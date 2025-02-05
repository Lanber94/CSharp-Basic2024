//int casnaizpita = int.Parse(Console.ReadLine());
//int minutinaizpita = int.Parse((Console.ReadLine()));
//int casnapristigane = int.Parse((Console.ReadLine()));
//int minutizapristigane = (int.Parse((Console.ReadLine())));

    //double m1 = casnaizpita * 60;
    //double m2 = casnapristigane * 60;

    //// za cas
    //double hours = casnaizpita - casnapristigane;
    //double minuts = minutinaizpita - minutizapristigane;


    //string zakuznql = "";
    //string navreme = "";
    //string podranil = "";

    //double cal = (m1 + minutinaizpita) - (m2 + minutizapristigane);

    //double casnaizpit = (m1 + minutinaizpita);
    //double vremezapristigane = m2 + minutizapristigane;


    //if (vremezapristigane > casnaizpit)
    //{
    //    zakuznql = "Late";
    //    Console.WriteLine(zakuznql);
    //    Console.WriteLine($"{Math.Abs(cal)} minutes after the start");

    //}

    //if (vremezapristigane == casnaizpit || cal <= 30)
    //{
    //    navreme = "On Time";

    //    Console.WriteLine(navreme);
    //    Console.WriteLine($"{Math.Abs(cal)} minutes before the start");

    //}
    //if (cal > 30 || cal < 60 && cal >= 60 || cal == 0) 
    //{
    //    if (cal > 30 && cal < 60)
    //    {
    //        podranil = "Early";
    //        Console.WriteLine(podranil);
    //        Console.WriteLine($"{cal} minutes before the start");

    //    }

    //    else if (cal >= 60)
    //    {
    //        podranil = "Early";
    //        Console.WriteLine(podranil);
    //        Console.WriteLine($"{hours}:0{minuts} hours before the start");
    //    }
    //    else if (cal == 0)
    //    {
    //        podranil = "Early";
    //        Console.WriteLine(podranil);
    //        Console.WriteLine($"{hours}:{minuts} hours before the start");
    //    }
    //}

    //int startHour = int.Parse(Console.ReadLine());
    //int startMin = int.Parse(Console.ReadLine());
    //int arriveHour = int.Parse(Console.ReadLine());
    //int arriveMin = int.Parse(Console.ReadLine());

    //// времето на старта и време на пристигане в  минути
    //int startTime = startHour * 60 + startMin;
    //int arriveTime = arriveHour * 60 + arriveMin;
    //int differenceTime = Math.Abs(startTime - arriveTime);//180-260=80
    //int differenceHour = differenceTime / 60;//1 h
    //int differenceMin = differenceTime % 60;//20 min

    //if (startTime < arriveTime)
    //{
    //    Console.WriteLine("Late");
    //    if (differenceHour == 0)
    //    {
    //        Console.WriteLine($"{differenceMin} minutes after the start");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{differenceHour}:{differenceMin:d2} hours after the start");
    //    }
    //}

//else if (differenceTime <= 30)
//{
//    Console.WriteLine("On time");
//    if (differenceMin != 0)
//    {
//        Console.WriteLine($"{differenceMin} minutes before the start");
//    }
//}







int casnaizpita = int.Parse(Console.ReadLine());
int minutinaizpita = int.Parse((Console.ReadLine()));
int casnapristigane = int.Parse((Console.ReadLine()));
int minutizapristigane = (int.Parse((Console.ReadLine())));

int totalCasIzpit = casnaizpita * 60 + minutinaizpita;
int totalCasPristigane = casnapristigane * 60 + minutizapristigane;

int razlikaVreme = Math.Abs(totalCasIzpit - totalCasPristigane);
int razlikaCas = razlikaVreme / 60; // cas 
int razlikaMinuti = razlikaVreme % 60;// minuti

if (totalCasIzpit < totalCasPristigane)
{
    Console.WriteLine("Late");
    if (razlikaCas == 0) 
    {
        Console.WriteLine($"{razlikaMinuti} minutes after the start");
    }
    else
    {
        Console.WriteLine($"{razlikaCas}:{razlikaMinuti:d2} hours after the start");
    }
}
else if (razlikaVreme <= 30)

{
    Console.WriteLine("On time");
    if (razlikaMinuti != 0)
    { 
        Console.WriteLine($"{razlikaMinuti} minutes before the start"); 
    }
}
else if (razlikaVreme > 30)
{
    Console.WriteLine("Early");
    if (razlikaCas == 0)
    {
        Console.WriteLine($"{razlikaMinuti} minutes before the start");
    }
    else
    {
        Console.WriteLine($"{razlikaCas}:{razlikaMinuti:d2} hours before the start");
    }
}



//int examHour = int.Parse(Console.ReadLine());
//int examMinutes = int.Parse(Console.ReadLine());
//int arrivalHour = int.Parse(Console.ReadLine());
//int arrivalMinutes = int.Parse(Console.ReadLine());
//int hoursChecker = Math.Abs(examHour - arrivalHour);
//int minutesChecker = Math.Abs(examMinutes - arrivalMinutes);

//if (examHour == arrivalHour && examMinutes == arrivalMinutes)
//{
//    Console.WriteLine("On time");
//}
//else if (arrivalHour == examHour - 1 && (60 - arrivalMinutes) + examMinutes <= 30)

//{

//    Console.WriteLine("On time");
//    Console.WriteLine($"{(60 - arrivalMinutes) + examMinutes} minutes before the start");
//}

// else if (arrivalHour < examHour) 

//    {
//         double calculation1 = (60 - arrivalMinutes) - examMinutes;

//        Console.WriteLine($"Early");
//        Console.WriteLine($"{hoursChecker}:{calculation1} hours before the start");

//    }
//else if (arrivalHour <= examHour && ((60 - arrivalMinutes) > 30) || examMinutes - arrivalMinutes > 30)
//{
//    if (hoursChecker == 0 && minutesChecker > 30)
//    {
//        Console.WriteLine($"Early");
//        Console.WriteLine($"{examMinutes - arrivalMinutes} minutes before the start");
//    }

//    double calculation = Math.Abs(arrivalMinutes - examMinutes);
//    if (calculation == 0)
//    {
//        Console.WriteLine($"Early");
//        Console.WriteLine($"{hoursChecker}:0{calculation} hours before the start");
//    }

//    if (arrivalHour < examHour && ((60 - arrivalMinutes) + examMinutes <= 9))
//    {
//        Console.WriteLine($"Early");
//        Console.WriteLine($"{examHour - arrivalHour}:0{Math.Abs(arrivalMinutes - examMinutes)} hours before the start");
//    }


//}
//int examHour = int.Parse(Console.ReadLine());
//int examMinutes = int.Parse(Console.ReadLine());
//int arrivalHour = int.Parse(Console.ReadLine());
//int arrivalMinutes = int.Parse(Console.ReadLine());
//int hoursChecker = Math.Abs(examHour - arrivalHour);
//int minutesChecker = Math.Abs(examMinutes - arrivalMinutes);

//if (examHour == arrivalHour && examMinutes == arrivalMinutes)
//{
//    Console.WriteLine("On time");
//}
//else if (arrivalHour == examHour - 1 && (60 - arrivalMinutes) + examMinutes <= 30)

//{

//    Console.WriteLine("On time");
//    Console.WriteLine($"{(60 - arrivalMinutes) + examMinutes} minutes before the start");
//}

// else if (arrivalHour < examHour) 

//    {
//         double calculation1 = (60 - arrivalMinutes) - examMinutes;

//        Console.WriteLine($"Early");
//        Console.WriteLine($"{hoursChecker}:{calculation1} hours before the start");

//    }
//else if (arrivalHour <= examHour && ((60 - arrivalMinutes) > 30) || examMinutes - arrivalMinutes > 30)
//{
//    if (hoursChecker == 0 && minutesChecker > 30)
//    {
//        Console.WriteLine($"Early");
//        Console.WriteLine($"{examMinutes - arrivalMinutes} minutes before the start");
//    }

//    double calculation = Math.Abs(arrivalMinutes - examMinutes);
//    if (calculation == 0)
//    {
//        Console.WriteLine($"Early");
//        Console.WriteLine($"{hoursChecker}:0{calculation} hours before the start");
//    }

//    if (arrivalHour < examHour && ((60 - arrivalMinutes) + examMinutes <= 9))
//    {
//        Console.WriteLine($"Early");
//        Console.WriteLine($"{examHour - arrivalHour}:0{Math.Abs(arrivalMinutes - examMinutes)} hours before the start");
//    }


//}


