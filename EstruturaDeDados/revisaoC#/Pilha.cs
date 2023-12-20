public class Pilha
{
    /*public void Empilhar (double valor)
    {
        var novoNo = new No {Valor = valor };

        novoNo.Proximo=topo;
        topo=novoNo;
    }
    public void Desempilhar()
    {
        if(topo == null)
            throw new Exception("Não há elementos a serem desimpilhados");
        else
            topo=topo.Proximo;
    }

    public double? Topo
    {
        get { return topo?.Valor;}
    }
    private No? topo=null;*/



    public void Empilhar (double valor)
    {
        var novoNo = new No {Valor = valor};

        novoNo.Proximo=topo;
        topo=novoNo;

    }
     public void Desempilhar ()
    {
        if (topo == null)
            throw new Exception("Não há elementos para serem desempilhados");
        topo=topo.Proximo;
        
    }
    private Double? Topo
    {
        get { return topo?.Valor;}
    }
    public No topo=null;
}