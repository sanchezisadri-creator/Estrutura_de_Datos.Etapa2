using System;

class Program
{
    static void Main()
    {
        int numero;
        int positivos = 0;
        int negativos = 0;
        int ceros = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Ingrese el número " + i + ": ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                positivos++;
            }
            else if (numero < 0)
            {
                negativos++;
            }
            else
            {
                ceros++;
            }
        }

        Console.WriteLine("Cantidad de positivos: " + positivos);
        Console.WriteLine("Cantidad de negativos: " + negativos);
        Console.WriteLine("Cantidad de ceros: " + ceros);
    }
}