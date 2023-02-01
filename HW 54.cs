// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

int Input(string messege)
    {
        System.Console.WriteLine(messege);
        int a = Convert.ToInt32(Console.ReadLine());
        return a;
        
    }

void Array(int [,] array)

{   Random rd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rd.Next(1, 10);
            
            }
        
        }            
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)

                {
                    System.Console.Write(string.Format("{0,3}", array[i, j] + " "));
                }
            System.Console.WriteLine();
        }
}

void SwapElements(int [,] array, int i, int j, int k)
{         
      int temp = array[i,k];
      array[i,k] = array[i,j];
      array[i,j] = temp;
                
}
void ArrayReduce(int [,] array)
{ 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for( int k = j + 1; k < array.GetLength(1); k++)
        
                if( array[i,j] < array[i,k] )
                SwapElements(array, i, j, k);
        
        }
    }
}

int m = Input("Введите количество строк: ");
System.Console.WriteLine();
int n = Input("Введите количество столбцов: ");

int [ , ]array = new int[m, n];
Array(array);
PrintArray(array);
ArrayReduce(array);
System.Console.WriteLine();
PrintArray(array);
