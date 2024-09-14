using System;


class Program
{
    static void Main(string[] args)
    {
       Perro perro = new Perro();
        
        perro.Nombre = "Thor";
        perro.SonidoPerro("HAUUUUUUUU");
        Console.WriteLine("---------------------");
        Gato gato = new Gato();
        gato.Nombre = "misu";
        gato.Sonidogato("miauuuuu miauuuu");

    
    }
}

class Animal
{
    public string Nombre { get; set; }

}  

class Perro : Animal
{
    public void SonidoPerro(string sonidoperro)
    {
        
        string resultado = sonidoperro;
        Console.WriteLine("PERRO:");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine(resultado);


    }

}
class Gato : Animal
{
    public void Sonidogato(string sonidogato)
    {
        string resultado = sonidogato;
        Console.WriteLine("GATO: ");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine(resultado);
    }
}