using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del arreglo: ");
        int tamaño = Convert.ToInt32(Console.ReadLine());

        int[] arreglo = new int[tamaño];

        
        int contador = 0;

        
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write("Ingrese el elemento en la posición " + i + ": ");
            arreglo[i] = Convert.ToInt32(Console.ReadLine());
            contador++; 
        }

        Console.WriteLine("\nArreglo original:");
        Mostrar(arreglo);

        Console.Write("\nIngrese el número de posiciones a rotar: ");
        int posiciones = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dirección (derecha / izquierda): ");
        string direccion = Console.ReadLine().ToLower();

        
        posiciones = posiciones % tamaño;
        posiciones = posiciones % tamaño;

        if (direccion == "derecha")
        {
            RotarDerecha(arreglo, posiciones);
        }
        else if (direccion == "izquierda")
        {
            RotarIzquierda(arreglo, posiciones);
        }
        else
        {
            Console.WriteLine("Dirección inválida.");
            return;
        }

        Console.WriteLine("\nArreglo después de la rotación:");
        Mostrar(arreglo);
    }

    static void Mostrar(int[] arr)
    {
        
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void RotarDerecha(int[] arr, int posiciones)
    {
        for (int p = 0; p < posiciones; p++)
        {
            int ultimo = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = ultimo;
        }
    }

    static void RotarIzquierda(int[] arr, int posiciones)
    {
        for (int p = 0; p < posiciones; p++)
        {
            int primero = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[arr.Length - 1] = primero;
        }
    }
}

