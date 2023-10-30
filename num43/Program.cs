double FindX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
    
}
double FindY(double x, double b1, double k1)
{
    double y = k1 * x + b1;
    return y;
}
System.Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"({FindX(b1,k1,b2,k2)};{FindY(FindX(b1,k1,b2,k2), b1,k1)})");