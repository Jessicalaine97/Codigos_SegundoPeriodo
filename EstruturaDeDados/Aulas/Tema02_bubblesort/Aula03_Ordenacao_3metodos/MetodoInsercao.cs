static class MetodoInsercao
{
    public static void Executar(int[] vetor)
    {
        int j;

        for (int pri = 1; pri < vetor.Length; pri++)
        {
            int aux = vetor[pri];

            for (j = pri - 1; j >= 0 && vetor[j] > aux; j--)
                vetor[j + 1] = vetor[j];
            
            vetor[j + 1] = aux;
        }
    }
}