internal class Program
{
    static int Fibonacci(int m)
    {
        if (m <= 2)
            return 1;
        else
            return Fibonacci(m - 1) + Fibonacci(m - 2);
    }
    private static void Main(string[] args)
    {
        int m;

        Console.Write("Entre com a posição do número desejado: ");
        m = Convert.ToInt32(Console.ReadLine());

        Fibonacci(m);

        Console.WriteLine($"O número na posição {m} na sequência de Fibonacci é {Fibonacci(m)}.");

        Console.ReadKey();
    }
}