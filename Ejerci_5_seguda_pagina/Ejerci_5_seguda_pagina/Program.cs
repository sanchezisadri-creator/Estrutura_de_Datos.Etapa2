using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        Console.Write("¿Cuántos números desea introducir? ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numeros.Add(numero);
        }

       
        int maximo = numeros[0];
        int minimo = numeros[0];

        for (int i = 1; i < numeros.Count; i++)
        {
            if (numeros[i] > maximo)
            {
                maximo = numeros[i];
            }

            if (numeros[i] < minimo)
            {
                minimo = numeros[i];
            }
        }

        Console.WriteLine("El valor máximo es: " + maximo);
        Console.WriteLine("El valor mínimo es: " + minimo);
    }
}