// variaveis
string mensagem = "🅂 🄲 🅁 🄴 🄴 🄽  🅂 🄾 🅄 🄽🄳";
List<string> bandas = new List<string>();

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
            Console.WriteLine("avaliar uma banda");
            break;
        case 4:
            Console.WriteLine("exibir a media de uma banda");
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
    Console.WriteLine("Registro de banda");
    Console.Write("Digite o nome da banda: ");
    string? nomeBanda = Console.ReadLine();
    bandas.Add(nomeBanda);
    Console.WriteLine($"Banda {nomeBanda} registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("Exibindo bandas registradas");
    // foreach - forma mais simples de percorrer uma coleção
    foreach (string banda in bandas)
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

// teste de raciocinio
//void JogoDeAdivinha()
//{
//    Random aleatorio = new Random();
//    int numeroSecreto = aleatorio.Next(1, 101);
//
//    do
//    {
//        Console.Write("Digite um número entre 1 e 100: ");
//        int chute = int.Parse(Console.ReadLine());
//
//        if (chute == numeroSecreto)
//        {
//            Console.WriteLine("Parabéns! Você acertou o número.");
//            break;
//        }
//        else if (chute < numeroSecreto)
//        {
//            Console.WriteLine("O número é maior.");
//        }
//        else
//        {
//            Console.WriteLine("O número é menor.");
//        }
//
//    } while (true);
//
//    Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
//}

void Teste()
{

    do
    {
        Console.Clear();
        Console.WriteLine("Bem vindo a calculadora");
        Console.WriteLine("Qual operação deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
        Console.Write("Opção: ");
        string? operacao = Console.ReadLine();

        if (operacao == "5")
        {
            break;
        }

        if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
        {
            Console.WriteLine("Opção inválida!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            continue;
        }

        Console.Write("Digite o primeiro numero da operação: ");
        string? numero1 = Console.ReadLine();
        int numeroConvertido1 = int.Parse(numero1 ?? "0");
        
        Console.Write("Digite o segundo numero da operação: ");
        string? numero2 = Console.ReadLine();
        int numeroConvertido2 = int.Parse(numero2 ?? "0");

        if (operacao == "1")
        {
            Console.WriteLine($"O resultado da soma é: {numeroConvertido1 + numeroConvertido2}");
        }
        else if (operacao == "2")
        {
            Console.WriteLine($"O resultado da subtração é: {numeroConvertido1 - numeroConvertido2}");
        }
        else if (operacao == "3")
        {
            Console.WriteLine($"O resultado da multiplicação é: {numeroConvertido1 * numeroConvertido2}");
        }
        else if (operacao == "4")
        {
            Console.WriteLine($"O resultado da divisão é: {numeroConvertido1 / numeroConvertido2}");
        }

        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    } while (true);
}

Teste();
//JogoDeAdivinha();

ExibirOpcoesMenu();
