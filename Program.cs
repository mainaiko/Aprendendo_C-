// srenn sound
string mensagem = "🅂 🄲 🅁 🄴 🄴 🄽  🅂 🄾 🅄 🄽🄳";

// void indica que nao espero retorno da função
// @ no inicio de um texto é chamado de verbatim literal
void ExibirBoasVindas()
{
    Console.WriteLine(mensagem);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite 5 para sair");
}

ExibirBoasVindas();
ExibirOpcoesMenu();
