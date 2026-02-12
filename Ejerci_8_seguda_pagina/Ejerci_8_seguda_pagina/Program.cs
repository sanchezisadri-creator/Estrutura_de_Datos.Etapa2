using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> listaOriginal = new List<int>();
        List<int> listaInvertida = new List<int>();

        Console.Write("¿Cuántos números desea introducir? ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            int numero = Convert.ToInt32(Console.ReadLine());
            listaOriginal.Add(numero);
        }

        
        for (int i = listaOriginal.Count - 1; i >= 0; i--)
        {
            listaInvertida.Add(listaOriginal[i]);
        }

        Console.WriteLine("\nLista original:");
        foreach (int num in listaOriginal)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nLista invertida:");
        foreach (int num in listaInvertida)
        {
            Console.Write(num + " ");
        }
    }
}
