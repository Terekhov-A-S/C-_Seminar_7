// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
void createArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            array[countOne, countTwo] = new Random().Next(0, 11);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            Console.Write(array[countOne, countTwo] + " ");
        }
        Console.WriteLine("");
    }
}
Console.WriteLine("Создадим массив чисел от '0' до '10' и найдем среднее арифметическое в каждом столбце");
Console.Write("Введите желаемое количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите желаемое количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
createArray(array);
for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
{
    double arr = 0;
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        arr = (arr + array[countOne, countTwo]);
    }
    arr = arr / n;
    Console.Write(arr + "; ");
}
Console.WriteLine();
PrintArray(array);
Console.WriteLine("Всего доброго!");
