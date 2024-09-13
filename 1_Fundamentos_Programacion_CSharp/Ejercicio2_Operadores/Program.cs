using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CALCULADORA BASICA");


        Console.WriteLine("1 - SUMAR");
        Console.WriteLine("2 - RESTAR");
        Console.WriteLine("3 - MULTIPLICAR");
        Console.WriteLine("4 - DIVIDIR");

        Console.Write("Ingresar una de las opciones:");


        int opcion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("El resultado de la multiplicación es: " + (num1 * num2));
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine("El resultado de la división es: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
