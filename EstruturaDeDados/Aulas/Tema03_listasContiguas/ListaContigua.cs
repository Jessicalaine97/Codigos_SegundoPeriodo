class ListaContigua
{
    public void AdicionarNoInicio(int valor)
    {
        if (inicio == 0)
            throw new Exception("A lista atingiu o limite para inserção no início."); //construção usada para lançar uma exceção (erro/condição excepicional)

        elementos[--inicio] = valor; //decrementa o valor de inicio e adiciona  no inicio
    }

    public void AdicionarNoFinal(int valor)
    {
        if (final == MAX - 1)
            throw new Exception("A lista atingiu o limite para inserção no final.");
        
        elementos[++final] = valor;
    }

    public void RemoverNoInicio()
    {
        if (inicio > final) //verifica se há elementos na lista
            throw new Exception("Não existem elementos a serem removidos.");
        
        inicio++; //incrementa removendo no inicio
    }

    public void RemoverNoFinal()
    {
        if (inicio > final) //verifica se há elementos na lista
            throw new Exception("Não existem elementos a serem removidos.");

        final--; //incrementa removendo no final
    }

    public void ParaCada(Action<int> metodo) //metodo generico que percorre toda a lista
    {
        for (int i = inicio; i <= final; i++)
            metodo(elementos[i]);
    }

    public int this[int i] //indexador para a classe int
    // int i é o indice da lista ex: vet[i]
    {
        get //leitura
        {
            if (i < 0 || i >= Tamanho) 
                throw new Exception("O índice está fora dos limites da lista."); //lista vai de 0 a tamanho

            return elementos[inicio + i]; //se o indice for valido retorna elemento da lista
        }

        set //gravaçao
        {
            if (i < 0 || i >= Tamanho)
                throw new Exception("O índice está fora dos limites da lista.");

            elementos[inicio + i] = value;
        }
    }
    //permite acessar os elementos da lista, ex: minhaLista[2] = 42

    public int Tamanho { get { return final - inicio + 1; } } //calcula o tamanho da lista int sem percorre-la

    private const int MAX = 100;
    private int inicio = MAX / 2;
    private int final = MAX / 2 - 1;
    private int[] elementos = new int[MAX];
}