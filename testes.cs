// teste de raciocinio 1
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
////        }
////
////    } while (true);
////
////    Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
////}

// teste de raciocionio 2
//void Teste()
//{
//
//    do
//    {
//        Console.Clear();
//        Console.WriteLine("Bem vindo a calculadora");
//        Console.WriteLine("Qual operação deseja fazer?");
//        Console.WriteLine("1 - Soma");
//        Console.WriteLine("2 - Subtração");
//        Console.WriteLine("3 - Multiplicação");
//        Console.WriteLine("4 - Divisão");
//        Console.WriteLine("5 - Sair");
//        Console.Write("Opção: ");
//        string? operacao = Console.ReadLine();
//
//        if (operacao == "5")
//        {
//            break;
//        }
//
//        if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
//        {
//            Console.WriteLine("Opção inválida!");
//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//            continue;
//        }
//
//        Console.Write("Digite o primeiro numero da operação: ");
//        string? numero1 = Console.ReadLine();
//        int numeroConvertido1 = int.Parse(numero1 ?? "0");
//        
//        Console.Write("Digite o segundo numero da operação: ");
//        string? numero2 = Console.ReadLine();
//        int numeroConvertido2 = int.Parse(numero2 ?? "0");
//
//        if (operacao == "1")
//        {
//            Console.WriteLine($"O resultado da soma é: {numeroConvertido1 + numeroConvertido2}");
//        }
//        else if (operacao == "2")
//        {
//            Console.WriteLine($"O resultado da subtração é: {numeroConvertido1 - numeroConvertido2}");
//        }
//        else if (operacao == "3")
//        {
//            Console.WriteLine($"O resultado da multiplicação é: {numeroConvertido1 * numeroConvertido2}");
//        }
//        else if (operacao == "4")
//        {
//            Console.WriteLine($"O resultado da divisão é: {numeroConvertido1 / numeroConvertido2}");
//        }
//
//        Console.WriteLine("Pressione qualquer tecla para continuar...");
//        Console.ReadKey();
//    } while (true);
//}
//
//Teste();
//JogoDeAdivinha();