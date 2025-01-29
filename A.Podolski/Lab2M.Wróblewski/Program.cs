/*
 y = a * (x^2) + bx + c
 1. Pobrać wartości a, b, c, od użytkowniaka
 2. Sprawdzić czy równanie jest kwadratowe a = 0 ? 
 3. Policzyć delte 
    Δ = b^2 - 4ac
 4. Sprawdzić czy:
    Δ < 0 - brak pierwiastków
    Δ = 0 - jeden pierwiastek x0 = (-b) / 2a
    Δ > 0 - dwa pierwiastki:
        x1 = (-b - √Δ) / 2a
        x2 = (-b + √Δ) / 2a 
 */







using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wartość a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wartość b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wartość c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        string wynik = ObliczPierwiastki(a, b, c);
        Console.WriteLine(wynik);
    }

    static string ObliczPierwiastki(double a, double b, double c)
    {
        if (a == 0)
        {
            return "To nie jest równanie kwadratowe.";
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            return "Brak pierwiastków rzeczywistych.";
        }
        else if (delta == 0)
        {
            double x0 = -b / (2 * a);
            return $"Jeden pierwiastek: x0 = {x0:F3}";
        }
        else
        {
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b - sqrtDelta) / (2 * a);
            double x2 = (-b + sqrtDelta) / (2 * a);
            return $"Dwa pierwiastki: x1 = {x1:F3}, x2 = {x2:F3}";
        }
    }
}
