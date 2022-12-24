
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = num1 / 100;

if (num2 < 1)
{
System.Console.WriteLine("Третьей цифры нет");
}

if (num2 > 1)
{
System.Console.WriteLine(num1 % 10);
}