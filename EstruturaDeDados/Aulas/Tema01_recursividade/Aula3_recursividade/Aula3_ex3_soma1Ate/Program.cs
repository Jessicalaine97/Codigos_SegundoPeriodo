/*using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Soma de 1 até 3: {SomaDe1Ate(3)}");
        SomaDe1Ate(3);
    }
    static int SomaDe1Ate(int num)
    {
        if (num <= 0)
            return 0; 

        return num + SomaDe1Ate(num - 1);
    }
}
//SomaDe1Ate(3) > 3 + SomaDe1Ate(2) // return = 3
//SomaDe1Ate(2) > 2 + SomaDe1Ate(1) // return = 3 + 2 = 5
//SomaDe1Ate(1) > 1 + SomaDe1Ate(0) // return = 3 + 2 + 1 = 6
//SomaDe1Ate(0) > return > sai subrotina
//Impressao (main): 6*/

