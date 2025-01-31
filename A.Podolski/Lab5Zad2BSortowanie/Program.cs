using System;
using System.Collections.Generic;
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
            // Określenie ścieżki do nowego pliku (z dopiskiem "posortowane")
            string sciezkaNowegoPliku = Path.GetFileNameWithoutExtension(sciezkaPliku) + "_posortowane" + Path.GetExtension(sciezkaPliku);
            string nowaSciezka = Path.Combine(Path.GetDirectoryName(sciezkaPliku), sciezkaNowegoPliku);

            // Zmienna do przechowywania wszystkich linii
            List<string> linie = new List<string>();

            // Użycie StreamReader do odczytania pliku
            using (StreamReader reader = new StreamReader(sciezkaPliku))
            {
                string linia;
                while ((linia = reader.ReadLine()) != null)
                {
                    linie.Add(linia);
                }
            }

            // Sortowanie listy linii
            linie.Sort();

            // Zapisanie posortowanych linii do nowego pliku
            using (StreamWriter writer = new StreamWriter(nowaSciezka))
            {
                foreach (string linia in linie)
                {
                    writer.WriteLine(linia);
                }
            }

            // Informacja o zapisaniu posortowanego pliku
            Console.WriteLine($"Posortowany plik zapisano jako: {nowaSciezka}");
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }
}
