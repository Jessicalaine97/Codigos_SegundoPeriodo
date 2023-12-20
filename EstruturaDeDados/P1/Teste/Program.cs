internal class Program
{
    private static void Main(string[] args)
    {
        var atleta = new Atleta[]
        {
            new Atleta { Nome= "João", Peso = 88.8 },
            new Atleta { Nome= "Pedro", Peso = 66.6 },
            new Atleta { Nome= "Francisco", Peso = 77.7 }
        };

        MetodoBolha.Executar(atleta);

        Console.WriteLine("Metodo Bolha:");
        foreach (var item in atleta)
        {
            Console.WriteLine($" Nome: {item.Nome}, Peso: {item.Peso}");
        }
        Console.WriteLine("----------------------------------");

        InsercaoDireta.Executar(atleta);

        Console.WriteLine("Metodo da Inserção Direta:");
        foreach (var item in atleta)
        {
            Console.WriteLine($" Nome: {item.Nome}, Peso: {item.Peso}");
        }
        Console.WriteLine("----------------------------------");

        Selecao.Executar(atleta);

        Console.WriteLine("Metodo da Seleção:");
        foreach (var item in atleta)
        {
            Console.WriteLine($" Nome: {item.Nome}, Peso: {item.Peso}");
        }

        Console.ReadKey();
       
    }
}