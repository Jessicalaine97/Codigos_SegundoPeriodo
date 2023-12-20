class Program
{
    static void Main(string[] args)
    {
        Imprime (1, 5);
    }
    static void Imprime(int numInicial, int numFinal)
    {
        if (numInicial > numFinal)
            return; //return sai da subrotina

        Console.WriteLine(numInicial);

        Imprime(numInicial +1, numFinal);
    }
}

//Imprime(1, 5) > 1 > Imprime(2, 5) > 2 > Imprime(3, 5) > 3 > Imprime(4, 5) > 4 > Imprime(5, 5) > 5 > Imprime(6, 5) > return > sai da subrotina > finaliza