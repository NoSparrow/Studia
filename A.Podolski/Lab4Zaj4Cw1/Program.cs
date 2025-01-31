using System;

class Program
{
    static void Main()
    {
        // Poproszenie użytkownika o podanie liczby
        Console.Write("Podaj liczbę: ");
        int n = int.Parse(Console.ReadLine());

        // Sprawdzenie, czy liczba jest pierwsza
        if (n <= 1)
        {
            Console.WriteLine("Liczba musi być większa od 1.");
        }
        else
        {
            bool jestPierwsza = true;

            // Sprawdzanie dzielników od 2 do pierwiastka z n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    jestPierwsza = false;
                    break;
                }
            }

            // Wyświetlanie wyniku
            if (jestPierwsza)
            {
                Console.WriteLine($"{n} jest liczbą pierwszą.");
            }
            else
            {
                Console.WriteLine($"{n} nie jest liczbą pierwszą.");
            }
        }
    }
}
