// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
void createArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            array[countOne, countTwo] = new Random().Next(-100000, 100000) / 10;
        }
    }
}
Console.Write("Введите номер строки для поиска числа в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца для поиска числа в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[7, 5];// Размер массива фиксированный, в условии не сказано, что бы размер задавал пользователь
createArray(array);
// Даллее проверка:
if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("Число с такими координатами в данном массиве отсутствует!");
}
else
{
    Console.WriteLine($"Число в строке {n} и столбце {m}: {array[n - 1, m - 1]}");
}
Console.WriteLine("Всего доброго!");
