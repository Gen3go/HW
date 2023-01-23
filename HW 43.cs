// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputDigit(string messege)
    {
        System.Console.WriteLine(messege);
        int a = Convert.ToInt32(Console.ReadLine());
        return a;
        
    }


double k1 = InputDigit("Введите параметр к1");
double k2 = InputDigit("Введите параметр к2");
double b1 = InputDigit("Введите параметр b1");
double b2 = InputDigit("Введите параметр b2");


