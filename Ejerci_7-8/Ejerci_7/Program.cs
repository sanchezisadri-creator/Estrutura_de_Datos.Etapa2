using System;

class Program
{
    static void Main()
    {
        int inicio;
        int final;

        Console.WriteLine("Ingrese el número inicial: ");
        inicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el número final: ");
        final = Convert.ToInt32(Console.ReadLine());

        if (inicio > final)
        {
            int temp = inicio;
            inicio = final;
            final = temp;
        }

        Console.WriteLine("Los múltiplos de 5 entre " + inicio + " y " + final + " son:");

        for (int i = inicio; i <= final; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
