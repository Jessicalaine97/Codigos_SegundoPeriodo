internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[] {-1, -2, 0, -2, 1};

        Console.WriteLine($"Número negativos: {MultiplicaMenos1(vetor, 0, 0)}");

    }
    static int MultiplicaMenos1(int[] vetor, int indice, int cont)
    {
        if(indice >= vetor.Length)
            return cont;

        if(vetor[indice] < 0)
        {
            vetor[indice]*=-1;
            cont++;
        }

        return MultiplicaMenos1(vetor, indice+1, cont);
    }
    
}