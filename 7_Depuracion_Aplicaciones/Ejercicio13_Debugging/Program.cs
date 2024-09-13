using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int maximasinteraciones = 10;

        for (int i = 1; i <= maximasinteraciones; i++)
        {
            // Error lógico: el rango de los números aleatorios está mal.
            // Se genera un número entre 0 y 99 en lugar de 1 y 100.
            int numerorandon = random.Next(0, 100);

            Console.WriteLine($"Número aleatorio generado: {numerorandon}");
        }
    }
}
