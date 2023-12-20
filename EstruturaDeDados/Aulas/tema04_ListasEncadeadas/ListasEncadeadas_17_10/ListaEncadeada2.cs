public class ListaEncadeada2
{
    public void AdicionarNoprimeiro(int valor)
    {
        var novoNo = new No {
            Valor = valor
        };

        if (primeiro == null)
            primeiro = ultimo = novoNo;
        else
        {
            novoNo.Proximo = primeiro;
            primeiro = novoNo;
        }

        Tamanho++;
    }

    public void AdicionarNoFinal(int valor)
    {
        No novoNo = new() {
            Valor = valor
        };

        if (primeiro == null)
            primeiro = ultimo = novoNo;
        else
        {
            if (ultimo != null)
            {
                ultimo.Proximo = novoNo;
                ultimo = novoNo;
            }
        }

        Tamanho++;
    }

    public void RemoverNoprimeiro()
    {
        if (primeiro == null)
            throw new Exception("A lista está vazia.");

        if (primeiro == ultimo)
            primeiro = ultimo = null;
        else
            primeiro = primeiro.Proximo;

        Tamanho--;
    }

    public void RemoverNoFinal()
    {
        if (primeiro == null)
            throw new Exception("A lista está vazia.");

        if (primeiro == ultimo)
            primeiro = ultimo = null;
        else
        {
            var penultimo = primeiro;

            while (penultimo?.Proximo?.Proximo != null)
                penultimo = penultimo.Proximo;

            if (penultimo != null)
            {
                penultimo.Proximo = null;
                ultimo = penultimo;
            }
        }

        Tamanho--;
    }

    public void ParaCada(Action<int> visitar)
    {
        var atual = primeiro;

        while (atual != null)
        {
            visitar(atual.Valor);
            atual = atual.Proximo;
        }
    }

    public int Tamanho { get; private set; }

    private No? primeiro = null;
    private No? ultimo = null;
}