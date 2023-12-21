using System;
public class Program
{
    public static void Main()
    {
        double a, b, c, p, k;
        Console.WriteLine("Podaj a: ");
        a = Double.Parse(Console.ReadLine());
        
        Console.WriteLine("Podaj b: ");
        b = Double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj c: ");
        c = Double.Parse(Console.ReadLine());
        
        Console.WriteLine("Podaj początek przedziału: ");
        p = Double.Parse(Console.ReadLine());
        
        Console.WriteLine("Podaj koniec przedziału: ");
        k = Double.Parse(Console.ReadLine());

        Console.WriteLine("Całka: " + Calkowanie(a, b, c, p, k));
    }

    static double Calkowanie(double a, double b, double c, double p, double k)
    {
        int d = 1000;
        double w = (k - p) / d;
        double wynik = (Kwadrat(a, b, c, p) + Kwadrat(a, b, c, k)) / 2;

        for (int i = 1; i < d; i++)
        {
            double y = p + i * w;
            wynik += Kwadrat(a, b, c, y);
        }

        return wynik * w;
    }

    static double Kwadrat(double a, double b, double c, double x)
    {
        return a * x * x + b * x + c;
    }
}