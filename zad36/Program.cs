// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] array = new int[10];
Console.WriteLine("");
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100);
string str = string.Join(",", array);
Console.WriteLine($"Массив: {str}");
int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
    Console.WriteLine($"Элемент позиции {i}: {array[i]}");
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
