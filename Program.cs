//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(100, 1000);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Count(); i++)
    {
        if (i == array.Count() - 1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}

int CalcEvenNumberArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Count(); i++) if (array[i] % 2 == 0) result += 1;
    return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
ShowArray(array);
Console.Write($"Количество четных чисел в массиве равно: {CalcEvenNumberArray(array)}");*/



//Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(-99, 100);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Count(); i++)
    {
        if (i == array.Count() - 1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}

int SumOddElementArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Count(); i+=2) result += array[i]; //с учётом, что 0 элемент четный
    return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
ShowArray(array);
Console.Write($"Сумма нечетных элементов массива равна: {SumOddElementArray(array)}");*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.0 7.2 22.7 2.1 78.3] -> 76.2

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++) array[i] = new Random().NextDouble() * 100;
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Count(); i++)
    {
        if (i == array.Count() - 1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}

double DiffMaxMinArray(double[] array)
{
    int iMin = 0, iMax = 0;
    for (int i = 1; i < array.Count(); i++)
    {
        if (array[i] > array[iMax]) iMax = i;
        else if (array[i] < array[iMin]) iMin = i;
    }
    return array[iMax] - array[iMin];
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(size);
ShowArray(array);
Console.Write($"Разница между максимальным и минимальным элементами массива равна: {DiffMaxMinArray(array)}");