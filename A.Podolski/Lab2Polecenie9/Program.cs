using System;

class Program
{
    static void Main()
    {
        // Wprowadzenie imienia użytkownika
        Console.Write("Wprowadź swoje imię: ");
        string imie = Console.ReadLine();

        // Wprowadzenie liczby wyświetleń
        Console.Write("Ile razy chcesz wyświetlić swoje imię? ");
        int liczbaWyswietlen;
        while (!int.TryParse(Console.ReadLine(), out liczbaWyswietlen) || liczbaWyswietlen <= 0)
        {
            Console.Write("Proszę podać dodatnią liczbę całkowitą: ");
        }

        // Wyświetlenie imienia określoną liczbę razy
        for (int i = 1; i <= liczbaWyswietlen; i++)
        {
            Console.WriteLine(imie);
        }

        // Zgłoszenie zakończenia realizacji zadania
        Console.WriteLine("Zakończenie realizacji polecenia.");
    }
}
