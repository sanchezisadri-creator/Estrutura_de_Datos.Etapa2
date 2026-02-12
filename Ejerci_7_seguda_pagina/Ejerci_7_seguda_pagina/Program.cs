using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> listaOriginal = new List<int>();
        List<int> listaNueva = new List<int>();

        Console.Write("¿Cuántos números desea introducir? ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            int numero = Convert.ToInt32(Console.ReadLine());
            listaOriginal.Add(numero);
        }

        
        foreach (int num in listaOriginal)
        {
            listaNueva.Add(num * 2);
        }

        Console.WriteLine("\nLista original:");
        foreach (int num in listaOriginal)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nLista nueva (multiplicada por 2):");
        foreach (int num in listaNueva)
        {
            Console.Write(num + " ");
        }
    }
}
