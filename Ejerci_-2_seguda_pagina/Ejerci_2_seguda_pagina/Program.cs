using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        string invertida = "";

        
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            invertida += palabra[i];
        }

        
        if (palabra.ToLower() == invertida.ToLower())
        {
            Console.WriteLine("La palabra es palíndroma.");
        }
        else
        {
            Console.WriteLine("La palabra NO es palíndroma.");
        }
    }
}