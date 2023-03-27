using System;

public class Program

{
    public static void Main()

    {
        string numero = Console.ReadLine();
        Console.WriteLine(numero.Contains("13") ? $"{numero} es de Mala Suerte" : $"{numero} NO es de Mala Suerte");
    }
}


