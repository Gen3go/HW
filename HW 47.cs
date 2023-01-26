// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Array(int [,] array)

{   Random rd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rd.Next(-3, 3);
            
            }
        
        }
            
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)

                {
                    System.Console.Write(array[i, j] + " ");
                }
            System.Console.WriteLine();

        }
}
int m = 3;
int n = 4;
int[,] array = new int [m, n];

Array(array);
PrintArray(array);