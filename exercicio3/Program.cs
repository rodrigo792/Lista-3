
using System;

class Program
{
    static void Main()
    {
        const int linhas = 3;
        const int colunas = 5;
        int[,] matriz = new int[linhas, colunas];
        int[] somaDasLinhas = new int[linhas];

        
        Console.WriteLine("Digite os elementos da matriz 3x5:");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Elemento [{i + 1}, {j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                somaDasLinhas[i] += matriz[i, j];
            }
        }

        
        Console.WriteLine("\nSoma dos valores de cada linha:");
        for (int i = 0; i < linhas; i++)
        {
            Console.WriteLine($"Linha {i + 1}: {somaDasLinhas[i]}");
        }
    }
}
