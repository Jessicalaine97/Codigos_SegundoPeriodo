public class ListaEncadeada1
{
    public void AdicionarNoInicio(int valor)
    {
        var novoNo = new No {
            Valor = valor
        };

        novoNo.Proximo = inicio;
        inicio = novoNo;

        Tamanho++;
    }

    public void AdicionarNoFinal(int valor)
    {
        No novoNo = new() {
            Valor = valor
        };

        if (inicio == null)
            inicio = novoNo;
        else
        {
            var ultimo = inicio;

            while (ultimo.Proximo != null)
                ultimo = ultimo.Proximo;
            
            ultimo.Proximo = novoNo;
        }

        Tamanho++;
    }

    public void RemoverNoInicio()
    {
        if (inicio == null)
            throw new Exception("A lista está vazia.");

        inicio = inicio.Proximo;
        Tamanho--;
    }

    public void RemoverNoFinal()
    {
        var penultimo = inicio;

        if (penultimo == null)
            throw new Exception("A lista está vazia.");

        if (penultimo.Proximo == null)
            inicio = null;
        else
        {
            while (penultimo.Proximo?.Proximo != null)
                penultimo = penultimo.Proximo;

            penultimo.Proximo = null;
        }

        Tamanho--;
    }

    

    public void ParaCada(Action<int> visitar)
    {
        var atual = inicio;

        while (atual != null)
        {
            visitar(atual.Valor);
            atual = atual.Proximo;
        }
    }

    public int Tamanho { get; private set; }

    private No? inicio = null;
}