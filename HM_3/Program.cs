Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];

 for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine("Введите число ");
                array2d[i,j] = int.Parse(Console.ReadLine());
            }
        }

Console.WriteLine("Созданный массив: ");

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Количество строк - "+ array2d.GetLength(0) + ";  Количество столбцов - " + array2d.GetLength(1));
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