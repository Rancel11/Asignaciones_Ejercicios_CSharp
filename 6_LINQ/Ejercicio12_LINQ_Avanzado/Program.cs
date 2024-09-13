using System;



class Program
{
    static void Main(string[] args)
    {
        // Lista de productos
        List<Producto> listaProductos = new List<Producto>
        {
            new Producto {Nombre = "Platano", Precio = 20, Categoria = "Alimento"},
            new Producto {Nombre = "Salami", Precio = 100, Categoria = "Alimento"},
            new Producto {Nombre = "Carne", Precio = 500, Categoria = "Alimento"},
            new Producto {Nombre = "Cerveza", Precio = 200, Categoria = "Bebida"},
            new Producto {Nombre = "Jugo", Precio = 150, Categoria = "Bebida"}
        };

        
        var agrupacionPorCategoria = listaProductos
            .GroupBy(p => p.Categoria)
            .Select(grupo => new
            {
                Categoria = grupo.Key,
                PrecioPromedio = grupo.Average(p => p.Precio)
            });

        // Mostrar resultados
        foreach (var grupo in agrupacionPorCategoria)
        {
            Console.WriteLine($"Categoría: {grupo.Categoria}, Precio Promedio: {grupo.PrecioPromedio:F2}");
        }
    }
}

class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Categoria { get; set; }
}
