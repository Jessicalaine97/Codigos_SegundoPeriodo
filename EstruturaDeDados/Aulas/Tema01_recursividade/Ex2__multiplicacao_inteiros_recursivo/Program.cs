internal class Program
{
    static int Multiplicar(int m, int n)
    {
        if (n==0)
            return 0;
        else
            return m + Multiplicar(m, n-1);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Multiplicação dos elementos:");
        Console.WriteLine(Multiplicar(7, 3));

        Console.WriteLine("Impressão do intervalo:");
        ImprimeIntervaloRecursivo(3, 7);
    }
    static void ImprimeIntervaloRecursivo(int inicio, int fim)
    {
        if(inicio <= fim)
        {
            Console.Write($"{inicio} ");
            ImprimeIntervaloRecursivo(inicio + 1, fim);
        }
    }
}