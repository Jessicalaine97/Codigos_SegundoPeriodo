static class MetodoSelecao
{
    public static void Executar(Atleta[] vetor)
    {
       for(int i=1; i<vetor.Length-1; i++)
        {
            var menor=i;
            for(int j=i+1;j<vetor.Length;j++)
            {
                if(vetor[j].Peso<vetor[menor].Peso)
                menor=j;

                if(i!=menor)
                    Trocar(vetor, i, menor);
            } 
        }
    }
    static void Trocar(Atleta[] vetor, int indice1, int indice2)
    {
        var aux=vetor[indice1];
        vetor[indice1]=vetor[indice2];
        vetor[indice2]=aux;
    }
}