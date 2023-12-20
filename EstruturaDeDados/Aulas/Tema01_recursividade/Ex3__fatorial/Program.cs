internal class Program
{
    static int Fatorial(int m)
    {
        if (m==0)
            return 1;
        else
            return m* Fatorial(m-1);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Fatorial(3));
    }
}

