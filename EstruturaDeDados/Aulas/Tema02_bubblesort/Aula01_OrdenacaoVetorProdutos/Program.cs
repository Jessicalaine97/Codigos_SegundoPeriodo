var produtos = new Produto[]
{
    new Produto { Descricao = "Coca-Cola", Preco = 5.5 },
    new Produto { Descricao = "Pepsi", Preco = 5.0 },
    new Produto { Descricao = "Caixa de Fósforo", Preco = 1.5 },
    new Produto { Descricao = "Pizza", Preco = 55 },
    new Produto { Descricao = "Paçoca", Preco = 0.5 }
};

MetodoBolha.Executar(produtos);

Console.WriteLine("Ordenacao do vetor de produtos:");

foreach (var item in produtos)
    Console.WriteLine($"{item.Descricao}: {item.Preco}");

