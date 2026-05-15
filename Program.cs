using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativa = 0;
        int palpites = 0;

        Console.WriteLine("=== Jogo de Adivinhação ===");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100!");

        while (tentativa != numeroSecreto)
        {
            Console.Write("Digite seu palpite: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out tentativa))
            {
                palpites++;

                if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo! Tente novamente.");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("Muito alto! Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou em {palpites} tentativas!");
                }
            }
            else
            {
                Console.WriteLine("Digite apenas números válidos!");
            }
        }
    }
}