// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void GetNumberArray(int [,] array, int g)
{  foreach(int el in array)
        {
        if(array[i, j] == g)
        System.Console.WriteLine("Число "+ g + " есть в массиве");  
        else if (array[i, j] != g)
        System.Console.Write(g + "  Такого числа в массиве нет");
        }
}


System.Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число для проверки");
int g = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m, n];

Array(array);
PrintArray(array);
System.Console.WriteLine();
GetNumberArray(array, g);


