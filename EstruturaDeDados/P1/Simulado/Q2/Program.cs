/*Questão 2) Faça três procedimentos. Cada procedimento deve receber um vetor de atletas e reorganizar o mesmo em ordem decrescente do peso do atleta. O primeiro procedimento deve utilizar o método bolha, o segundo o método da inserção e o terceiro o método da seleção.*/


var atletas = new Atleta[]
{
    new Atleta { Nome = "Atleta1", Peso = 88.8 },
    new Atleta { Nome = "Atleta2", Peso = 55.5 },
    new Atleta { Nome = "Atleta3", Peso = 77.7 }
};

MetodoBolha.Executar(atletas);

foreach (var item in atletas)
    Console.WriteLine($"{item.Nome}: {item.Peso}");
    
