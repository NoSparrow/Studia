Random liczba = new Random();
Int32 a, b;

for (b=0; b<=20; b++)
{
    a = liczba.Next(10,20); // Next przekazuje parametry do metody Random(), zakres losowanych liczb to 10-19, bo 20 nie jest wliczane
    Console.WriteLine(a);
}
Console.ReadKey();