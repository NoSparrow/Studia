
/*
Int32 a;
Console.WriteLine("Podaj liczbę");
a = Int32.Parse(Console.ReadLine());
switch (a)
{
    case 0:
    {
        Console.WriteLine("Zero");
    }
    break;
    case 1:
    {
        Console.WriteLine("Jeden");
    }
    break;
    case 2:
    {
        Console.WriteLine("Dwa");
    }
    break;
    default:
    {
        Console.WriteLine("Nie wiem");
    }
    break;
}
*/


using System;

class Program
{
    static void Main()
    {
        // Wczytanie współczynników a, b, c
        Console.Write("Podaj a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Obliczenie delty
        double delta = b * b - 4 * a * c;
        int liczbaPierwiastkow;

        // Określenie liczby pierwiastków (instrukcja if)
        if (delta > 0)
        {
            liczbaPierwiastkow = 2;
        }
        else if (delta == 0)
        {
            liczbaPierwiastkow = 1;
        }
        else
        {
            liczbaPierwiastkow = 0;
        }

        // Obliczenie i wyświetlenie wyników (switch...case)
        switch (liczbaPierwiastkow)
        {
            case 2:
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Dwa pierwiastki: x1 = {x1}, x2 = {x2}");
                break;

            case 1:
                double x = -b / (2 * a);
                Console.WriteLine($"Jeden pierwiastek: x = {x}");
                break;

            case 0:
                Console.WriteLine("Brak pierwiastków rzeczywistych.");
                break;
        }
    }
}
