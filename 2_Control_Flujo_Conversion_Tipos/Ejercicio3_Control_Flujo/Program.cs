using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;


        while (i > 0)
        {
            Console.Write("Ingrese un numero para saber si este es par o impar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

            i++;
        }
    }
}