using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> numeros = new List<double>();
        double suma = 0;

        Console.Write("¿Cuántos números desea introducir? ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            double numero = Convert.ToDouble(Console.ReadLine());
            numeros.Add(numero);
        }

        
        foreach (double num in numeros)
        {
            suma += num;
        }

        double promedio = suma / numeros.Count;

        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine("El promedio es: " + promedio);
    }
}
