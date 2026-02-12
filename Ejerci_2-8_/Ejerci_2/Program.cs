using System;

class Program
{
    static void Main()
    {
        int numero;
        int i = 1;
        int suma = 0;

        Console.WriteLine("Ingrese un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        while (i < numero)
        {
            if (numero % i == 0)
            {
                suma = suma + i;
            }

            i = i + 1;
        }

        if (suma == numero && numero > 0)
        {
            Console.WriteLine("El numero es perfecto.");
        }
        else
        {
            Console.WriteLine("El numero no es perfecto.");
        }
    }
}
