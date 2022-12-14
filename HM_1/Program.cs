Console.WriteLine("Введите количество строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
  for (int j = 0; j < n; j++)
  {
  array2d[i, j] = random.Next(-10,10);
  Console.Write(array2d[i, j] + " "); 
  }
  Console.WriteLine();
}