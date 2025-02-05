// zazdavame promenlivi za vremenata za trimata zaztazateli
int firsTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());
// da presmetnem kolko e obstoto vreme v zekundi
int totalTime = firsTime + secondTime + thirdTime;//124 sekundi
// prevristane vremeto ot sekundi v minuti
int minutes = totalTime / 60;//124/60=2
int seconds = totalTime % 60;
// printirame rezultata "minuti:sekundi"
if (seconds <= 9) //seconds<10
{
    Console.WriteLine($"{minutes}:0{seconds}");
}

else
{
    Console.WriteLine($"{minutes}:{seconds}");
}
