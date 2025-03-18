
using System;

class Program
{
    static void Main()
    {
        char[,] tabuleiro = new char[3, 3];
        InicializarTabuleiro(tabuleiro);

        int contador = 0;
        bool venceu = false;

        while (contador < 9 && !venceu)
        {
            ExibirTabuleiro(tabuleiro);
            Console.WriteLine($"Jogador {(contador % 2 == 0 ? 1 : 2)} ({(contador % 2 == 0 ? 'X' : 'O')}), faça sua jogada!");

            int linha, coluna;
            Console.Write("Linha (1-3): ");
            linha = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Coluna (1-3): ");
            coluna = int.Parse(Console.ReadLine()) - 1;

            if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2 || tabuleiro[linha, coluna] != ' ')
            {
                Console.WriteLine("Jogada inválida. Tente novamente.");
                continue;
            }

            tabuleiro[linha, coluna] = (contador % 2 == 0) ? 'X' : 'O';
            contador++;

            venceu = VerificarVencedor(tabuleiro);
        }

        ExibirTabuleiro(tabuleiro);

        if (venceu)
        {
            Console.WriteLine($"Parabéns! Jogador {(contador % 2 == 0 ? 2 : 1)} venceu!");
        }
        else
        {
            Console.WriteLine("Empate! Ninguém venceu.");
        }
    }

    static void InicializarTabuleiro(char[,] tabuleiro)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }
    }

    static void ExibirTabuleiro(char[,] tabuleiro)
    {
        Console.Clear();
        Console.WriteLine("Jogo da Velha");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {tabuleiro[i, j]} ");
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("---+---+---");
        }
    }

    static bool VerificarVencedor(char[,] tabuleiro)
    {
        // Verificar linhas e colunas
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] != ' ' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                return true;

            if (tabuleiro[0, i] != ' ' && tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i])
                return true;
        }

        // Verificar diagonais
        if (tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
            return true;

        if (tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
            return true;

        return false;
    }
}
