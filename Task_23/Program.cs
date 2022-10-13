//                            Задача 23

//  Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


void CubeNumbers(int num)
{
    int i = 1;
    Console.WriteLine($"Таблица кубов чисел от 1 до {num}:");
    while (i <= num)
    {
        Console.WriteLine($"\t {i} | {Math.Pow(i, 3)} ");
        i++;
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeNumbers(number);