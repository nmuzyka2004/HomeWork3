﻿/* Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число");
        }
    }
    return result;
}

void PrintCubeTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
      Console.WriteLine($"{Math.Pow(i, 3)}, ");  
    }
}

int number = GetNumber("Введите число");  
PrintCubeTable(number);
