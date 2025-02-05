// ime, vreme na seriqta i vreme za pocivka
string name = Console.ReadLine();
int timeSeries = int.Parse(Console.ReadLine());
int relaxTime = int.Parse(Console.ReadLine()); //double relaxTime

// presmqtame vremeto za obqd i otdih
double lunchTime = relaxTime / 8.0; //(double)relaxTime / 8;
double restTime = relaxTime / 4.0; //double relaxTime
// namirame ostavastoto vreme
double timeLeft = relaxTime - lunchTime - restTime; //double timeLeft=relaxTime-(launcTime + restTime);

//da proverim stiga li vremeto
if (timeLeft >= timeSeries)
{
    double freeTime = timeLeft - timeSeries;
    Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft - timeSeries)} minutes free time.");
}
else
{
    double freeTime = timeSeries - timeLeft;
    Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(freeTime)} more minutes.");

}
