using System;

class Program
{
    static void Main()
    {
        int number;
        do
        {
            Console.Write("Podaj liczbę dodatnią: ");
            number = int.Parse(Console.ReadLine());
        } while (number <= 0);
        
        Console.WriteLine("Podano poprawną liczbę: " + number);
    }
}
