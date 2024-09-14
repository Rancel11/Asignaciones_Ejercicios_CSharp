using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animales = new List<Animal>
        {
            new Perro { Nombre = "Thor" },
            new Gato { Nombre = "Misu" }
        };

        foreach (Animal animal in animales)
        {
            animal.Hablar();
        }
    }
}

class Animal
{
    public string Nombre { get; set; }

    public virtual void Hablar()
    {
        
        Console.WriteLine("El animal está haciendo un sonido.");
    }
}

class Perro : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("PERRO:");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("HAUUUUUUUU");
    }
}

class Gato : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("GATO:");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Miauuuuu Miauuuu");
    }
}

