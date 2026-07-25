using System;

namespace teste_3
{
    public class Teste3
    {
        public void ListarProdutos()
        {
            Dictionary<string, List<int>> produtos = new Dictionary<string, List<int>>();

            produtos.Add("Arroz", [10]);
            produtos.Add("Feijão", [12]);
            produtos.Add("Macarrão", [5]);
            produtos.Add("Leite", [7]);
            produtos.Add("Pão", [3]);

            Console.WriteLine("Bem vindo");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Listar produtos");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção: ");
            string? opcaoEscolhida = Console.ReadLine();
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    foreach (KeyValuePair<string, List<int>> produto in produtos)
                    {
                        Console.WriteLine($"{produto.Key}: R$ {produto.Value}");
                    }
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                    ListarProdutos();
                    break;
                case 2:
                    Console.WriteLine("Digite o nome do produto: ");
                    string? nomeProduto = Console.ReadLine();
                    Console.WriteLine("Digite a quantidade do produto: ");
                    string? quantidadeProduto = Console.ReadLine();
                    int quantidadeConvertida = int.Parse(quantidadeProduto);
                    produtos.Add(nomeProduto, [quantidadeConvertida]);
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                    ListarProdutos();
                    break;
                case 3:
                    Console.WriteLine("Até mais!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}


