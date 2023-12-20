var lista = new ListaEncadeada();

lista.AdicionarNoInicio(10);
lista.AdicionarNoInicio(1.5);
lista.AdicionarNoFinal(20);
lista.AdicionarNoFinal(30.2);

var atual = lista.Primeiro;

while (atual != null)
{
    Console.Write($"{atual.Valor}  ");
    atual = atual.Proximo;
}

Console.WriteLine();

lista.RemoverNoFinal();
lista.RemoverNoInicio();

atual = lista.Primeiro;

while (atual != null)
{
    Console.Write($"{atual.Valor}  ");
    atual = atual.Proximo;
}

Console.WriteLine();



public class ListaEncadeada
{
    public void AdicionarNoInicio(double valor)
    {
        var novoNo = new No { Valor = valor };

        if (primeiro == null)
            primeiro = novoNo;
        else
        {
            novoNo.Proximo = primeiro;
            primeiro = novoNo;
        }
    }

    public void AdicionarNoFinal(double valor)
    {
        var novoNo = new No { Valor = valor };

        if (primeiro == null)
            primeiro = novoNo;
        else
        {
            var ultimo = primeiro;

            while (ultimo.Proximo != null)
                ultimo = ultimo.Proximo;
            
            ultimo.Proximo = novoNo;
        }
    }

    public void RemoverNoInicio()
    {
        if (primeiro != null)
        {
            primeiro = primeiro.Proximo;
        }
    }

    public void RemoverNoFinal()
    {
        if (primeiro != null)
        {
            if (primeiro.Proximo == null)
                primeiro = null;
            else
            {
                var penultimo = primeiro;

                while (penultimo?.Proximo?.Proximo != null)
                {
                    penultimo = penultimo.Proximo;
                }

                penultimo.Proximo = null;
            }
        }
    }

    public No? Primeiro
    {
        get { return primeiro; }
    }

    private No? primeiro = null;
}

//ao inves de para cada
public class No
{
    public double Valor { get; set; }
    public No? Proximo { get; set; } = null;
}









