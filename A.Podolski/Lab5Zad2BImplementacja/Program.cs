using System;
using System.IO;

public enum LogLevel
{
    Debug,
    Info,
    Warn,
    Error
}

public class Logger
{
    private readonly string _sciezkaPliku;
    private readonly LogLevel _poziomLogowania;

    // Konstruktor przyjmujący ścieżkę do pliku oraz poziom logowania
    public Logger(string sciezkaPliku, LogLevel poziomLogowania)
    {
        _sciezkaPliku = sciezkaPliku;
        _poziomLogowania = poziomLogowania;
    }

    // Funkcja do zapisywania wiadomości do pliku
    private void Log(string message, LogLevel level)
    {
        // Jeśli poziom logowania wiadomości jest wyższy lub równy ustawionemu poziomowi
        if (level >= _poziomLogowania)
        {
            using (StreamWriter writer = new StreamWriter(_sciezkaPliku, true))
            {
                string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";
                writer.WriteLine(logMessage);
            }
        }
    }

    // Metoda do logowania komunikatów debugowych
    public void Debug(string message)
    {
        Log(message, LogLevel.Debug);
    }

    // Metoda do logowania komunikatów informacyjnych
    public void Info(string message)
    {
        Log(message, LogLevel.Info);
    }

    // Metoda do logowania komunikatów ostrzegawczych
    public void Warn(string message)
    {
        Log(message, LogLevel.Warn);
    }

    // Metoda do logowania komunikatów o błędach
    public void Error(string message)
    {
        Log(message, LogLevel.Error);
    }
}

class Program
{
    static void Main()
    {
        // Poproś użytkownika o pełną ścieżkę i nazwę pliku logów
        Console.Write("Podaj pełną ścieżkę i nazwę pliku do zapisu logów (np. C:\\logs\\log.txt): ");
        string sciezkaPliku = Console.ReadLine();

        // Sprawdź, czy katalog docelowy istnieje, jeśli nie, utwórz go
        string katalog = Path.GetDirectoryName(sciezkaPliku);
        if (!Directory.Exists(katalog))
        {
            Directory.CreateDirectory(katalog);
            Console.WriteLine($"Katalog {katalog} został utworzony.");
        }

        // Poproś użytkownika o wybór poziomu logowania
        Console.WriteLine("Wybierz poziom logowania:");
        Console.WriteLine("1 - Debug");
        Console.WriteLine("2 - Info");
        Console.WriteLine("3 - Warn");
        Console.WriteLine("4 - Error");

        int wyborPoziomu = int.Parse(Console.ReadLine());
        LogLevel poziomLogowania;

        switch (wyborPoziomu)
        {
            case 1:
                poziomLogowania = LogLevel.Debug;
                break;
            case 2:
                poziomLogowania = LogLevel.Info;
                break;
            case 3:
                poziomLogowania = LogLevel.Warn;
                break;
            case 4:
                poziomLogowania = LogLevel.Error;
                break;
            default:
                Console.WriteLine("Niepoprawny wybór, domyślnie ustawiono poziom logowania na Info.");
                poziomLogowania = LogLevel.Info;
                break;
        }

        // Tworzenie instancji loggera
        Logger logger = new Logger(sciezkaPliku, poziomLogowania);

        // Przykładowe logowanie
        logger.Debug("To jest komunikat debug.");
        logger.Info("To jest komunikat info.");
        logger.Warn("To jest komunikat ostrzeżenie.");
        logger.Error("To jest komunikat o błędzie.");

        Console.WriteLine("Logowanie zakończone. Logi zapisano w wybranym pliku.");
    }
}
