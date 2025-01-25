using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter brightness level (0-100) or 'q' to quit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            if (int.TryParse(input, out int brightnessLevel))
            {
                // Sprawdź, czy wartość jasności jest w dopuszczalnym zakresie
                if (brightnessLevel < 0 || brightnessLevel > 100)
                {
                    Console.WriteLine("Invalid input! Please enter a value between 0 and 100.");
                    continue;
                }

                // Zmiana jasności monitora
                string command = $"ddcutil setvcp 10 {brightnessLevel}";
                try
                {
                    var process = new Process();
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = "bash",
                        Arguments = $"-c \"{command}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false
                    };
                    process.Start();
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    // Ignoruj błąd, nie wyświetlaj go
                    // Możesz dodać logowanie błędu do pliku, jeśli chcesz
                    // Console.WriteLine("Error: " + ex.Message);
                }

                // Odczytanie aktualnej jasności
                string getBrightnessCommand = "ddcutil getvcp 10";
                try
                {
                    var process2 = new Process();
                    process2.StartInfo = new ProcessStartInfo
                    {
                        FileName = "bash",
                        Arguments = $"-c \"{getBrightnessCommand}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false
                    };
                    process2.Start();
                    string output = process2.StandardOutput.ReadToEnd();
                    process2.WaitForExit();

                    // Odczytanie tylko poziomu jasności
                    var brightnessValueStartIndex = output.IndexOf("current value =") + "current value =".Length;
                    var brightnessValueEndIndex = output.IndexOf("max value");

                    if (brightnessValueStartIndex != -1 && brightnessValueEndIndex != -1)
                    {
                        var brightnessValue = output.Substring(brightnessValueStartIndex, brightnessValueEndIndex - brightnessValueStartIndex).Trim();
                        Console.WriteLine($"Current brightness: {brightnessValue}%");
                    }
                    else
                    {
                        Console.WriteLine("Error: Unable to parse brightness.");
                    }
                }
                catch (Exception ex)
                {
                    // Ignoruj błąd odczytu jasności
                    // Możesz dodać logowanie błędu do pliku, jeśli chcesz
                    // Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}
