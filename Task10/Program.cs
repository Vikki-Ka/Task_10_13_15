/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.Write("ввидите трехзначное число ");
int number1 = int.Parse(Console.ReadLine()!);

int SecondDigit(int digital)
{
    int two = digital % 100; // берем два последних числа
    int one = two / 10; // берем второе число
    return one;
}

int second = SecondDigit(number1);
Console.Write($"В числе {number1} вторая цифра {second}");