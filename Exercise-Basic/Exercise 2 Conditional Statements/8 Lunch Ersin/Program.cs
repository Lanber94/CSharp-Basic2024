string nameSerial = (Console.ReadLine());
int durationEpizod = int.Parse(Console.ReadLine());
int durationPause = int.Parse(Console.ReadLine());

// double timeObqd = durationPause * 1 / 8; 
double drobnoDelenieTimeObqd = durationPause / 8.0;
double timeOtdih = durationPause / 4.0;

double timeLeft = durationPause - drobnoDelenieTimeObqd - timeOtdih;

double timeLeft2 = Math.Abs(timeLeft - durationEpizod);




if (timeLeft >= durationEpizod)
{

    Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(timeLeft2)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(timeLeft2)} more minutes.");
}