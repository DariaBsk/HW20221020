// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
//(целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


bool Palindrome(int number)
{
    int first = number / 10000;
    int second = number / 1000 % 10;
    int forth = number % 100 / 10;
    int fifth = number % 10;

    return (first == fifth && second == forth);

}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numAbs = Math.Abs(num);
if (numAbs > 99999 || numAbs < 10000)
{
    Console.WriteLine($"Число {num} некорректно");
}
else
{
    bool palindrome = Palindrome(numAbs);
    if (palindrome)
        Console.WriteLine($"Число {num} является палиндромом");
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}



