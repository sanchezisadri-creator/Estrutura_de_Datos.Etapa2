using System;

class Program
{
    static void Main()
    {
        int cantidad;
        int numero;
        int contadorPrimos = 0;

        Console.WriteLine("¿Cuántos números desea introducir?");
        cantidad = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.WriteLine("Ingrese el número " + i + ": ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (EsPrimo(numero))
            {
                contadorPrimos++;
            }
        }

        Console.WriteLine("Cantidad de números primos: " + contadorPrimos);
    }

    static bool EsPrimo(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
