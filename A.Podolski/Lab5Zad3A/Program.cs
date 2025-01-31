using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Poproś użytkownika o podanie ścieżki
        Console.Write("Podaj ścieżkę: ");
        string sciezka = Console.ReadLine();

        // Wywołanie funkcji i wyświetlenie wyniku
        string wynik = SprawdzSciezke(sciezka);
        Console.WriteLine(wynik);
    }

    // Funkcja sprawdzająca, czy ścieżka jest do pliku czy katalogu
    static string SprawdzSciezke(string sciezka)
    {
        if (File.Exists(sciezka))
        {
            return "To jest plik.";
        }
        else if (Directory.Exists(sciezka))
        {
            return "To jest katalog.";
        }
        else
        {
            return "Ścieżka nie istnieje.";
        }
    }
}
