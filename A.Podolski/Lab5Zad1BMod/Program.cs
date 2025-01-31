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
            // Poproś użytkownika o tekst, który ma być dodany do każdej linii (np. numer linii)
            Console.Write("Podaj tekst, który chcesz dodać na początku każdej linii: ");
            string tekstDoDodania = Console.ReadLine();

            // Określenie ścieżki do nowego pliku (z dopiskiem "modyfikowany")
            string sciezkaNowegoPliku = Path.GetFileNameWithoutExtension(sciezkaPliku) + "_modyfikowany" + Path.GetExtension(sciezkaPliku);
            string nowaSciezka = Path.Combine(Path.GetDirectoryName(sciezkaPliku), sciezkaNowegoPliku);

            // Utworzenie nowego pliku, do którego będą zapisywane zmodyfikowane linie
            using (StreamWriter writer = new StreamWriter(nowaSciezka))
            {
                int numerLinii = 1;

                // Użycie StreamReader do odczytania oryginalnego pliku
                using (StreamReader reader = new StreamReader(sciezkaPliku))
                {
                    string linia;
                    while ((linia = reader.ReadLine()) != null)
                    {
                        // Zmiana linii przez dodanie tekstu użytkownika (np. numeru linii)
                        string zmodyfikowanaLinia = $"{tekstDoDodania} {numerLinii}: {linia}";

                        // Zapisanie zmodyfikowanej linii do nowego pliku
                        writer.WriteLine(zmodyfikowanaLinia);

                        // Zwiększenie numeru linii
                        numerLinii++;
                    }
                }
            }

            // Informacja o zapisaniu pliku
            Console.WriteLine($"Zmieniony plik zapisano jako: {nowaSciezka}");
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }
}
