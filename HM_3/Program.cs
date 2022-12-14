Console.WriteLine("Введите количество строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Random random = new Random();
 Console.WriteLine("Сгенерированный массив:");
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        array2d[i, j] = random.Next(1, 10);
       
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Количество строк - "+ array2d.GetLength(0));
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");


for (int j = 0; j < array2d.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        sum += array2d[i, j];
    }
   Console.Write($"{ sum / array2d.GetLength(0)} ");
} 