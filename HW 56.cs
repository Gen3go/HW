// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

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

int SummLine(int [,] array, int i)
{
    int summ = 0;
    for( int j = 0; j < array.GetLength(1); j++)
        summ += array[i, j];
        return summ;
}
int FindMinLineArray(int [,] array)
{ 
    int min = SummLine(array, 0);
    int index = 0;

    for(int i = 1; i < array.GetLength(0); i++)
    {
        int currentsumm = SummLine(array, i);
        if(currentsumm < min)
        {
            min = currentsumm;
            index = i;
        }
    }
    return index + 1;
}

int [ , ]array =
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
{5, 2, 6, 7}
};

PrintArray(array);
int min = FindMinLineArray(array);
System.Console.WriteLine("Минимальная строка: " + min);