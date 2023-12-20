public class Fila
{
    /*public void Adicionar(double valor)
    {
        var novoNo = new No { Valor = valor};
        if (primeiro == null)
            primeiro = ultimo = novoNo;
        else
        {
            ultimo.Proximo=novoNo;
            ultimo=novoNo;
        }
    }
    public void Remover ()
    {
        if (primeiro == null)
            throw new Exception("Não há elementos a serem removidos");
        if (primeiro == ultimo)
            primeiro=ultimo=null;
        else
            primeiro=primeiro.Proximo;
    }

public double? Primeiro
{
    get {return primeiro.Valor; }
}
private No? primeiro=null;

private No? ultimo=null;*/


public void Adicionar (double valor)
{
    var novoNo = new No{Valor = valor};
    if(primeiro==null)
        primeiro=ultimo=novoNo;
    else
    {
        ultimo.Proximo=novoNo;
        ultimo=novoNo;
    }
}

public void Remover ()
{
    if (primeiro == null)
        throw new Exception("Não há elementos a serem removidos");
    if (primeiro == ultimo)
        primeiro = ultimo = null;
    else
        primeiro=primeiro.Proximo;
}

public double? Primeiro
{
    get {return primeiro?.Valor;}
}
private No? primeiro = null;

private No? ultimo = null;

}