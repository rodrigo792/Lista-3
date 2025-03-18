
using System;

class Program
{
    static void Main()
    {
        const int tamanho = 5;
        int[,] matriz = new int[tamanho, tamanho];

        // Preenchendo a matriz com os números de 1 a 25
        int valor = 1;
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                matriz[i, j] = valor;
                valor++;
            }
        }

        // Exibindo os valores das diagonais
        Console.WriteLine("Valores da diagonal principal:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }

        Console.WriteLine("\nValores da diagonal secundária:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine(matriz[i, tamanho - i - 1]);
        }
    }
}
