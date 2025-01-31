using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Podajemy katalog, w którym szukamy plików
        Console.Write("Podaj ścieżkę do katalogu: ");
        string katalog = Console.ReadLine();

        // Sprawdzamy, czy katalog istnieje
        if (Directory.Exists(katalog))
        {
            // Pobieramy wszystkie pliki tekstowe (*.txt) w danym katalogu
            string[] pliki = Directory.GetFiles(katalog, "*.txt");

            // Sprawdzamy, czy znaleziono jakiekolwiek pliki
            if (pliki.Length > 0)
            {
                Console.WriteLine("Znalezione pliki tekstowe:");
                // Wypisujemy nazwy plików
                foreach (string plik in pliki)
                {
                    // Wyświetlamy tylko nazwę pliku, a nie całą ścieżkę
                    Console.WriteLine(Path.GetFileName(plik));
                }
            }
            else
            {
                Console.WriteLine("Brak plików tekstowych w podanym katalogu.");
            }
        }
        else
        {
            Console.WriteLine("Podany katalog nie istnieje.");
        }
    }
}
