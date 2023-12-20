static class MetodoBolha
{
    public static void Executar(int[] vetor)
    {
        for (int i = 0; i < vetor.Length - 1; i++)
            for (int j = 0; j < vetor.Length - 1-i; j++)
                if (vetor[j] > vetor[j+1])
                    Trocar(vetor, j, j + 1);
    }

    static void Trocar(int[] vetor, int indice1, int indice2)
    {
        var aux = vetor[indice1];
        vetor[indice1] = vetor[indice2];
        vetor[indice2] = aux;
    }
}