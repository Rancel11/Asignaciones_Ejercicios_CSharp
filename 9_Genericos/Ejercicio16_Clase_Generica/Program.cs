using System;

class Program
{
    static void Main(string[] args)
    {
        Caja<int> caja = new Caja<int>();
        caja.Agregar(4);
        

    }
}

class Caja<T>
{
    public List<T>  caja { get; set; }

    public Caja()
    {
        caja = new List<T>();
    }

    public void Agregar(T valor)
    {
        caja.Add(valor);
        Console.WriteLine(valor);
    }
 


}
