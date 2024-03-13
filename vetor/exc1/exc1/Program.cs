using System;

namespace exc1
{

    class Program
    {
        static void Main()
        {
            // Definindo o tamanho do vetor
            int[] numeros = new int[5];

            Console.WriteLine("digite 5 numeros inteiros:");


            // vai ler os números do usuário e armazenar no vetor
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Numero {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // vai inicializar variáveis para armazenar o maior e o menor número
            int maior = numeros[0];
            int menor = numeros[0];

            // percorre o vetor para encontrar o maior e o menor número
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            // vai exibir o maior e o menor número
            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
        }
    }

}
