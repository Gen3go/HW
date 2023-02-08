// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void FillArray (int[] array, int n)
{
    Random rd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rd.Next(1, 100);
    }
}

void PrintArray(int[] array, int n)
{
    Console.WriteLine(string.Join(",", array));
}

int SummElemenstArray(int[] array, int m, int n)
{
    int summ = 0;
    
    for (int i = 0; i < array.Length; i++)
        {   if (array[i] > m && array[i] < n)
               summ = array[i] + summ;
        }
    return summ;
}

int m = 1;
int n = 15;
int[] array = new int[n];

FillArray(array, n);
PrintArray(array, n);

int summEl = SummElemenstArray(array, m, n);

System.Console.WriteLine(summEl);



 
