//                            Задача 19

//  Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление,
// остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите пятизначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 9999 && number <= 99999)
{
    int a = number % 10;
    int b = number / 10 % 10;
    int c = number / 100 % 10;
    int d = number / 1000 % 10;
    int e = number / 10000;

    if (a == e && b == d)
        Console.WriteLine($"Число {number} - палиндром");
    else
        Console.WriteLine($"Число {number} - не палиндром");
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число!");
}