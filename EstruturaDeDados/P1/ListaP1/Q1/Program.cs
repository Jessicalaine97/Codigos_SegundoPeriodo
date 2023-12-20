internal class Program
{
    private static void Main(string[] args)
    {
        int n = 26;
        ImprimeDivisores2e3(n);
    }
    static void ImprimeDivisores2e3(int n)
    {
        if (n == 0)
            return;

        if (n % 2 == 0 && n % 3 == 0)
            Console.WriteLine(n);

        ImprimeDivisores2e3(n - 1);
    }
}