using System;
using System.IO;

namespace ConsoleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = string.Empty;
            string textContent = string.Empty;

            // Menu główne
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Prosta aplikacja do edycji plików tekstowych");
                Console.WriteLine("1. Otwórz plik");
                Console.WriteLine("2. Zapisz plik");
                Console.WriteLine("3. Wyszukaj tekst");
                Console.WriteLine("4. Zamień tekst");
                Console.WriteLine("5. Wyjście");
                Console.Write("Wybierz opcję: ");
                
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        filePath = OpenFile();
                        textContent = File.ReadAllText(filePath);
                        Console.WriteLine("Plik załadowany!");
                        break;
                    case "2":
                        SaveFile(textContent);
                        break;
                    case "3":
                        SearchText(textContent);
                        break;
                    case "4":
                        textContent = ReplaceText(textContent);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Nieznana opcja. Spróbuj ponownie.");
                        break;
                }

                Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
            }
        }

        static string OpenFile()
        {
            Console.Write("Podaj pełną ścieżkę do pliku: ");
            string filePath = Console.ReadLine();
            if (File.Exists(filePath))
            {
                return filePath;
            }
            else
            {
                Console.WriteLine("Plik nie istnieje.");
                return string.Empty;
            }
        }

        static void SaveFile(string content)
        {
            Console.Write("Podaj ścieżkę (razem z nazwą) dla nowego pliku: ");
            string savePath = Console.ReadLine();
            File.WriteAllText(savePath, content);
            Console.WriteLine("Plik zapisany!");
        }

        static void SearchText(string content)
        {
            Console.Write("Podaj tekst do wyszukania: ");
            string searchText = Console.ReadLine();
            if (content.Contains(searchText))
            {
                Console.WriteLine("Tekst znaleziony!");
            }
            else
            {
                Console.WriteLine("Tekst nie znaleziony.");
            }
        }

        static string ReplaceText(string content)
        {
            Console.Write("Podaj tekst do zamiany: ");
            string searchText = Console.ReadLine();
            Console.Write("Podaj nowy tekst: ");
            string replaceText = Console.ReadLine();
            string updatedContent = content.Replace(searchText, replaceText);
            Console.WriteLine("Zamiana zakończona.");
            return updatedContent;
        }
    }
}
