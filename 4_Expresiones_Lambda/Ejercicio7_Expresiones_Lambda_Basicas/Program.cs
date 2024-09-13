using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        
        IEnumerable<int> numerosPares = numeros.Where(n => n % 2 == 0);

        
        Console.WriteLine("Números pares:");
        foreach (int numero in numerosPares)
        {
            Console.WriteLine(numero);
        }
    }
}