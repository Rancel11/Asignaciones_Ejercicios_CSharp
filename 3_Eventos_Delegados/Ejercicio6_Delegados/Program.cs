using System;

public delegate int OperacionAritmetica(int x, int y);


class Program
{
    public static int Suma(int x, int y)
    {
        return x + y;
    }

    public static int Multiplicacion(int x, int y)
    {
        return x * y;
    }



    static void Main(string[] args)
    {
        OperacionAritmetica suma = new OperacionAritmetica(Suma);
        OperacionAritmetica multiplicacion = new OperacionAritmetica(Multiplicacion);

        int resultadoSuma = suma(5, 3);
        int resultadoMultiplicacion = multiplicacion(5, 3);

        // Mostrar los resultados
        Console.WriteLine($"Suma: 5 + 3 = {resultadoSuma}");
        Console.WriteLine($"Multiplicación: 5 * 3 = {resultadoMultiplicacion}");
    }
}