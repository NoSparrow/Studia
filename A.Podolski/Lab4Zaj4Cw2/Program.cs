using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Liczby pierwsze mniejsze od 100:");

        // Przechodzimy po liczbach od 2 do 99
        for (int n = 2; n < 100; n++)
        {
            bool jestPierwsza = true;

            // Sprawdzamy, czy liczba n jest liczbą pierwszą
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    jestPierwsza = false;
                    break;
                }
            }

            // Jeśli liczba jest pierwsza, wypisujemy ją
            if (jestPierwsza)
            {
                Console.WriteLine(n);
            }
        }
    }
}
