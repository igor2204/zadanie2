using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Process[] processes = Process.GetProcesses();
        Console.WriteLine("Все процессы");
        foreach (Process process in processes)
        {
            Console.WriteLine($"PID:{process.Id}, Название:{process.ProcessName}");
        }
        Console.WriteLine();
        Console.WriteLine("Первые 3 процесса");
        for(int i=0; i < Math.Min(3,processes.Length); i++) {
            Process process = processes[i];
            Console.WriteLine($"PID:{process.Id}, Название:{process.ProcessName}");
        }
        Console.ReadKey();
    }
}
