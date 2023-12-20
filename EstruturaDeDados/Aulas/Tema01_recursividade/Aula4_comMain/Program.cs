internal class Program
{
    private static void Main(string[] args)
    {
        int inicio = 1, fim = 5;

        imprimeNumerosIntervalo(inicio, fim);
        Console.WriteLine($"Soma do intervalo entre {inicio} e {fim}: {SomaIntervalo(inicio, fim)}.");
        Console.WriteLine($"Soma dos pares entre {inicio} e {fim}: {SomaPares(inicio, fim)}.");
        Console.WriteLine($"Soma dos impares entre {inicio} e {fim}: {SomaImpares(inicio, fim)}.");
    }
    static void imprimeNumerosIntervalo(int primeiro, int ultimo)
    {
        if (primeiro <= ultimo)
        {
            Console.WriteLine(primeiro);
            imprimeNumerosIntervalo(primeiro + 1, ultimo);
        }
    }
    static int SomaIntervalo(int primeiro, int ultimo)
    {
        if (primeiro > ultimo)
            return 0;

        return primeiro + SomaIntervalo(primeiro + 1, ultimo);
    }
    static int SomaPares(int primeiro, int ultimo)
    {
        if (primeiro > ultimo)
            return 0;

        if (primeiro % 2 == 0)
            return primeiro + SomaPares(primeiro + 1, ultimo);

        else
            return SomaPares(primeiro + 1, ultimo);
    }
    static int SomaImpares(int primeiro, int ultimo)
    {
        if (primeiro > ultimo)
            return 0;

        if (primeiro % 2 == 1)
            return primeiro + SomaImpares(primeiro + 1, ultimo);

        else
            return SomaImpares(primeiro + 1, ultimo);
    }
}


