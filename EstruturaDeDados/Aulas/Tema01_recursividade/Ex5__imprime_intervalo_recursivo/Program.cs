internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Impressão do intervalo:");
        ImprimeIntervaloRecursivo(3, 7);

        Console.WriteLine("\nImpressão do intervalo ao contrário:");
        ImprimeIntervaloRecursivoContrario(3, 7);
    }
    static void ImprimeIntervaloRecursivo(int inicio, int fim)
    {
        if(inicio <= fim)
        {
            Console.Write($"{inicio} ");
            ImprimeIntervaloRecursivo(inicio + 1, fim);
        }
    }
    static void ImprimeIntervaloRecursivoContrario(int inicio, int fim)
    {
        if(inicio <= fim)
        {
            Console.Write($"{fim} ");
            ImprimeIntervaloRecursivoContrario(inicio, fim - 1);
        }
    }
}