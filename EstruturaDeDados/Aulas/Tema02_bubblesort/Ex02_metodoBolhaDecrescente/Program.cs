internal class Program
{
    const int TAM = 9;
    private static void Main(string[] args)
    {
        double[] vetor = new double[TAM];

        Console.WriteLine($"Considerando um vetor de {TAM} posiçoes, insira seus valores: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("  Vetor[{0}]: ", i + 1);
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        BubbleSort(vetor);

        Console.ReadKey();
    }
    static void Troca(double[] vetor, int i, int j)
    {
        double aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }
    static void BubbleSort(double[] vetor)
    {
        int fim = vetor.Length - 1, posicao;

        do
        {
            posicao = -1;
            for (int i = 0; i < fim; i++)
            {
                if (vetor[i] < vetor[i + 1])
                {
                    Troca(vetor, i, i + 1);
                    posicao = i;
                }
            }
            fim = posicao;
        }
        while (fim > 0);

        ImprimeVetor(vetor);
    }
    static void ImprimeVetor(double[] vetor)
    {
        Console.WriteLine("\nImpressão do vetor na ordem decrescente: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("  Vetor[{0}]: {1}", i, vetor[i]);
        }
    }
}