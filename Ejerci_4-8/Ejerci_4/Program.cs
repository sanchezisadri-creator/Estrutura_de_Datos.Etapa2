using System;

class Program
{
    static void Main()
    {
        int num1;
        int num2;
        int mcm;

        Console.WriteLine("Ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Empezamos desde el mayor
        if (num1 > num2)
        {
            mcm = num1;
        }
        else
        {
            mcm = num2;
        }

        while (true)
        {
            if (mcm % num1 == 0 && mcm % num2 == 0)
            {
                break;
            }

            mcm = mcm + 1;
        }

        Console.WriteLine("El MCM es: " + mcm);
    }
}