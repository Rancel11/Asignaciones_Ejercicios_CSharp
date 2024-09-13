using System;

class Program
{
    static void Main(string[] args)
    {
        var texto = "Hola mundo";
        string voca = "o";

        
        int resultado = Devolvervocal.ContarVocal(texto, voca);
        Console.WriteLine(texto);
        Console.WriteLine($"La vocal {voca}, aparece {resultado} en el texto " );
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

