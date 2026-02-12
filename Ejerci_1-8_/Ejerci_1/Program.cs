class Program
{
    static void Main()
    {
        int numero;
        int contador = 0;

        Console.WriteLine("Ingrese un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            if (i % 2 == 0)
            {
                contador = contador + 1;
            }
        }

        Console.WriteLine("La cantidad de numeros pares entre 1 y " + numero + " es: " + contador);
    }
}
