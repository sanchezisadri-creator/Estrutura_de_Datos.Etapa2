Perfecto 👍 vamos a resolverlo.

Primero necesito decirte algo importante:
Cuando dices “no me corre” en C#, normalmente es por uno de estos errores:

❌ Estás usando .NET Framework viejo

❌ Estás usando top-level statements

❌ Hay error al convertir datos

❌ No creaste proyecto tipo Console

❌ Copiaste el código dentro de otro Main

✅ Te voy a dar una versión MÁS simple y segura

Prueba exactamente este código nuevo:

using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;

        while (true)
        {
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 5)
            {
                Console.WriteLine("Saliendo...");
                break;
            }

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            if (opcion == 1)
                resultado = num1 + num2;
            else if (opcion == 2)
                resultado = num1 - num2;
            else if (opcion == 3)
                resultado = num1 * num2;
            else if (opcion == 4)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                    continue;
                }
                resultado = num1 / num2;
            }
            else
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            Console.WriteLine("Resultado: " + resultado);
            Console.WriteLine();
        }
    }
}