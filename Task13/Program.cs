/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();
Console.Write("Ввидите число ");
int number = int.Parse(Console.ReadLine()!);

int NumberDigital (int digit) // считаем количество цифр в числе
{
    int i = 1;
    int delit = 10;

    while(true)
    {
        int dec = digit / delit; // перебераем число по цифре узнаем сколько цифр
        if (dec !=0)
        {
            i++;
            delit = delit * 10;
        }
    else 
    {
        break;
    }
    }
    return i;
}

void ThirdDigital(int digital, int totaldigit ) // находим третье цисло слева на право
{
    int ten = 1;
    if (totaldigit >= 3)
    {
        while (totaldigit >= 4) 
        {
            totaldigit = totaldigit - 1;
            ten = ten * 10;
        }
        int third1 = digital / ten;
        int third = third1 % 10;
        Console.WriteLine(third);
    }
    else 
    {
        Console.WriteLine("Третьей цифры нет");   
    } 
}

ThirdDigital(number, NumberDigital(number));