using System;

namespace Computrium.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================================================");
            Console.WriteLine("   COMPUTRIUM: Information Combustion Engine     ");
            Console.WriteLine("   (c) 2026 Project Computrium. Apache-2.0       ");
            Console.WriteLine("=================================================");
            Console.ResetColor();

            Console.WriteLine("\n[System] Initializing UniverseBus Architecture...");
            Console.WriteLine("[Kernel] Loading ICE (Information Combustion Engine)...");
            Console.WriteLine("[Status] PRE-ALPHA / ARCHITECTURE PREVIEW");

            Console.WriteLine("\n> The simulation core is currently under active refactoring.");
            Console.WriteLine("> Check README.md for the 'Information Cosmology' theory.");

            Console.WriteLine("\nPress any key to terminate the manifold...");
            Console.ReadKey();
        }
    }
}
