static class MetodoBolha
{
    public static void Executar(Atleta[] vetor)
    {
        int fim = vetor.Length-1, pos;
        do
        {
            pos=0;
            for(int i=0; i<fim; i++)
            {
                if(vetor[i].Peso > vetor[i+1].Peso)
                {
                    Trocar(vetor, i, i+1);
                    pos=i+1;
                }
            }
            fim=pos;
        }
        while(pos>0);
    }
    static void Trocar(Atleta[] vetor, int indice1, int indice2)
    {
        var aux=vetor[indice1];
        vetor[indice1]=vetor[indice2];
        vetor[indice2]=aux;
    }
}