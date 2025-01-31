using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Poproś użytkownika o podanie ścieżki do pliku
        Console.Write("Podaj ścieżkę do pliku .txt: ");
        string sciezkaPliku = Console.ReadLine();

        // Sprawdzenie, czy plik istnieje
        if (File.Exists(sciezkaPliku))
        {
            // Zmienna do zliczania linii
            int licznikLinii = 0;

            // Użycie StreamReader do odczytania pliku
            using (StreamReader reader = new StreamReader(sciezkaPliku))
            {
                string linia;
                while ((linia = reader.ReadLine()) != null)
                {
                    licznikLinii++;
                }
            }

            // Wyświetlenie liczby linii
            Console.WriteLine($"Liczba linii w pliku: {licznikLinii}");
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }
}
