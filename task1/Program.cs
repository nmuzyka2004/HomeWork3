/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
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

void isItPalindrome(int number)
{
string numberStr = Convert.ToString(number);
if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
{
    Console.WriteLine("Да, это палиндром");
}
else 
{
    Console.WriteLine("Нет, это не палиндром"); 
}
}

int number = GetNumber("Введите пятизначное число");  
isItPalindrome(number);