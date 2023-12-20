internal class Program
{
    private static void Main(string[] args)
    {
       /*var lista = new ListaEncadeada();

       lista.AdicionarNoInicio(10); //10
       lista.AdicionarNoInicio(1.5); // 1.5 10
       lista.AdicionarNoFinal(20); // 1.5 10 20
       lista.AdicionarNoFinal(40); //1.5 10 20 40

       var atual = lista.Primeiro;

       while(atual!=null)
       {
            Console.Write($"{atual.Valor} ");
            atual=atual.Proximo;
       }

       Console.WriteLine();

       lista.RemoverNoInicio(); //10 20 40
       lista.RemoverNoFinal(); //10 20

       atual=lista.Primeiro;

       while(atual!=null)
        {
            Console.Write($"{atual.Valor} ");
           atual=atual.Proximo;
        }

       Console.WriteLine();}*/



       var lista = new ListaEncadeada();
       lista.AdicionarNoInicio(10);
       lista.AdicionarNoInicio(20);
       lista.AdicionarNoFinal(20);
       lista.AdicionarNoFinal(40);
   
    var atual = lista.Primeiro;

    while(atual!=null)
    {
        Console.Write($"{atual.Valor} ");
        atual=atual.Proximo;
    }
    Console.WriteLine();

    lista.RemoverNoInicio();
    lista.RemoverNoFinal();

    atual=lista.Primeiro;

    while(atual!=null)
    {
        Console.Write($"{atual.Valor} ");
        atual=atual.Proximo;
    }
    Console.WriteLine();

    /*
    var pilha = new Pilha();

    pilha.Empilhar(2);
    pilha.Desempilhar();
    Console.WriteLine($"Topo: {pilha.Topo}");
    */
}
}


