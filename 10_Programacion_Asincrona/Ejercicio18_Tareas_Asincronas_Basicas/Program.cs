using System;
using System.Threading.Tasks;

class Program
{
    public static async Task<int> OperacionLargaAsync()
    {
        Random random = new Random();
        await Task.Delay(2000); 
        return random.Next(1, 101); 
    }

    static async Task Main(string[] args)
    {
        
        Task<int> tarea1 = OperacionLargaAsync();
        Task<int> tarea2 = OperacionLargaAsync();

     
        int resultado1 = await tarea1;
        int resultado2 = await tarea2;

        Console.WriteLine($"Resultado de la primera tarea: {resultado1}");
        Console.WriteLine($"Resultado de la segunda tarea: {resultado2}");
    }
}
