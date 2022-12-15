Console.WriteLine("Введите количество строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];

 for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine("введите числа ");
                array2d[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}

// Random random = new Random();
// for (int i = 0; i < m; i++)
// {
//   for (int j = 0; j < n; j++)
//   {
//   array2d[i, j] = random.Next(-10,10);
//   Console.Write(array2d[i, j] + " "); 
//   }
//  
// }