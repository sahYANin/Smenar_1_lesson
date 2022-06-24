/*
Задача 8: Напишите программу, которая на вход 
принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
// Да я специально так сделал, все под одним циклом int-ы, и как не странно работает))
for (int Num = Convert.ToInt32(Console.ReadLine()),
    i = 2; Num >= i; i = i + 2)
{
    Console.WriteLine(" ");// что бы были пробелы 
    Console.WriteLine(i);
}


// Кстати сори меня не было на семинаре, был на работе(




/*

if (Num >= i) p++;
else
{
    Console.WriteLine(i);
    i = i + 2;
}





/*

while (Num == 0)
{
    if (Num % 2 == 1) p++;
    else Console.WriteLine(Num);
    Num = Num - 1;
}

while (Num <= i)
{
    if (Num == i) Console.WriteLine(i);
    i = i + 2;
}


int Num = Convert.ToInt32(Console.ReadLine());
int i = 2;
int p = 0;

if (Num >= i) p++;
else
{
    Console.WriteLine(i);
    i = i + 2;
}



*/

