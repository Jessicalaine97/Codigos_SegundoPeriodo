static class MetodoInsercao
{
    public static void Executar(Atleta[] vetor)
    {
        int j;
        for(int i=1; i<vetor.Length-1; i++)
        {
            var aux=vetor[i];
            for(j=i+1; j>=0 && vetor[j]aux; j--)
                vetor[j+1]=vetor[j];
                vetor[j+1]=aux;
        }
    }
}