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

double FindRithmeticNumber(int [,] array)
 {  double summ1 = 0; 
    double count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == 0)
            summ1 +=array[i, j];   
        }
        count = summ1 / array.GetLength(1);
    }
return count;
}

int[,] array = new int [3, 4];
Array(array);
PrintArray(array);
double summ1 = FindRithmeticNumber(array);
double summ2 = FindRithmeticNumber(array);
double summ3 = FindRithmeticNumber(array);
System.Console.WriteLine();
System.Console.WriteLine("Среднеарифметическое 1й строки: " + summ1 + " Среднеарифметическое 2й строки: " + summ2 + " Среднеарифметическое 3й строки: " + summ3);

