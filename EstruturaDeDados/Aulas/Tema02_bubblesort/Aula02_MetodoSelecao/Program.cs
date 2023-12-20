using System.Runtime.InteropServices.JavaScript;

internal class Program
{
    private static void Main(string[] args)
    {
        var vetor = new double[] {6.11, 2.22, 9.33, 4.44, 20.55};
        Insercao(vetor);

        foreach (var item in vetor)
            Console.Write($"{item} ");

    }
        static void Insercao(double[] vetor)
        {
            //a parte ordenada esta entre 0 e 1
            for (int i=0; i<vetor.Length-1; i++)
            {
                int indMenor=i;
                for (int j=i+1; j<vetor.Length; j++)
                {
                    if(vetor[j]<vetor[indMenor])
                    indMenor=j;
                }

                if(i != indMenor)
                    Troca(vetor, i, indMenor);
            }
        }
        static void Troca(double[] vetor, int i, int j)
        {
            var aux=vetor[i];
            vetor[i]=vetor[j];
            vetor[j]=aux;
        }
}