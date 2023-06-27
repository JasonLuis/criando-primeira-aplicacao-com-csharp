Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

Console.WriteLine(@"
▄▀█ █▀▄ █ █░█ █ █▄░█ █░█ █▀▀   █▀█   █▄░█ █░█ █▀▄▀█ █▀▀ █▀█ █▀█
█▀█ █▄▀ █ ▀▄▀ █ █░▀█ █▀█ ██▄   █▄█   █░▀█ █▄█ █░▀░█ ██▄ █▀▄ █▄█");

bool acertou = false;

do
{
    Console.Write("\n\nQual o número que eu pensei? ");
    int numeroEscolhido = int.Parse(Console.ReadLine()!);

    acertou = numeroEscolhido == numeroSecreto;
    if (acertou)
    {
        Console.WriteLine();
        Console.WriteLine(@"
██████╗░░█████╗░██████╗░░█████╗░██████╗░███████╗███╗░░██╗░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝████╗░██║██╔════╝
██████╔╝███████║██████╔╝███████║██████╦╝█████╗░░██╔██╗██║╚█████╗░
██╔═══╝░██╔══██║██╔══██╗██╔══██║██╔══██╗██╔══╝░░██║╚████║░╚═══██╗
██║░░░░░██║░░██║██║░░██║██║░░██║██████╦╝███████╗██║░╚███║██████╔╝
╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░");
    }
    else if (numeroEscolhido > numeroSecreto)
    {
        Console.WriteLine(":( O número escolhido é maior que o número secreto");
    }
    else
    {
        Console.WriteLine(":( O número escolhido é menor que o número secreto");
    }

} while (!acertou);

