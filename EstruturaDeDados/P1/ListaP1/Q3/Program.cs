internal class Program
{
    private static void Main(string[] args)
    {
        double montante = 10000.0, valorRetirada = 1000.0;
        Aposentadoria(montante, valorRetirada, 0);
    }
    static void Aposentadoria (double montante, double valorRetirada, int qddRetiradas)
    {
        double valorRestante=0;

        if (valorRetirada*qddRetiradas >= montante)
            return;

        else
            valorRestante = montante - valorRetirada;

        Aposentadoria(montante*1.55, valorRetirada, qddRetiradas+1);
       

       Console.WriteLine($"Montante (R$): {montante}");

       Console.WriteLine($"Número de meses que a pessoa conseguirá fazer a retirada: {qddRetiradas}");
    }
}

/*Faça um procedimento que receba o montante reservado para a
aposentadoria de uma pessoa e a quantia que ela pretende retirar por mês. O
montante reservado é corrigido a cada mês com a taxa de 0,55%, aplicada logo após
a retirada. O procedimento deve imprimir o montante (após a retirada e a correção),
mês a mês. O procedimento também deve imprimir o número de meses em que a
pessoa conseguirá fazer a sua retirada. Restrição: não utilize comandos de
repetição.*/