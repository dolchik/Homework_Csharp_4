// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int EntryDigit(string str) // пользователь вводит число цифр в массиве и мы его считываем
{
Console.Write(str);
int number = int.Parse(Console.ReadLine());
return number;
}

int FindSum(int UserDigit) //сумма цифр в числе
{
    int sum;
    for (sum = 0; UserDigit > 0; UserDigit = UserDigit / 10)
    {
        int count = UserDigit % 10; // остаток от деления
        sum = sum + count;
    }
    return sum;
}

int number = EntryDigit("Введите число: ");
int result = FindSum(number);
Console.WriteLine($"{number} -> {result}");