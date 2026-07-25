// variaveis
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

string mensagem = "🅂 🄲 🅁 🄴 🄴 🄽  🅂 🄾 🅄 🄽🄳";
//List<string> bandas = new List<string>();

// dictionary guarda um valor, associado a uma chave. Ex: chave: "Queen", valor: [10, 9, 8]
Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
bandas.Add("Queen", [10, 9, 8]);

// void indica que nao espero retorno da função
// @ no inicio de um texto é chamado de verbatim literal

void ExibirBoasVindas()
{
    Console.WriteLine(mensagem);
}

void ExibirOpcoesMenu()
{
    ExibirBoasVindas();

    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("Qual sua opção? ");
    string? opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            MediaDaBanda();
            break;
        case 5:
            Console.WriteLine("Volte quando quiser :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda: ");
    string? nomeBanda = Console.ReadLine();
    bandas.Add(nomeBanda, []);
    Console.WriteLine($"Banda {nomeBanda} registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo bandas registradas");
    // foreach - forma mais simples de percorrer uma coleção
    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    // for tradicional
    //    for (int i = 0; i < bandas.Count; i++)
    //    {
    //        Console.WriteLine($"{i + 1} - {bandas[i]}");
    //    }
    Console.WriteLine("Digite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

// função que recebe o titulo e o melhora para seguir um padrão visual do app
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string tracejado = string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(tracejado);
    Console.WriteLine(titulo);
    Console.WriteLine(tracejado + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma banda");
    Console.Write("Digite o nome da banda: ");
    string? nomeBanda = Console.ReadLine();

    if (bandas.ContainsKey(nomeBanda))
    {
        Console.Write("Digite a nota que deseja dar para a banda (0 a 10): ");
        string? notaString = Console.ReadLine();
        int notaConvertida = int.Parse(notaString);
        bandas[nomeBanda].Add(notaConvertida);
        Console.WriteLine($"Banda {nomeBanda} avaliada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"Banda {nomeBanda} não encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }

}

void MediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média da banda");
    Console.Write("Digite o nome da banda: ");
    string? nomeBanda = Console.ReadLine();

    if (bandas.ContainsKey(nomeBanda))
    {
        Console.WriteLine($"Média da banda {nomeBanda}: {bandas[nomeBanda].Average()}");
    }
    else
    {
        Console.WriteLine("Banda não encontrada");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();
