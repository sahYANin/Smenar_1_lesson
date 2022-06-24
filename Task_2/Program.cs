/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/

int NumA = Convert.ToInt32(Console.ReadLine());
int NumB = Convert.ToInt32(Console.ReadLine());
int NumC = Convert.ToInt32(Console.ReadLine());
//*
int Max = NumA;
//
if (Max > NumB) NumB = 0; //NumB = 0 - чтобы консоль "не ругалась"
else Max = NumB;
if (Max > NumC) NumC = 0;
else Max = NumC;

Console.WriteLine(Max);




/*   наброски//мусор
if (NumA > NumB) Console.WriteLine(NumA);
if (NumB > NumC) Console.WriteLine(NumB);
if (NumC > NumA) Console.WriteLine(NumC);

if (NumA > NumB) Max = NumA;
if (NumA > NumC) Max = NumA;
if (NumB > NumC) Max = NumB;
if (NumB > NumA) Max = NumB;
if (NumC > NumA) Max = NumC;
if (NumC > NumB) Max = NumC;


int[] Max = new int[3] {NumA, NumB, NumC};

*/