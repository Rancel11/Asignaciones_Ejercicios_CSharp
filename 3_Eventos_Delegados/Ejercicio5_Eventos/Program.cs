using System;

public class Recurso : IDisposable
{
    
    private bool _disposed = false;

  
    public void Dispose()
    {
        Dispose(true);
        
        GC.SuppressFinalize(this);
    }

    
    protected virtual void Dispose(bool disposing)
    {
     
        if (_disposed)
            return;

        if (disposing)
        {
            
            Console.WriteLine("Recursos gestionados han sido liberados.");
        }

        
        Console.WriteLine("Recursos no gestionados han sido liberados.");

        _disposed = true;
    }

 
    ~Recurso()
    {
       
        Dispose(false);
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (Recurso recurso = new Recurso())
        {
            
            Console.WriteLine("Uso del recurso...");
        }

 
    }
}
