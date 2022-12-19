// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке
// [1, 0, 1, 1, 0, 1, 0, 0]

int EntryDigit(string str) // пользователь вводит число цифр в массиве и мы его считываем
{
Console.Write(str);
int number = int.Parse(Console.ReadLine());
return number;
}

void RandomArray (int[] arr)
{
    int i;
    for (i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + ", ");
    }
}

int index = EntryDigit("Введите длинну массива: ");
int[] array = new int[index];
RandomArray(array);
PrintArray(array);
