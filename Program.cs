// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
int result = 0;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 1000);
Console.WriteLine(array[i]);

if (array[i] % 2 == 0)
{
    result = array[i] + array[i]%2;
    count++;
}
}
Console.WriteLine($" > {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write($"Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(1, 9);
        Console.Write(randomArray[i] + " ");
    }
}

int kol(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}
mas(a);

Console.Write($"Cумма элементов, стоящих на нечётных позициях: {kol(randomArray)}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

class Program
{
    static void Main(string[] args)
    {
        double min = double.MaxValue;
        double max = double.MinValue;
        double k;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введите {0}-е число: ", i + 1);
            k = double.Parse(Console.ReadLine());

            if (k > max)
                max = k;

            if (k < min)
                min = k;
        }
        Console.WriteLine("Разница между макс и мин: {0}", max - min);
        Console.ReadKey();
    }
}