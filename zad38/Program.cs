// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
float[] array = new float[10];
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-100, 100);
Console.WriteLine("Выводим массив: ");
foreach (int n in array)
    Console.WriteLine(n);
float min = array[0];
float max = array[0];
foreach (int n in array)
{
    if (n < min) min = n;
    if (n > max) max = n;
}
Console.WriteLine($"Самое большое число: {max}, самое маленькое число: {min}, разница между ними равна: {max - min}");

