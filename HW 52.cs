// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
                    System.Console.Write(array[i, j] + " ");
                }
            System.Console.WriteLine();
        }
}

void FindRithmeticNumber(int [,] array)
 {   int Rithmetic = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        {  
            for(int j = 0; j < array.GetLength(0); j++)
            {   
                if( [j] = 0; )
                Rithmetic += array[i, j];
            }

        }

}

int[,] array = new int [3, 4];
Array(array);
PrintArray(array);
FindRithmeticNumber(array);
