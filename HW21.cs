
double Vector(string name)
{
    Console.WriteLine(name);
    double vector = Convert.ToDouble(Console.ReadLine());
    return vector;

}

double Ax = Vector("Введите Ах");
double Ay = Vector("Введите Аy");
double Az = Vector("Введите Аz");
double Bx = Vector("Введите Bx");
double By = Vector("Введите By");
double Bz = Vector("Введите Bz");


double AB = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
System.Console.WriteLine(AB);