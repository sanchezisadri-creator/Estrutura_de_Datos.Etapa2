using System;

class Program
{
    static void Main()
    {
        int numero;
        int mayor = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Ingrese el número " + i + ": ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (i == 1)
            {
                mayor = numero; // El primero se toma como mayor inicial
            }
            else if (numero > mayor)
            {
                mayor = numero;
            }
        }

        Console.WriteLine("El número mayor es: " + mayor);
    }
}