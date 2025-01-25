using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter brightness level (5-100):");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int brightness) && brightness >= 5 && brightness <= 100)
        {
            string i2cBus = "10"; // Używamy I2C z `ddcutil detect`
            SetBrightness(i2cBus, brightness);
        }
        else
        {
            Console.WriteLine("Invalid brightness level. Please enter a number between 5 and 100.");
        }
    }

    static void SetBrightness(string i2cBus, int brightness)
    {
        // Ustawienie jasności monitora za pomocą ddcutil
        string command = $"ddcutil --bus={i2cBus} setvcp 10 {brightness}";
        string output = RunCommand(command);
        Console.WriteLine("Brightness adjustment output:");
        Console.WriteLine(output);
    }

    static string RunCommand(string command)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "/bin/bash",
                Arguments = $"-c \"{command}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };

        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        process.WaitForExit();

        if (!string.IsNullOrEmpty(error))
        {
            Console.WriteLine("Error:");
            Console.WriteLine(error);
        }

        return output;
    }

}
