// 1) **********************************************************************************

/*
using System; //Podpiecie systemu nazw z przestrzeni System do progrmu - można kożystać z klass zawartych w przestrzeni nazw "System" 

namespace MojaAplikacja // Utworzenie przestrzeni nazw
{
    class Program // Stworzenie klasy (Wzorca) o nazwie "Program"
    {
        static void Main(string[] args) //static: Oznacza, że metoda Main jest metodą statyczną. Nie musimy tworzyć instancji klasy Program, aby wywołać tę metodę. Jest to metoda, która zostaje wywołana automatycznie, gdy aplikacja się uruchamia | void: Określa, że metoda Main nie zwraca żadnej wartości | Main: To jest nazwa głównej metody w aplikacji, która jest punktem startowym programu. C# oczekuje, że każda aplikacja konsolowa będzie miała metodę Main, która jest pierwszą metodą wywołaną po uruchomieniu aplikacji | string[] args: To parametr, który przechowuje argumenty wiersza poleceń przekazywane do aplikacji. W tym przypadku args jest tablicą łańcuchów (string[])
        {
            Console.WriteLine("Hello Student...\n");
            //Console: Jest to klasa z przestrzeni nazw System, która udostępnia metody do interakcji z konsolą (np. wypisywanie tekstu, odczytywanie danych od użytkownika)
            //WriteLine: Jest to metoda klasy Console, która wypisuje tekst na ekranie i przechodzi do nowej linii. Różni się od metody Write, która nie przechodzi do nowej linii po wypisaniu tekstu
            //"Hello Student...\n": To ciąg znaków (string), który zostanie wyświetlony na ekranie. Zawiera tekst „Hello Student...”, a \n to znak nowej linii, więc po wypisaniu tego tekstu kursor w konsoli przejdzie do kolejnej linii


            Console.ReadKey();
            //Console.ReadKey(): Jest to metoda, która czeka na naciśnięcie dowolnego klawisza przez użytkownika. Po naciśnięciu klawisza, aplikacja kontynuuje działanie. Zwykle stosuje się ją, aby program nie zakończył się od razu po wyświetleniu wyników, a dał użytkownikowi czas na zobaczenie wypisanego tekstu
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
          //int: To typ danych w języku C#, który oznacza liczbę całkowitą. Jest to skrót od słowa "integer" (liczba całkowita
          //xx: To nazwa zmiennej. W tym przypadku yy to zmienna, która przechowuje liczbę całkowitą. Nazwa zmiennej może być dowolna, ale zazwyczaj powinna odzwierciedlać, co ta zmienna reprezentuje


          int yy = 19;
          double zz = 5.248;
          //double: To typ danych w C#, który przechowuje liczby zmiennoprzecinkowe, czyli liczby, które mogą mieć część dziesiętną

          Console.WriteLine("Pierwsza = {0}, Druga = {1}, Trzecia = {2}", xx, yy, zz);
          //Po tekście, w metodzie WriteLine, podajemy zmienne, których wartości mają zostać wstawione w odpowiednie miejsca ({0}, {1}, {2}). W C# używamy miejsc formatowania ({0}, {1}, {2}) w celu wstawienia wartości zmiennych w określone miejsce w ciągu tekstowym. To pozwala na dynamiczne tworzenie tekstów, które zależą od wartości zmiennych





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
    //public: Jest to modyfikator dostępu. Oznacza, że metoda DoOperation jest dostępna publicznie, czyli może być wywoływana z dowolnego miejsca w programie, zarówno z innych klas, jak i z instancji obiektów tej klasy (jeśli metoda nie jest statyczna)

    //static: Oznacza, że metoda jest statyczna. Metody statyczne nie wymagają tworzenia obiektu klasy, aby zostały wywołane. Są wywoływane bezpośrednio na klasie. W tym przypadku, aby wywołać metodę DoOperation, nie musimy tworzyć obiektu, tylko możemy używać jej bezpośrednio przez nazwę klasy (np. DoOperation(...))

    //double: Oznacza, że metoda DoOperation zwraca wartość typu double (liczba zmiennoprzecinkowa). Metoda ta oblicza i zwraca wynik operacji matematycznej, który może zawierać część dziesiętną

    //DoOperation: To jest nazwa metody. Nazwa metody powinna opisywać, co dana metoda robi. W tym przypadku sugeruje, że metoda wykonuje jakąś operację matematyczną na dwóch liczbach

    //double num1: Pierwszy parametr metody, który reprezentuje liczbę zmiennoprzecinkową. Zmienna ta będzie przechowywać pierwszą liczbę, na której będziemy wykonywać operację

    //double num2: Drugi parametr metody, również typu double, reprezentujący drugą liczbę, na której będzie wykonywana operacja

    //string op: Trzeci parametr to łańcuch znaków (typ string). Przechowuje operację matematyczną, którą użytkownik chce wykonać






        double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.
        //przypisanie wartości NaN do zmiennej result(wynik zwracany przez metodę) - wartość bazowa która zostanie zwrócona jeśli nie zostanie zmieniona w dalszej części







        // Use a switch statement to do the math.
        switch (op)
        {
        //wartość "op" jest porównywana do wartości przypisanej do każdego przypadku "case" - jeśli wartości są takie same kod zawarty w danym przypadku zostanie wykonany
            case "+":
                result = num1 + num2;
                //Do wyniku przypisuje się nową wartość stanowiącą wynik podanej operacji



                break;
                //break - powoduje opuszczenie pozostałego kodu metody switch




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
            //Kod wykonywany w przypadku gdy wartość wpisana do metody nie odpowiada żadnemu przypadkowi
        }





        return result;
        //Zakończenie metody poleceniem zwracającym wartość result
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
            //Wartość wprowadzona poprzez readline() zostaje przekonwertowana na liczbę zmienno przecinkową i przypisana do zmiennej x



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
            //Pętla for (wartość początkowa ; warunek ; iteracja(i++ = (i = i + 1) ) ), kod wykonywany dopóki wartość i spełnia podany warunek, po przejściu do końca pętli następuje iteracja i ponowne sprawdzenie warunku - jeśli jest spełniony kod zostaje wykonany ponownie


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
    //Convert.ToDouble() to metoda w języku C#, która konwertuje różne typy danych na typ double (liczbę zmiennoprzecinkową).W tym przypadku, Convert.ToDouble() używa wprowadzonego przez użytkownika tekstu (który został odczytany za pomocą Console.ReadLine()) i konwertuje go na liczbę typu double. Jest to alternatywa dla double.Parse(), ale różni się tym, że Convert.ToDouble() jest bardziej uniwersalna i bezpieczna, ponieważ może obsługiwać również wartości null (np. przy konwersji z typów obiektowych) lub niepoprawne dane wejściowe, próbując je przekonwertować w sposób bardziej tolerancyjny.






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
        //Zmienna o wartości bool może być tylko false lub true


        // Display title as the C# console calculator app.
        Console.WriteLine("Kalkulator konsolowy w C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            //Pętla wykonywana dopóki użytkownik nie wprowadzi żądanej wartości (zmienna z wykrzyknikiem to negacja, jeśli endApp = false to !endApp - True)


            
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
            //try-catch to mechanizm obsługi wyjątków w C#. Służy do przechwytywania błędów (wyjątków), które mogą wystąpić w czasie działania programu, i umożliwia odpowiednie reagowanie na te błędy.
            //try: W tej sekcji umieszczamy kod, który może wywołać wyjątek. Jeżeli wystąpi błąd w obrębie tego bloku, program przejdzie do bloku catch.
            //catch: Sekcja ta przechwytuje wyjątek i pozwala na jego obsługę. W tym przypadku, jeśli coś pójdzie nie tak w funkcji Calculator.DoOperation(), wyjątek zostanie przechwycony, a użytkownik otrzyma komunikat o błędzie
            //W tym kodzie mamy try-catch wokół wywołania metody Calculator.DoOperation(), co oznacza, że program spróbuje wykonać operację matematyczną, a jeśli wystąpi błąd (np. nieprawidłowy operator), wyświetli stosowny komunikat o błędzie





            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing.
            Console.Write("Naciśnij 'x' i Enter aby zamknąć aplikację, lub inny klawisz i Enter aby kontynuować: ");
            if (Console.ReadLine() == "x") endApp = true;

            Console.WriteLine("\n"); // Friendly linespacing.
        }
        return;
    }
}



// Poprawione



























