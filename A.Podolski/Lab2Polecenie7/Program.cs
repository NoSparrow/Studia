using System;

class Program
{
    static void Main()
    {
        int x = 1; // Początkowa wartość x

        // Pętla do...while
        do
        {
            x++; // Inkrementacja przeniesiona na początek

            int y = 2 * x + 1; // Obliczenie wartości funkcji y = 2x + 1
            Console.WriteLine($"Dla x = {x}, y = {y}");
        }
        while (x < 20); // Warunek zakończenia pętli (x zmienia się od 1 do 20)

        // Zgłoszenie zakończenia realizacji polecenia
        Console.WriteLine("Zakończenie realizacji polecenia.");
    }
}
// Lokalizacja zapisu ma wpływ na działanie pętli, zmieniając miejsce inkrementacji zmienia się kolejność wykonywanych działań, tutaj najpierw zostanie wykonana inkrementacja x++ i dopiero później wyliczenie y. Skutkuje to pominięciem wartości x = 1.