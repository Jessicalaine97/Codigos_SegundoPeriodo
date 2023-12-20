internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[] {55, 11, 2, 1, 0, 100};
        int numTrocas=0;

        numTrocas = Bublesort(vetor);

        Console.WriteLine($"O numero de trocas do vetor informado foi: {numTrocas}");

        Console.WriteLine();
    }

    public static int Bublesort(int[] vetor)
    {
        int fim=vetor.Length-1, pos, cont=0;

        do{
            pos=0;
            for(int i=0; i<fim; i++)
            {
                for(int j=i+1; j<vetor.Length; j++)
                {
                    if(vetor[i]> vetor[i+1])
                    {
                        Trocar(vetor, i, i+1);
                        cont++;
                        pos=i+1;
                    }
                }
            }
            fim=pos;
        }
        while(pos>0);

        return cont;
    }
    public static void Trocar(int[] vetor, int indice1, int indice2)
    {
        int aux = vetor[indice1];
        vetor[indice1]=vetor[indice2];
        vetor[indice2]=aux;
    }
}