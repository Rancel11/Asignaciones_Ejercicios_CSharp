using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("ingrese un numero entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        decimal numerodecimal = Convert.ToDecimal(numero);
        Console.WriteLine($"Conversion a numero decimal: {numerodecimal}");

        int numero2 = Convert.ToInt32(numerodecimal);
        Console.WriteLine($"Conversion a numero entero: {numero2}");
        

        //La conversion explicita puede ser util cuando existe una posible perdida de datos
    }
}