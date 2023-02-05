// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummElemenstArray(int[]array, int m, int n)
    { int summ = 0;
      array[0] = m;
        for(int i = 0; i < array.Length; i++)
            if(array[i] <= n)
        {
            summ = array[i] + summ;
            array[i + 1] = array[i] + 1;
        }
        return summ;
    }


int m = 1;
int n = 15;
int [] array = new int [n];
int summEl = SummElemenstArray(summ);
System.Console.WriteLine(summEl);



 
