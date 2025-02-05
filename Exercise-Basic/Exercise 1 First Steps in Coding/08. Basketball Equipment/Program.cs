// promenliva za godisnata taka, koyato se cete ot consolata
int feePeryear=int.Parse(Console.ReadLine());

//promenlivi za ekipirovkata 
// s 40% po malko ot godisnata taksa
double shoes = feePeryear - feePeryear * 0.4; //feePerYear*0.6
//s 20% po malko ot obuvkite
double equipment = shoes * 0.8; // shoes - shoes * 0.2;
//1/4 ot ekipirovkata(25%=0.25)
double ball = equipment / 4; // equipment * 0.25;
//1/5 ot topkata (100%/5=20%->0.2)
double accessories = ball / 5; // balll * 0.2;

//namirane cqlata suma ot ekiporovkata s godisnata taksa

double allsum = shoes + equipment + ball + accessories + feePeryear;

//printirame rezultata

Console.WriteLine(allsum);
