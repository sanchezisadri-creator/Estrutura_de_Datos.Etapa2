using System;

class Program
{
    static void Main()
    {
        int numero;
        int suma = 0;
        double media;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingrese el numero " + i + ": ");
            numero = Convert.ToInt32(Console.ReadLine());
            suma = suma + numero;
        }

        media = (double)suma / 5;

        Console.WriteLine("La media aritmetica es: " + media);
    }
}
