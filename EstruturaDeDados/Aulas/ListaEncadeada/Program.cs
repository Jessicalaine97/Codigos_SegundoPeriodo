internal class Program
{
    private static void Main(string[] args)
    {
        var lista = new ListaEncadeada();

        lista.AdicionarNoInicio(10.0); //10
        lista.AdicionarNoInicio(1.5); //1.5, 10
        lista.AdicionarNoFinal(20.0); //1.5, 10, 20

        lista.AdicionarNoFinal(30.2); //1.5, 10, 20, 30.2

        var atual = lista.Primeiro;

        while (atual != null)
        {
            Console.Write($"{atual.Valor}  ");
            atual = atual.Proximo;
        }

        Console.WriteLine();

        lista.RemoverNoFinal(); //1.5, 10, 20
        lista.RemoverNoInicio(); //10, 20

        atual = lista.Primeiro;

        while (atual != null)
        {
            Console.Write($"{atual.Valor}  ");
            atual = atual.Proximo;
        }

        Console.WriteLine();
    }
}