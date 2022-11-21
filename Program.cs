//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223 -> 4

/*int[] EnterNumbers(int totalNumebers)
{
    int[] array = new int[totalNumebers];
    for (int i = 0; i < totalNumebers; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CalcPositivNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Count(); i++) if (array[i] > 0) result += 1;
    return result;
}

Console.Write("Укажите сколько чисел вы введёте: ");
int totalNumebers = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введено {CalcPositivNumbers(EnterNumbers(totalNumebers))} чисел болше нуля: ");*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] point = new double[2];
    point[0] = (b1 - b2) / (k2 - k1);
    point[1] = k2 * ((b1 - b2) / (k2 - k1)) + b2;
    return point;
}

Console.Write("Введите знгачение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите знгачение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите знгачение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите знгачение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Точка пересечения прямых: ({IntersectionPoint(k1, b1, k2, b2)[0]}, {IntersectionPoint(k1, b1, k2, b2)[1]}) ");