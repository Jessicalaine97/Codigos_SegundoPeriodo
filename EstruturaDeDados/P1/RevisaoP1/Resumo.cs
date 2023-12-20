//Bubblersort
static void Bubblersort(int[] vetor)
{
    int fim = vetor.length - 1, pos;
    do
    {
        pos = 0;
        for (int i = 0; i < fim; i++)
        {
            if (vetor[i] > vetor[i + 1])
            {
                Trocar(vetor, i, i + 1);
                pos = i + 1;
            }
        }
        fim = pos;
    }
    while (pos > 0)
}
static void Trocar(int[] vetor, int indice1, int indice2)
{
    int aux = vetor[indice1];
    vetor[indice1] = vetor[indice2];
    vetor[indice2] = aux;
}


//Insercao Direta
static void InsercaoDireta(int[] vetor)
{
    int j;
    for (int i = 1; i < vetor.length; i++)
    {
        int aux = vetor[i];
        for (int j = i - 1; j >= 0 && vetor[j] > aux; j--)
            vetor[j + 1] = vetor[j];

        vetor[j + 1] = aux;
    }
}

//Selecao
static void Selecao(int[] vetor)
{
    for (int i = 0; i < vetor.length - 1; i++)
    {
        int menor = i;
        for (int j = i + 1; j < vetor.length; j++)
        {
            if (vetor[j] < vetor[menor])
                menor = j;
        }
        if (i != menor)
            Trocar(vetor, i, menor);
    }

}
static void Trocar(int[] vetor, int indice1, int indice2)
{
    int aux = vetor[indice1];
    vetor[indice1] = vetor[indice2];
    vetor[indice2] = aux;
}