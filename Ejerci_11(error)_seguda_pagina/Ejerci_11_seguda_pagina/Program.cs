using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int>();
        int posicion = -1;

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

        
       
        {
            if (lista[i] == buscar)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
            Console.WriteLine("El número se encuentra en la posición: " + posicion);
        else
            Console.WriteLine("El número no se encuentra en la lista.");
    }
}
