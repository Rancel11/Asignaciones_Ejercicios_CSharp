
using System;

class Program
{
    static void Main(string[] args)
    {
        int? Edad = null;

        

        if (Edad.HasValue)
        {
            Console.WriteLine(Edad.Value.ToString());
        }
        else
        {
            Console.WriteLine("Edad no asignada");
        }
    }
}

