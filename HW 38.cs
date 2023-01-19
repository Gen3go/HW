// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] Array(int size)
{
    int[] array = new int[size];
    Random rdm = new Random();
    for(int i = 0; i < array.Length; i++) 
    array[i] = rdm.Next(1, 100);
    return array;
}

// void GetRandomArray(int[] array)
// {
//     Random rdm = new Random();
//     for(int i = 0; i < array.Length; i++) 
//     array[i] = rdm.Next(1, 100);
    
// }
void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}


int SubMaxMin(int[] array)
{
  int max = array[0];
  int min = array[0];
  for(int i = 1; i < array.Length; i++)
  {
    if(array[i] > max)
        max = array[i];
  
    if (array[i] < min)
        min = array[i];

  }
  int sub = max - min;
  return sub;
}
int size = 4;
int[] array = Array(size);
// GetRandomArray(array);
PrintArray(array);
int sub = SubMaxMin(array);
System.Console.WriteLine(sub);