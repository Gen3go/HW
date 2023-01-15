
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("Введите число:  ");

int N = int.Parse(Console.ReadLine());

int Digits(int N){

    if( N<10 )
    return N;

    int num1 = N%10;
    int num2 = N/10;

    return num1 + Digits(num2);

}

int result  = Digits(N);

System.Console.WriteLine(result);

///////////////////////////////////////

int CountDigits(int inputNumber)
{

    int countDigit = 0;
    for(; inputNumber > 0; countDigit++)
    inputNumber /= 10;

    return countDigit;
   
}

int Summ(int inputNumber, int countDigit)
{
    int summ = 0;

    if (countDigit > 0){ 
            
            int digit = inputNumber % 10;
            summ = summ + countDigit;
            inputNumber = inputNumber / 10;
           
    }
     
     return summ;

}

System.Console.WriteLine("Введите число ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(inputNumber));
System.Console.WriteLine(Summ(inputNumber));


