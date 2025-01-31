using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Poproś użytkownika o ścieżkę źródłowego katalogu
        Console.Write("Podaj ścieżkę do katalogu źródłowego: ");
        string katalogZrodlowy = Console.ReadLine();

        // Poproś użytkownika o ścieżkę docelowego katalogu
        Console.Write("Podaj ścieżkę do katalogu docelowego: ");
        string katalogDocelowy = Console.ReadLine();

        // Sprawdzenie, czy katalog źródłowy istnieje
        if (Directory.Exists(katalogZrodlowy))
        {
            // Sprawdzenie, czy katalog docelowy już istnieje
            if (Directory.Exists(katalogDocelowy))
            {
                // Jeśli katalog docelowy istnieje, usuwamy go, aby go zastąpić
                Directory.Delete(katalogDocelowy, true);
                Console.WriteLine("Katalog docelowy istniał, został usunięty.");
            }
            else
            {
                Console.WriteLine("Katalog docelowy nie istnieje, zostanie utworzony.");
            }

            // Tworzymy katalog docelowy
            Directory.CreateDirectory(katalogDocelowy);

            // Pobieramy wszystkie pliki z katalogu źródłowego
            string[] pliki = Directory.GetFiles(katalogZrodlowy);

            // Kopiowanie plików do katalogu docelowego
            foreach (string plik in pliki)
            {
                // Określenie docelowej ścieżki pliku
                string nazwaPliku = Path.GetFileName(plik);
                string docelowaSciezka = Path.Combine(katalogDocelowy, nazwaPliku);

                // Kopiowanie pliku
                File.Copy(plik, docelowaSciezka, true); // true oznacza, że plik zostanie nadpisany, jeśli już istnieje
                Console.WriteLine($"Skopiowano: {nazwaPliku}");
            }

            Console.WriteLine("Operacja zakończona.");
        }
        else
        {
            Console.WriteLine("Katalog źródłowy nie istnieje.");
        }
    }
}
