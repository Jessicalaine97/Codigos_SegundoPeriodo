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

        Imprime(num - 1);

        Console.WriteLine(num);
    }
}

//Imprime(5) > Imprime(4) > Imprime(3) > Imprime(2) > Imprime(1) >> Imprime(0) > return > finaliza
//Impressao: 1 2 3 4 5