using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int number;
        
        while ((number = random.Next(1, 101)) != 7)
        {
            Console.WriteLine("Wylosowano: " + number);
        }
        
        Console.WriteLine("Wylosowano liczbę 7, koniec losowania.");
    }
}
