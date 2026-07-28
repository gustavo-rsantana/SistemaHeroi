using SistemaHeroi.Models;

Console.WriteLine("Sistema do Heroi");
Console.WriteLine("Digite o nome do herói:");
string nome = Console.ReadLine();
Console.WriteLine("Qual Classe do herói? (Guerreiro, Mago, Arqueiro)");
string classe = Console.ReadLine();

Heroi heroi = new(nome, classe);

bool sair = false;

while (!sair)
{
    Console.WriteLine("=============");
    Console.WriteLine("Escolha uma ação:");
    Console.WriteLine("1 - Atacar");
    Console.WriteLine("2 - Receber Dano");
    Console.WriteLine("3 - Curar");
    Console.WriteLine("4 - Subir de Nível");
    Console.WriteLine("5 - Exibir Status");
    Console.WriteLine("6 - Sair");
    Console.WriteLine("=============");

    string escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1":
            heroi.Atacar();
            break;
        case "2":
            heroi.ReceberDano();
            break;
        case "3":
            heroi.Curar();
            break;
        case "4":
            heroi.SubirNivel();
            break;
        case "5":
            heroi.ExibirStatus();
            break;
        case "6":
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}