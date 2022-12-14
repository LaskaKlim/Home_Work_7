Console.WriteLine("Для генерации массива введите количество строк");
int linVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число,которое необходимо найти");
int numb = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[linVol, colVol];
FillArrayRandomNumbers(array);
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
}
PrintArray(array);
PrintResult(array);

int f = 0; 

void PrintResult(int[,] array)
{
        f = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                
                if (array[i,j]==numb)
                {
                   f =1;
                    Console.Write($"Элемент находится на позиции {i},{j}; ");
                    break;
                }
            
                 
            }
             
        }  
if (f == 0) Console.WriteLine ($" Элемент {numb} не найден");       
} 

 


void PrintArray(int[,] array)
{
    Console.WriteLine("Сгенерирован массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
