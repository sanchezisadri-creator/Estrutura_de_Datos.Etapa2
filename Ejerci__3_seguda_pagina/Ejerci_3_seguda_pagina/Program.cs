using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una oración: ");
        string oracion = Console.ReadLine();

        
        oracion = oracion.ToLower();

      
        string limpia = "";

        foreach (char c in oracion)
        {
            if (char.IsLetterOrDigit(c))
            {
                limpia += c;
            }
        }

        bool esPalindroma = true;

        for (int i = 0; i < limpia.Length / 2; i++)
        {
            if (limpia[i] != limpia[limpia.Length - 1 - i])
            {
                esPalindroma = false;
                break;
            }
        }

        if (esPalindroma)
            Console.WriteLine("La oración es palíndroma.");
        else
            Console.WriteLine("La oración NO es palíndroma.");
    }
}
