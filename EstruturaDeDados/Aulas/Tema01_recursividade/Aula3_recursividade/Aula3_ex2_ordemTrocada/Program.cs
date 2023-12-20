class Program
{
    static void Main(string[] args)
    {
        Imprime(5);
    }
    static void Imprime(int num)
    {
        if (num <= 0)
            return; //sai da subrotina

        Console.WriteLine(num);

        Imprime(num - 1);
    }
}

//Imprime(5) > 5 > Imprime(4) > 4 > Imprime(3) > 3 > Imprime(2) > 2 > Imprime(1) > 1 > Imprime(0) > sai da subrotina > finaliza