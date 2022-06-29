// *. Напишите программу вычисления модуля числа.
//	2 -> 2
//	-3 -> 3
//	-7 -> 7

Console.WriteLine("Введите число: ");
int numN = int.Parse(Console.ReadLine());

if (numN > 0)
{
    Console.WriteLine($"Модуль числа {numN} равен: {numN}");
}
else
{
    Console.WriteLine($"Модуль числа {numN} равен: {-numN}");
}