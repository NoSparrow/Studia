using System;

class Program
{
    static void Main()
    {
        // Inicjalizacja generatora liczb losowych
        Random rand = new Random();

        // Powtarzamy symulację 10 razy
        for (int i = 1; i <= 10; i++)
        {
            // Symulujemy rzut dwoma kostkami
            int kostka1 = rand.Next(1, 7); // Liczba z zakresu 1-6
            int kostka2 = rand.Next(1, 7); // Liczba z zakresu 1-6

            // Obliczanie sumy oczek
            int suma = kostka1 + kostka2;

            // Wypisanie wyniku rzutu i sumy oczek
            Console.WriteLine($"Rzut {i}: Kostka 1 = {kostka1}, Kostka 2 = {kostka2}, Suma = {suma}");
        }
    }
}
