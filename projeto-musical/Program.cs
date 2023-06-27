// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound\n";
// List<string> listaDasBandas = new List<string> { "Renascer Praise", "Regis Danese", "Orquestra Alfa" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Raiz Coral", new List<int> { 10, 9, 7 });
bandasRegistradas.Add("Orquestra Alfa", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    /* 
        Quando passado o valor do ReadLine para a variavel, tem a possibilidade de retornar null. Para evitar, usamos o ! apos os        parenteses
    */
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBandas();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Falou 🚀🚀🚀");
            break;
        default:
            Console.WriteLine("Tchau ***");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    /* listaDasBandas.Add(nomeDaBanda); */
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    /* for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    } */

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar para o menu principal");
    Console.ReadKey(); // O programa vai esperar o usuario digitar algo para prosseguir
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quatidadeDeLetras = titulo.Length;
    // Um carácter usa aspas simples, mas uma string é aspas dupla
    string asteriscos = string.Empty.PadLeft(quatidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBandas()
{
    // digite qual banda deseja avaliar
    // se a banda existir no dicionario >> atribuir uma nota
    // se não, volta para o menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar para o menu principal..");
        Console.ReadKey();
    }
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirMedia() {
    // digite qual banda deseja ver a Média
    // se a banda existir no dicionario >> exibir sua média
    // se não, volta para o menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda)) {
        if(bandasRegistradas[nomeDaBanda].Count == 0) {
            Console.Write($"A banda {nomeDaBanda} ainda não tem avalioções.");
            Thread.Sleep(4000);   
        } else
        {
            double media = Math.Round(bandasRegistradas[nomeDaBanda].Average(),2);
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {media}");
            Thread.Sleep(4000);   
        }
        
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar para o menu principal..");
        Console.ReadKey();
    }
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();