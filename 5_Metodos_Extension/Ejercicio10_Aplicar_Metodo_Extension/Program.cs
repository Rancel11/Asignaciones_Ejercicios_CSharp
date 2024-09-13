using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CONTAR VOCALES QUE HAY EN UN TEXTO");

        Console.Write("Ingrese un texto: ");
        var texto = Console.ReadLine();
        
        Console.Write("Ingrese una vocal: ");
       string voca = Convert.ToString(Console.ReadLine());



        int resultado = Devolvervocal.ContarVocal(texto, voca);
        
        Console.WriteLine($"La vocal {voca}, aparece {resultado} en {texto} " );
    }
}




public static class Devolvervocal
{
    public static int ContarVocal(string texto, string vocal)
    {
        

        int contador = 0;
        char vocalChar = vocal[0];
        var arraychar = texto.ToCharArray();

        foreach (char vocaL in arraychar)
        {
            if (vocaL == vocalChar) 
                contador++;
        }

        return contador;
    }
}
