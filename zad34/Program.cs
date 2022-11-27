// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
}
int count = 0;
Console.WriteLine("Четные числа массива:");
foreach (int n in array)
{
    if (n % 2 == 0)
    {
        count = count + 1;
        Console.Write($"{n} ");
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных числе в массиве: {count}");
string str = string.Join(",", array);
Console.WriteLine($"Весь массив: {str}");
