static class MetodoInsercao
{
    public static void Executar(Produto[] vetor)
    {
        int j;

        for (int i = 1; i < vetor.Length; i++)
        {
            var aux = vetor[i].Preco;

            for (j = i - 1; j >= 0 && vetor[j].Preco > aux; j--)
                vetor[j + 1].Preco = vetor[j].Preco;
            
            vetor[j + 1].Preco = aux;
        }
    }
}