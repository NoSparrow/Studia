using System;

class Program
{
    static void Main()
    {
        int countA = 0;
        int countB = 0;

        // Pętla A (zewnętrzna)
        for (int i = 0; i < 5; i++)
        {
            countA++;
            Console.WriteLine($"Pętla A - Iteracja {i}");

            // Pętla B (wewnętrzna)
            for (int j = 0; j < 4; j++)
            {
                countB++;
                Console.WriteLine($"   Pętla B - Iteracja {j}");
            }
        }

        Console.WriteLine($"Pętla A wykonała się {countA} razy.");
        Console.WriteLine($"Pętla B wykonała się {countB} razy.");
    }
}
