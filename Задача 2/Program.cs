// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine());
if (daynumber > 0 && daynumber < 8)
{
    if (daynumber == 1) Console.WriteLine("Выбранный день: Понедельник");
    if (daynumber == 2) Console.WriteLine("Выбранный день: Вторник");
    if (daynumber == 3) Console.WriteLine("Выбранный день: Среда");
    if (daynumber == 4) Console.WriteLine("Выбранный день: Четверг");
    if (daynumber == 5) Console.WriteLine("Выбранный день: Пятница");
    if (daynumber == 6) Console.WriteLine("Выбранный день: Суббота");
    if (daynumber == 7) Console.WriteLine("Выбранный день: Воскресенье");
}
else{
    Console.WriteLine("Неверный номер дня недели");
}
