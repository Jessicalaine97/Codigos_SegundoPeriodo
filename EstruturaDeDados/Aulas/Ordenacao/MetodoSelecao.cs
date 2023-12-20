static class MetodoSelecao
{
    public static void Executar(Produto[] vetor)
    {
        int menor, pos, j;

        for (pos = 0; pos < vetor.Length - 1; pos++)
        {
            menor = pos;

            for (j = pos + 1; j < vetor.Length; j++)
                if (vetor[j].Preco < vetor[menor].Preco)
                    menor = j;
                
            if (menor != pos)
                Trocar(vetor, menor, pos);
        }
    }

    static void Trocar(Produto[] vetor, int indice1, int indice2)
    {
        var aux = vetor[indice1];
        vetor[indice1] = vetor[indice2];
        vetor[indice2] = aux;
    }
}
