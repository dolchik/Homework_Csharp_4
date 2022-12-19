// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int EntryDigit(string str) // пользователь вводит число цифр в массиве и мы его считываем
{
Console.Write(str);
int number = int.Parse(Console.ReadLine());
return number;
}

int ExponenNum(int numbA, int numbB) //цикл возведения числа А в число В
{
    int result = 1;
    for (int i = 0; i < numbB; i++)
    {
        result = result * numbA;
    }
    return result;
}

int numbA = EntryDigit("Введите число А: ");
int numbB = EntryDigit("Введите числов В: ");
int result = ExponenNum(numbA, numbB);
Console.WriteLine($"{numbA}, {numbB} -> {result}");