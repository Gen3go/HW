

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] Array(int size)
{

    int[] array = new int [size];
    return array;

}

void FindArray(int[] array)
{
    Random rnd = new Random();
        for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 1000);

}

string GetArray(int[] array)
{
    return String.Join(",", array);

}
void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArray(array));
}

int SummEvenNumbers(int[] array)
{   
    int summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] / 2 % 2 == 0)
         summ+=1;
    }
    return summ;

}   


int size = 4;
int[] array = Array(size);
FindArray(array);
PrintArray(array);
int summ = SummEvenNumbers(array);
System.Console.WriteLine(summ);