using System;

class Program
{
    static void Main()
    {
        int[] arreglo = new int[5] { 10, 20, 30, 40, 50 };

        Console.WriteLine("Arreglo original:");
        Mostrar(arreglo);

        
        Insertar(arreglo, 2, 99);
        Console.WriteLine("\nDespués de insertar 99 en posición 2:");
        Mostrar(arreglo);

        
        Eliminar(arreglo, 3);
        Console.WriteLine("\nDespués de eliminar posición 3:");
        Mostrar(arreglo);

        
        int indice = Buscar(arreglo, 40);
        Console.WriteLine("\nBuscar 40:");
        if (indice != -1)
            Console.WriteLine("Elemento encontrado en índice: " + indice);
        else
            Console.WriteLine("Elemento no encontrado.");
    }

    
    static void Mostrar(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    
    static void Insertar(int[] arr, int posicion, int valor)
    {
        if (posicion < 0 || posicion >= arr.Length)
        {
            Console.WriteLine("Posición inválida.");
            return;
        }

        for (int i = arr.Length - 1; i > posicion; i--)
        {
            arr[i] = arr[i - 1];
        }

        arr[posicion] = valor;
    }

    
    static void Eliminar(int[] arr, int posicion)
    {
        if (posicion < 0 || posicion >= arr.Length)
        {
            Console.WriteLine("Posición inválida.");
            return;
        }

        for (int i = posicion; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        arr[arr.Length - 1] = 0; 
    }

    
    static int Buscar(int[] arr, int valor)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == valor)
                return i;
        }

        return -1;
    }
}
