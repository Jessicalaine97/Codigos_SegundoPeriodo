internal class Program
{
    private static void Main(string[] args)
    {
        //em c# é obrigado a inicializar a variavel quando coloco var -> var nome = "Jessica";
        // se tiver ? na frente da string significa que posso atribuir null ou pode receber um valor;
        string nome;
        //var int
        var salario = 1234;
        //var double
        var salario2 = 1234.0;
        int idade = 20;
        nome = "Jessica";

        Console.WriteLine(nome);
        Console.WriteLine(nome.ToUpper());
        //Interpolacao de strings:
        Console.WriteLine($"Nome: {nome}, idade: {idade}, salário: {salario + 1}.");
    }
}