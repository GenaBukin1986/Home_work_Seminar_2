// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите день недели (1 до 7): ");
int num = int.Parse(Console.ReadLine());
if (num > 0 && num < 8) 
    {
    if (num < 6) Console.WriteLine("нет");
    else Console.WriteLine("да");
     }
else Console.WriteLine("Нет такого дня недели");