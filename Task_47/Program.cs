// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.Write("Введите первый размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
void createArray(double[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            array[countOne, countTwo] = Convert.ToDouble(new Random().Next(-1000000, 1000000)) / 10; 
                                       // "/10" для того, что бы в массиве были числа с одной цифрой после запятой
        }
    }
}
void PrintArray(double[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            Console.Write(array[countOne, countTwo] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
createArray(array);
PrintArray(array);
Console.WriteLine("**Всего доброго!**");