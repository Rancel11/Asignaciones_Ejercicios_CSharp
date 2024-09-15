using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("CALCULADORA BASICA");
        while (true) 
        {
            Calculadora Calculadora = new Calculadora();

            


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
                    Calculadora.Sum(num1, num2);
                    break;
                case 2:
                    Calculadora.Res(num1, num2);
                    break;
                case 3:
                    Calculadora.Mult(num1, num2);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Calculadora.Res(num1, num2);
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
}

class Calculadora
{
    public void Sum(double num1, double num2)
    {
        Console.WriteLine("La suma de los dos numeros es: " + (num1 + num2));
    }

    public void Mult(double num1, double num2)
    {
        Console.WriteLine("La multiplicacion de los dos numeros es: " + (num1 * num2));
    }
    public void Res(double num1, double num2)
    {
        Console.WriteLine("La resta de los dos numeros es: " + (num1 - num2));
    }
    public void Div(double num1, double num2)
    {
        if(num2 != 0 && num1 != 0)
        {
            Console.WriteLine("La division de estos dos numeros es: "+(num1/num2));
        }
        else
        {
            Console.WriteLine("No se puede dividir");
        }
           
    }
}
