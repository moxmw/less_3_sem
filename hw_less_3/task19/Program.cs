// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());

if (Palindrome(num))
{
    Console.WriteLine("Ваше число является палиндромом.");
}
else
{
    Console.WriteLine("Ваше число не является палиндромом.");
}

static bool Palindrome(int num)
{
    string strNum = num.ToString();
    int length = strNum.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (strNum[i] != strNum[length - i - 1])
        {
            return false;
        }
    }
    return true;
}
