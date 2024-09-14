using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    
    public static async Task DescargarArchivoAsync(string nombreArchivo, int delay)
    {
        Console.WriteLine($"Iniciando descarga de {nombreArchivo}...");
        await Task.Delay(delay); 
        Console.WriteLine($"{nombreArchivo} descargado.");
    }

    static async Task Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        
        Task descarga1 = DescargarArchivoAsync("Archivo1", 3000); 
        Task descarga2 = DescargarArchivoAsync("Archivo2", 2000); 
        Task descarga3 = DescargarArchivoAsync("Archivo3", 1000); 

        
        await Task.WhenAll(descarga1, descarga2, descarga3);

        
        stopwatch.Stop();
        Console.WriteLine($"Todas las descargas completadas en {stopwatch.ElapsedMilliseconds / 1000.0} segundos.");
    }
}
