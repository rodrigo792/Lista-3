

using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[15];

        // Lendo os 15 números do usuário
        Console.WriteLine("Digite 15 números inteiros:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Exibindo os números das posições pares
        Console.WriteLine("\nNúmeros armazenados nas posições pares:");
        for (int i = 0; i < numeros.Length; i += 2) // Incremento de 2 para pegar apenas posições pares
        {
            Console.WriteLine($"Posição {i}: {numeros[i]}");
        }
    }
}
