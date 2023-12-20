/*Questão 1) Faça uma função recursiva que receba um número inteiro por parâmetro e retorne true se o número for um número perfeito ou false caso contrário. Um número perfeito é um número natural para o qual a soma de todos os seus divisores naturais é igual ao próprio número. Esta função não pode utilizar comandos de repetição.*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        int num = 6;

        Console.WriteLine($"O numero {num} é perfeito? {0}", {ePerfeito(num)});
    }
    static bool ePerfeito (int num)
    {
        return ePerfeito(num, 1, 0);
    }
    static bool ePerfeito (int num, int atual, int soma)
    {
        if(atual >= num)
            return soma == num;

        if(num % atual == 0)
            soma+=atual;

        return ePerfeito(num, atual+1, soma);
    }
}