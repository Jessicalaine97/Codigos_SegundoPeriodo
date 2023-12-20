/*public class ListaEncadeada 
{
    public void AdicionarNoInicio(double valor)
    {
        var novoNo = new No { Valor = valor };
        if(primeiro == null)
            primeiro=novoNo;
        else
        {
            novoNo.Proximo=primeiro;
            primeiro=novoNo;
        }
    }

    public void AdicionarNoFinal(double valor)
    {
        var novoNo = new No { Valor = valor };
        if(primeiro == null)
            primeiro=novoNo;
        else
        {
            var ultimo = primeiro;
            while (ultimo.Proximo!=null)
                ultimo=ultimo.Proximo;
            ultimo.Proximo=novoNo;
        }
    }

    public void RemoverNoInicio()
    {
        if(primeiro!=null)
            primeiro=primeiro.Proximo;
    }

    public void RemoverNoFinal()
    {
        if(primeiro != null)
        {
            if(primeiro.Proximo ==null)
            primeiro=null;
            else
            {
                var penultimo = primeiro;
                while (penultimo?.Proximo?.Proximo!=null)
                {
                    penultimo=penultimo.Proximo;
                }  
                penultimo.Proximo=null;
            }
        }
    }

    public No? Primeiro
    {
        get { return primeiro; }
    }
        
    private No? primeiro=null;
}
*/


public class ListaEncadeada
{
    public void AdicionarNoInicio(double valor)
    {
        var novoNo=new No { Valor = valor };

        if (primeiro == null)
            primeiro = novoNo;
        else
        {
            novoNo.Proximo=primeiro;
            primeiro=novoNo;
        }
    }
    public void AdicionarNoFinal(double valor)
    {
         var novoNo=new No { Valor = valor};

        if (primeiro == null)
            primeiro=novoNo;
        else
        {
           var ultimo = primeiro;
           while(ultimo.Proximo!=null)
           {
                ultimo=ultimo.Proximo;
           }
            ultimo.Proximo=novoNo;
        }
    }
    public void RemoverNoInicio()
    {
        if (primeiro != null)
            primeiro=primeiro.Proximo;
    }
    public void RemoverNoFinal()
    {
        if (primeiro != null)
        {
            if(primeiro.Proximo==null)
                primeiro=null;
            else
            {
                var penultimo = primeiro;

                while(penultimo?.Proximo?.Proximo!=null)
                {
                    penultimo=penultimo.Proximo;
                }
                penultimo.Proximo=null;
            }
        }
    }

   public No? Primeiro
   {
    get { return primeiro; }
   }
   private No? primeiro=null;

}









