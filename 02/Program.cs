using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine()?.ToUpper();

        if (input == null)
        {
            Console.WriteLine("Não foi possível ler a entrada.");
            return;
        }

        int qtd = 0;
        foreach (char caractere in input)
        {
            if (caractere == 'A')
            {
                qtd++;
            }
        }

        if (qtd == 0)
        {
            Console.Write("Nenhuma ocorrência da letra a.");
            return;
        }
        Console.WriteLine($"Existem {qtd} ocorrências da letra a.");
    }
}
