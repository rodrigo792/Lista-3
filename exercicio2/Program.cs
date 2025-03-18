
using System;

class Program
{
    static void Main()
    {
        const int totalProdutos = 10;
        string[] nomes = new string[totalProdutos];
        decimal[] precos = new decimal[totalProdutos];

        
        Console.WriteLine("Cadastro de produtos:");
        for (int i = 0; i < totalProdutos; i++)
        {
            Console.Write($"Digite o nome do produto {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Digite o preço do produto {i + 1}: ");
            precos[i] = decimal.Parse(Console.ReadLine());
        }

       
        Console.Write("\nDigite um valor máximo para pesquisa: ");
        decimal valorMaximo = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"\nProdutos com preço até {valorMaximo:C}:");

        bool encontrado = false;
        for (int i = 0; i < totalProdutos; i++)
        {
            if (precos[i] <= valorMaximo)
            {
                Console.WriteLine($"- {nomes[i]}: {precos[i]:C}");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Nenhum produto encontrado com o preço especificado.");
        }
    }
}
