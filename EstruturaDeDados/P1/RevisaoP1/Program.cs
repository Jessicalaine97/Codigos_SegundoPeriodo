internal class Program
{
    private static void Main(string[] args)
    {
        //Imprimir os numeros entre dois intervados
        imprimeIntervalo(2, 5);
    }
    static void imprimeIntervalo (int inicio, int fim) 
    {
        if (inicio > fim)
        {
            var = aux;
            inicio = fim;
            fim = aux;
        }
        imprimeIntervalo(inicio, fim);
    }

    static void imprimeIntervaloRecursivo (int inicio, int fim) 
    {
        if (inicio > fim)
        {
            console.write();
            return; 
        }

        console.writeline($"{inicio}");
        imprimeIntervaloRecursivo(inicio + 1, fim);

    }
}
//soma
// if inicio > fim -> imprime soma, return //