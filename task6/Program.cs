// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

Console.WriteLine("Введите число: ");
double numN = double.Parse(Console.ReadLine());

if(numN != 0)
{
    Console.WriteLine($"Обратное значение числа {numN} равно {1/numN} ");
}
else
{
    Console.WriteLine($"У числа {numN} нет обратного значения");
}