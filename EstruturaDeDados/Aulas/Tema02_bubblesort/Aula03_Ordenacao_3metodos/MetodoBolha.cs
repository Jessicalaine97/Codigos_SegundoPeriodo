static class MetodoBolha
{
    /*public static void Executar(Produto[] vetor)
    {
        //Ordenar por preço
        int fim = vetor.Length - 1, pos;
        
        do
        {
            pos = 0;

            for (int i = 0; i < fim; i++)
            {
                if (vetor[i].Preco > vetor[i+1].Preco)
                {
                    Trocar(vetor, i, i + 1);
                    pos = i + 1;
                }
            }

            fim = pos;
        } while (pos > 0);
    }

    static void Trocar(Produto[] vetor, int indice1, int indice2)
    {
        var aux = vetor[indice1];
        vetor[indice1] = vetor[indice2];
        vetor[indice2] = aux;
    }*/

    public static void Executar(int[] vetor)
    {
        int fim = vetor.Length - 1, pos;
        
        do
        {
            pos = 0;

            for (int i = 0; i < fim; i++)
            {
                if (vetor[i] > vetor[i+1])
                {
                    Trocar(vetor, i, i + 1);
                    pos = i + 1;
                }
            }

            fim = pos;
        } while (pos > 0);
    }

    static void Trocar(int[] vetor, int indice1, int indice2)
    {
        var aux = vetor[indice1];
        vetor[indice1] = vetor[indice2];
        vetor[indice2] = aux;
    }
}