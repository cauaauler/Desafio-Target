using System;

class Program
{
    static void Main()
    {
        int INDICE = 12, SOMA = 0, K = 1; 
        try {
            while (K < INDICE) {
                K = K + 1;
                SOMA = SOMA + K;
            }
        } catch (Exception e) {
            Console.WriteLine("Erro: " + e.Message);
            Console.WriteLine("StackTrace: " + e.StackTrace);
        }
        Console.WriteLine(SOMA);
    }
}
