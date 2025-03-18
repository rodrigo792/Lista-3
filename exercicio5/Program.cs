using System;

class Program
{
    static void Main()
    {
        const int numeroDeAlunos = 10;
        const int numeroDeNotas = 3;
        string[] alunos = new string[numeroDeAlunos];
        double[,] notas = new double[numeroDeAlunos, numeroDeNotas];
        double[] medias = new double[numeroDeAlunos];

        // Leitura dos nomes dos alunos e suas notas
        for (int i = 0; i < numeroDeAlunos; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            alunos[i] = Console.ReadLine();

            Console.WriteLine($"Digite as {numeroDeNotas} notas de {alunos[i]}:");
            for (int j = 0; j < numeroDeNotas; j++)
            {
                Console.Write($"Nota {j + 1}: ");
                notas[i, j] = double.Parse(Console.ReadLine());
            }

            // Cálculo da média
            double soma = 0;
            for (int j = 0; j < numeroDeNotas; j++)
            {
                soma += notas[i, j];
            }
            medias[i] = soma / numeroDeNotas;
        }

        // Exibição do relatório final
        Console.WriteLine("\n--- Relatório Final ---");
        for (int i = 0; i < numeroDeAlunos; i++)
        {
            // Configurar a cor de acordo com a aprovação ou reprovação
            if (medias[i] >= 7.0)
            {
                Console.ForegroundColor = ConsoleColor.Blue; // Azul para aprovado
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // Vermelho para reprovado
            }

            // Exibir os dados do aluno
            Console.WriteLine($"\nAluno: {alunos[i]}");
            Console.Write("Notas: ");
            for (int j = 0; j < numeroDeNotas; j++)
            {
                Console.Write($"{notas[i, j]} ");
            }
            Console.WriteLine($"\nMédia: {medias[i]:F2}");
            Console.WriteLine(medias[i] >= 7.0 ? "Status: Aprovado" : "Status: Reprovado");
        }

        // Resetar a cor para o padrão
        Console.ResetColor();
    }
}

