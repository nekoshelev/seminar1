// 3. Напишите программу вычисления функции:
 //x = f(a)
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int resF = number*number*number;

Console.WriteLine($"Куб числа {number} равен: {resF}");
