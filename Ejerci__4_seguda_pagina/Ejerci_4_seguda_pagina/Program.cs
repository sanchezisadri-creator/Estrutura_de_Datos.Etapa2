using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int suma = 0;

        Console.Write("¿Cuántos números desea introducir? ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            int numero = Convert.ToInt32(Console.ReadLine());

            numeros.Add(numero);
        }

        // Sumamos los elementos de la lista
        for (int i = 0; i < numeros.Count; i++)
        {
            suma += numeros[i];
        }

        Console.WriteLine("La suma total es: " + suma);
    }
}
