using System;

class Program
{
    static void Main(string[] args)
    {
        int? edad = null;

        int edadreal = edad ?? 20;

        Console.WriteLine(edadreal);
    }
}