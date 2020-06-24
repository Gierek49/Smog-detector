using System;
using System.Diagnostics;


namespace PythonData
{
    public class Program
    {
        static double X;
        static double Y;
        public Program(double x, double y)
        {
            X = x;
            Y = y;
        }
        static void Main(string[] args)
        {
            //utworzenie procesu
            var psi = new ProcessStartInfo();
            //scieżka do pythona 
            psi.FileName = @"C:\Users\admin\AppData\Local\Programs\Python\Python38\python.exe";

            //scieżka do skryptu i argumenty 
            var script = @"C:\Users\admin\source\repos\Smog-detector\SmogDetector\PythonData\DataReader.py";

            //konfiguracja
            psi.Arguments = $"\"{script}\"";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            //wykonanie procesu i zwrot danych
            var errors = "";

            using (var proces = Process.Start(psi))
            {
                errors = proces.StandardError.ReadToEnd();
            }

            Console.WriteLine("Errors:");
            Console.WriteLine(errors);
            Console.WriteLine("End successfully");

            Console.ReadLine();
        }
    }
}
