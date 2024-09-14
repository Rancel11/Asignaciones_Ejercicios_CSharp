using System;


class Program
{
    public static void UsoDynamic(dynamic Numero, dynamic Text)
    {
        Console.WriteLine(Numero + " " + Text);
    }

    static void Main(string[] args)
    {
        UsoDynamic(1  +  " | ", "Hola mundo");
    }
}
