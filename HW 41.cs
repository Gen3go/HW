
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int SummNotZero(int[] array)
{   
    int sum = 0;

    for ( int i = 0; i < array.Length; i++)
    { 
        if (array[i] > 0)
 
        sum = sum + 1;
        
    }
    return sum;
}

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите цифры массива");
int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
     {
        array[i] = Convert.ToInt32(Console.ReadLine()); 
     }
    
    for ( int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }

int summ = SummNotZero(array);
System.Console.WriteLine();
System.Console.WriteLine("Сумма чисел больше нуля: " + summ);
