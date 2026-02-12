using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int>();
        bool encontrado = false;

        Console.Write("¿Cuántos números desea introducir? ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            int numero = Convert.ToInt32(Console.ReadLine());
            lista.Add(numero);
        }

       
        Console.Write("\nIngrese el número que desea buscar: ");
        int buscar = Convert.ToInt32(Console.ReadLine());

       
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] == buscar)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
            Console.WriteLine("El número está presente en la lista.");
        else
            Console.WriteLine("El número NO está presente en la lista.");
    }
}