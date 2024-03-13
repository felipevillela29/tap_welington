using System;

class Program
{
    static void Main()
    {
        // Defini o tamanho do vetor
        int[] numeros = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");

        // ler os números do usuário e armazenar no vetor
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Solicita o número alvo ao usuário
        Console.Write("Digite o número alvo para buscar no vetor: ");
        int numeroAlvo = Convert.ToInt32(Console.ReadLine());

        // verifica se o número alvo está presente no vetor
        bool numeroEncontrado = false;
        foreach (int numero in numeros)
        {
            if (numero == numeroAlvo)
            {
                numeroEncontrado = true;
                break; // vai sair do loop se o número for encontrado
            }
        }

        // Exibir o resultado
        if (numeroEncontrado)
        {
            Console.WriteLine($"O número {numeroAlvo} foi localizado no vetor.");
        }
        else
        {
            Console.WriteLine($"O número {numeroAlvo} não foi localizado no vetor.");
        }
    }
}
