//ListaEncadeada lista = new ListaEncadeada();
//var lista = new ListaEncadeada();
ListaEncadeada1 lista = new();

lista.AdicionarNoInicio(5);
lista.AdicionarNoInicio(2);
lista.AdicionarNoInicio(1);
lista.AdicionarNoFinal(7);
lista.AdicionarNoFinal(10);

lista.RemoverNoFinal();
lista.RemoverNoInicio();

lista.ParaCada(x => Console.WriteLine(x));
