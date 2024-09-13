
using System;

class Estudiante
{
    public string nombre { get; set; }
    public int edad { get; set; }

}



class Program
{

    static void Main(string[] args)
    {
        List<Estudiante> lista = new List<Estudiante>
        {
            new Estudiante {nombre = "Juan", edad = 15 },
            new Estudiante{nombre = "Pedro", edad=20},
            new Estudiante{nombre = "Maria", edad=30},

        };
        var mayores = lista.Where(mayor => mayor.edad > 18).ToList();
        Console.WriteLine("Estudiantes mayoes a 18: ");

        foreach (var estudiante in mayores)
        {
            Console.WriteLine($"Nombre: {estudiante.nombre} " + "|" + $" Edad:{estudiante.edad} " + "años");
        }



    }
}