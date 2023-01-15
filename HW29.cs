// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int[8];

Random rd = new Random();
for (int i=0; i < array.Length; i++)
{
    array[i] = rd.Next(-3, 3);
    System.Console.Write(array[i] + ",");
}
