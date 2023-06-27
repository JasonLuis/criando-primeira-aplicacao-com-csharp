Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

void PedirNomeCarro()
{
    Console.Write("Digite o nome do veiculo para saber a média de vendas: ");
    string nomeCarro = Console.ReadLine()!;
    ExibirMedia(nomeCarro);
}

void ExibirMedia(string nomeCarro)
{
    Console.Clear();
    if (vendasCarros.ContainsKey(nomeCarro))
    {
        double mediaVendas = vendasCarros[nomeCarro].Average();
        Console.WriteLine($"A média de vendas do {nomeCarro} é {mediaVendas}");
    }
    else
    {
        Console.WriteLine("A média de vendas desse veiculo não esta disponível!\n");
    }
    Console.WriteLine("Digite uma tecla para encerrar o programa");
    Console.ReadKey();
}

PedirNomeCarro();