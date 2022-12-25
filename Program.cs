//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Введите число A: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int num1 = int.Parse(Console.ReadLine()!);

if (num > num1)
{
    Console.WriteLine("A больше B");
}
else
{
    if (num < num1)
   {
       Console.WriteLine("B больше A");
    }
}


//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.Write("Введите число A: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число C: ");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"Максимальное число = {max}");


//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.Write("Запишите число: ");
int number = int.Parse(Console.ReadLine()!);

if(number%2==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}


//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите число N : ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N)
{
    if(i % 2 == 0)
    {
        Console.Write ($"{i}");
    }
    i++;
}