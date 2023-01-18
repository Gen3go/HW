// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] Array(int size)
{

    int[] array = new int [size];
    return array;

}

void FindArray(int[] array)
{
    Random rnd = new Random();
        for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(10, 100);

}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));

}

int SummOddPositionNumbers(int [] array)
{
    int summ = 0;

    for(int i = 0; i < array.Length; i = i + 2)
        summ = summ + array[i];
        return summ;

}

int size = 4;

int[] array = Array(size);
FindArray(array);
PrintArray(array);
int summ = SummOddPositionNumbers(array);
System.Console.WriteLine(summ);