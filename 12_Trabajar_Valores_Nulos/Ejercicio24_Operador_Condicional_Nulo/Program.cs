using System;

public class Persona
{
    
    public string? Apellido { get; set; }

    public Persona(string? apellido = null)
    {
        Apellido = apellido;
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Persona persona1 = new Persona();

        Persona persona2 = new Persona("García");

        Console.WriteLine($"Apellido de persona1: {persona1.Apellido?.ToUpper() ?? "No especificado"}");
        Console.WriteLine($"Apellido de persona2: {persona2.Apellido?.ToUpper() ?? "No especificado"}");
    }
}
