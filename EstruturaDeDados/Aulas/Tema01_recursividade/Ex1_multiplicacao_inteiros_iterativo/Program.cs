internal class Program
{
    static int Multiplicar(int m, int n)
    {
        int resultado = 0;

        for (int i = 0; i < n; i++)
        {
            resultado+=m;
        }
        return resultado;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Multiplicar(7, 3));
    }
}