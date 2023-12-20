internal class Program
{
    private static void Main(string[] args)
    {
        int num = 6; //6, 28, 496, 8128
        Console.WriteLine($"O numero {num} é perfeito? {numeroPerfeito(num)}");
    }
    static bool numeroPerfeito(int num)
    {
        return numeroPerfeito(num, 1, 0);
    }
    static bool numeroPerfeito(int num, int atual, int soma)
    /*static bool numeroPerfeito(int num=0, int atual=1, int soma) -> apaga a funcao de cima*/
    {
        if(atual >= num)
        {
            return soma == num;
        }
        if(num % atual == 0)
        {
            soma+=atual;
        }
        return numeroPerfeito(num, atual + 1, soma);
    }
}

/*Questão 1) Faça uma função recursiva que receba um número inteiro por parâmetro e retorne true se o número for um número perfeito ou false caso contrário. Um número perfeito é um número natural para o qual a soma de todos os seus divisores naturais é igual ao próprio número. Esta função não pode utilizar comandos de repetição.*/


