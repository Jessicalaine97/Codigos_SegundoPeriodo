using System.Runtime.InteropServices.JavaScript;

internal class Program
{
    private static void Main(string[] args)
    {
        var vetor = new double[] {1.11, 2.22, 3.33, 4.44, 5.55};
        Insercao(vetor);

        foreach (var item in vetor)
            Console.Write($"{item} ");

    }
        static void Insercao(double[] vetor)
        {
            //a parte ordenada esta entre 0 e 1, pot isso i comeca do 1
            for (int i=1; i<vetor.Length; i++)
            {
                double chave = vetor[i];
                int j=i-1;

                while(j>=0 && chave <vetor[j])
                {
                    vetor[j+1]=vetor[j];
                    j--;
                }
                 vetor[j+1]=chave;
            }
        }
}