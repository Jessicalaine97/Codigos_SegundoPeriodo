using System.Runtime.InteropServices;

static class InsercaoDireta
{
    public static void Executar (Atleta[] vetor)
    {
        int j;

        for(int i=1; i<vetor.Length; i++)
        {
            var aux = vetor[i].Peso;

            for(j=i-1; j>=0 && vetor[j].Peso>aux; j--)
                vetor[j+1].Peso=vetor[j].Peso;

            vetor[j+1].Peso=aux;
        }
    }
}