// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число N");
int numN = int.Parse(Console.ReadLine());

int count = 2;
if(numN > 1)
{
while (count <= numN)
{
    Console.Write(count+" ");
    count = count + 2;
}
}
else
{
   Console.WriteLine("Не возможно вывести четные числа, т.к. вводимое число меньше или равно 1"); 
}