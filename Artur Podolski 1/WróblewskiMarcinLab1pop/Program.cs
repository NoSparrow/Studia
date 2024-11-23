// 1) **********************************************************************************

/*
using System;

namespace MojaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Student...\n");
            Console.ReadKey();
        }
    }
}
*/



// 2) *********************************************************************************

/* 


using System;

namespace MojaAplikacja
{
   class Program
   {
       static void Main(string[] args)
       {
          int xx = 7;
          int yy = 19;
          double zz = 5.248;

          Console.WriteLine("Pierwsza = {0}, Druga = {1}, Trzecia = {2}", xx, yy, zz);
          Console.WriteLine("Pierwsza = {2}, Druga = {0}, Trzecia = {1}", xx, yy, zz);
          Console.ReadKey();
       }
   }
}


*/


// 3) *********************************************************************************

/*

using System;

namespace MojaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 567;
            Console.Write("Paczka waży " + value + " kg \n");
            Console.ReadKey();class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

        // Use a switch statement to do the math.
        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                // Ask the user to enter a non-zero divisor.
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
}


// 4) *****************************************************************************

/*

using System;

namespace MojaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź wartość zmiennoprzecinkową:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadziłeś: {0} \n", x);

            Console.WriteLine("Wprowadź wartość całkowitą:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadziłeś: {0}", y);

            Console.ReadKey();

        }
    }
}

*/


// 5) ***********************************************************************************

// A -------------------------------------------------------


/*

using System;

namespace MojaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Hello student...");
            }
            Console.ReadKey();
        }
    }
}

*/

// B ---------------------------------------------------------

/*

using System;

namespace MojaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++)
            {
                int z = i;
                Console.WriteLine($"Hello student... {z}");
            }
            Console.ReadKey();
        }
    }
}

*/

// 6) ******************************************************************************



/*

// Zadeklaruj zmienne, a następnie zainicjuj je z wartością 0.
    double num1 = 0; double num2 = 0;

    // Wyświetl tytuł aplikacji kalkulatora w konsoli C#.
    Console.WriteLine("Kalkulator w konsoli w C#\r");
    Console.WriteLine("------------------------\n");

    // Poproś użytkownika o wpisanie pierwszej liczby.
    Console.WriteLine("Napisz liczbę i naciśnij Enter");
    num1 = Convert.ToDouble(Console.ReadLine());

    // Poproś użytkownika o wpisanie drugiej liczby.
    Console.WriteLine("Napisz kolejną liczbę i naciśnij Enter");
    num2 = Convert.ToDouble(Console.ReadLine());

    // Poproś użytkownika o wybranie opcji.
    Console.WriteLine("Wybierz opcje z podanej listy:");
    Console.WriteLine("\t+ | Dodawanie");
    Console.WriteLine("\t- | Odejmowanie");
    Console.WriteLine("\t* | Mnożenie");
    Console.WriteLine("\t/ | Dzielenie");
    Console.Write("Twój wybór: \n ");

    // Użyj instrukcji switch do wykonania obliczeń matematycznych.
    switch (Console.ReadLine())
    {
        case "+":
            Console.WriteLine($"Wynik: {num1} + {num2} = " + (num1 + num2));
            break;
        case "-":
            Console.WriteLine($"Wynik: {num1} - {num2} = " + (num1 - num2));
            break;
        case "*":
            Console.WriteLine($"Wynik: {num1} * {num2} = " + (num1 * num2));
            break;
        case "/":
            while (num2 == 0)
            {
                Console.WriteLine("Wprowadź wartość inną niż 0...");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"Wynik: {num1} / {num2} = " + (num1 / num2));
            break;
    }
    // Czekaj na odpowiedź użytkownika przed zamknięciem aplikacji.
    Console.Write("Naciśnij dowolny klawisz aby zamknąć aplikację...");
    Console.ReadKey();

*/

// -------------------------------------------------------------------------------
// Naprawianie błędnych formatów


class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

        // Use a switch statement to do the math.
        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                // Ask the user to enter a non-zero divisor.
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
}


class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        // Display title as the C# console calculator app.
        Console.WriteLine("Kalkulator konsolowy w C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Declare variables and set to empty.
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            // Ask the user to type the first number.
            Console.Write("Wpisz liczbę i naciśnij Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Nieprawidłowa wartość. Wpisz liczbę: ");
                numInput1 = Console.ReadLine();
            }

            // Ask the user to type the second number.
            Console.Write("Wpisz kolejną liczbę i naciśnij Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("Nieprawidłowa wartość. Wpisz liczbę: ");
                numInput2 = Console.ReadLine();
            }

            // Ask the user to choose an operator.
            Console.WriteLine("Wybierz działanie z listy:");
            Console.WriteLine("\t+ | Dodawanie");
            Console.WriteLine("\t- | Odejmowanie");
            Console.WriteLine("\t* | Mnożenie");
            Console.WriteLine("\t/ | Dzielenie");
            Console.Write("Twój wybór: ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Błędne dane.\n");
                }
                else Console.WriteLine("Twój wynik: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Napotkano błąd podczas operacji.\n - Details: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing.
            Console.Write("Naciśnij 'x' i Enter aby zamknąć aplikację, lub inny klawisz i Enter aby kontynuować: ");
            if (Console.ReadLine() == "x") endApp = true;

            Console.WriteLine("\n"); // Friendly linespacing.
        }
        return;
    }
}



// Proszę o info czy taka forma jest ok




























