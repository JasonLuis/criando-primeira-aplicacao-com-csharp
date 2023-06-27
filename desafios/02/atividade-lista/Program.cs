List<int> numeros = new List<int>();

void IncrementarLista()
{
    Random random = new Random();
    int numero = random.Next(1, 101);
    numeros.Add(numero);
}

void ExibirNumerosParesForEach() {
    Console.Write("Números pares: ");
    foreach (int num in numeros)
    {   
        if(num % 2 == 0) {
            Console.Write($"{num} ");
        }
    }
}

void ExibirNumerosParesForSimples() {
    Console.Write("Números pares: ");
    for (int i = 0; i < numeros.Count; i++)
    {
        if(numeros[i] % 2 == 0) {
            Console.Write($"{numeros[i]} ");
        } 
    }
}

void gerarListaExibir() {

    for (int i = 0; i < 15; i++)
    {   
        IncrementarLista();
    }

    Console.WriteLine("\n**************************");
    Console.WriteLine("Exibir lista com ForEach");
    ExibirNumerosParesForEach();
    Console.WriteLine("\n**************************\n");

    Console.WriteLine("\n**************************");
    Console.WriteLine("Exibir lista com For Simples");
    ExibirNumerosParesForSimples();
    Console.WriteLine("\n**************************");
}

gerarListaExibir();