using System;

class Program
{
    static void Main()
    {
        Random liczbaLosowa = new Random();
        int liczba = liczbaLosowa.Next(0, 101); // Losowanie liczby z przedziału 0-100
        int proba = 0;
        int maxProby = 6;
        int odgadniecie;

        Console.WriteLine("Zgadnij liczbę, którą komputer wylosował! Liczba mieści się w przedziale od 0 do 100.");
        
        while (proba < maxProby)
        {
            proba++; // Zwiększenie numeru próby
            Console.Write($"Próba {proba} z {maxProby}: Podaj liczbę: ");
            odgadniecie = int.Parse(Console.ReadLine()); // Wczytanie odpowiedzi użytkownika

            if (odgadniecie == liczba)
            {
                Console.WriteLine($"Gratulacje! Odgadłeś liczbę {liczba} w {proba} próbach.");
                break; // Zakończenie gry, jeżeli użytkownik odgadł liczbę
            }
            else if (odgadniecie < liczba)
            {
                Console.WriteLine("Wylosowana liczba jest większa.");
            }
            else
            {
                Console.WriteLine("Wylosowana liczba jest mniejsza.");
            }

            if (proba == maxProby)
            {
                Console.WriteLine($"Niestety, nie udało się odgadnąć liczby. Wylosowana liczba to {liczba}.");
            }
        }

        // Zakończenie programu
        Console.WriteLine("Koniec gry. Dziękujemy za grę!");
        Console.ReadKey();
    }
}
