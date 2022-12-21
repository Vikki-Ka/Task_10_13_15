/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Clear();
Console.Write("Ввидите число от 1 до 7 ");
int number = int.Parse(Console.ReadLine()!);

void Holidays(int digital)
{
    if (digital > 0 && digital < 8)
    {
        if (digital == 6 || digital == 7)
        {
            Console.Write("Это выходной день!");
        }
        else
        {
            Console.Write("Это не выходной день!");
        }
    }
    else
    {
        Console.Write("Ввидите число от 1 до 7 :)))");
    }
} 

Holidays(number);