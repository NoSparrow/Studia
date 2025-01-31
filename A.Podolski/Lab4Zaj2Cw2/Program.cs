using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę N: ");
        int N = int.Parse(Console.ReadLine());
        int suma = 0;
        
        for (int i = 1; i <= N; i++)
        {
            suma += i;
        }
        
        Console.WriteLine("Suma liczb od 1 do " + N + " wynosi: " + suma);
    }
}
