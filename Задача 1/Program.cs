// 1. Напишите программу, которая на вход принимает два числа и проверяет, 
//    является ли первое число квадратом второго.
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да
Console.WriteLine("Введите число А");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = int.Parse(Console.ReadLine());

if (numA*numA == numB) // Сравнение чисел
{
    Console.WriteLine($"Число {numB}, является квадратом числа {numA}");
}
else
{
    Console.WriteLine($"Число {numB}, не является квадратом числа {numA}");   
}