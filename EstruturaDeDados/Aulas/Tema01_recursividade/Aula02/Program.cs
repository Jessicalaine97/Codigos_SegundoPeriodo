class Program
{
    static void Main(string[] args)
    {
        int idade=20;
        Alterar(idade);
        console.WriteLine(ref idade);

    //sem o ref daria 20-> passagem por valor
    //com o ref daria 40-> passagem por referencia -> ambos apontam para o msm endereço de memoria

    }
    static void Alterar(ref int numero)
    {
        numero=numero*2;
    }
}

/ See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//if ternario
string nome=nomelido != null? nomelido:""; 

string nome=Console.Readline() ?? "";
// se for string le, se nao é vazio