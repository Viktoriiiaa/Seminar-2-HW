//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Write("Введите трёхзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Num} -> {Num / 10 % 10}");
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int Num1 = Num;
if (Num < 100)
{
    Console.WriteLine($"{Num} -> третьей цифры нет ");
}
else
{
    while (Num1 >= 1000)
    { 
        Num1 = Num1 / 10;
    }
    Console.WriteLine($"{Num} -> {Num1 % 10 % 10}");
}
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Введите номер дня недели: ");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num > 0 && Num < 6) 
{
    Console.WriteLine($"{Num} -> будний день");
}
else if (Num == 6 || Num == 7)
{
    Console.WriteLine($"{Num} -> выходной");
}
else
{
    Console.WriteLine($"{Num} -> такого дня недели нет");
}
*/