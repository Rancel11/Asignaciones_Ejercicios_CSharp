using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros_Enteros = new List<int> { 1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        var numeroimpares = numeros_Enteros.Where(x => x % 2 == 1).ToList();
        var numero2 = numeroimpares.OrderByDescending(x => x);
        
        foreach (int numero in numero2)
        {
            Console.WriteLine(numero);
        }
        

    }
}

