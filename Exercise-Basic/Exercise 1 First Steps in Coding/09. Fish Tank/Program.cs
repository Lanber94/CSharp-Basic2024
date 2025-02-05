// promenlivi za diljinata, sirocinata i visocinata --> santimetri i shte se ce cetata ot consolata
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine()); 


// promenliva za procenta zaetost ot drugi neshta , ne voda
double percentages=double.Parse(Console.ReadLine());

//namirane obema
double volume = length * width * height; //kub.santimetri -> ml
//prevrishtane na ml v litri
double volumeLitres = volume / 1000; //*0.001

// da presmetnem kolko e zaeoto mqsto
double spaceNeeded = percentages / 100; //17%=0.17
double litresNeeded = volumeLitres * (1 - spaceNeeded); //300*(1-0.17)

// printirame rezultata 
Console.WriteLine(litresNeeded);

