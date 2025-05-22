// Screen Sound
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("linkin park", new List<int> { 10,6,8,7});
bandas.Add("Stratovarios",new List<int>());
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
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a media de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.WriteLine("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch(opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2:ExibirBandas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirNotaDeBanda();
            break;
        case 0: Console.WriteLine("Voce escolheu a opcao: " + opcaoEscolhidaNumerica + " Fechando o programa");
            break;
        default: Console.WriteLine("Opcao invalida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2500);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir bandas");
    
    foreach(string banda in bandas.Keys)
    {  
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
        ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear() ;
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Qual banda deseja avaliar: ");
    string bandaEscolhida = Console.ReadLine()!;
    if (bandas.ContainsKey(bandaEscolhida))
    {
        Console.Write($"Qual a note que {bandaEscolhida} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[bandaEscolhida].Add(nota);
        Console.WriteLine($"A nota {nota} foi registada com sucesso");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else 
    {
        Console.WriteLine($"\nA banda {bandaEscolhida} nao foi encontrada. ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal. ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void ExibirNotaDeBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir nota da banda");
    Console.Write("Qual banda deseja verificar: ");
    string bandaEscolhida = Console.ReadLine()!;
    
    if (bandas.ContainsKey(bandaEscolhida))
    {
        if (bandas[bandaEscolhida].Count > 0)
        {

            Console.WriteLine($"\nA media da banda {bandaEscolhida} é: {bandas[bandaEscolhida].Average()}");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal. ");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();

            Thread.Sleep(3000);
            Console.Clear();
            ExibirOpcoesDoMenu();

        }
        else
        {
            Console.WriteLine($"\nA banda {bandaEscolhida} nao possui nenhuma avaliacao. ");
            Thread.Sleep(3000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }   

    else
    {
        Console.WriteLine($"\nA banda {bandaEscolhida} nao foi encontrada. ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal. ");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirTituloDaOpcao(string titulo)
    { 
    int quantidadeDeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(astericos );
    Console.WriteLine(titulo);
    Console.WriteLine(astericos + "\n");
    }



ExibirOpcoesDoMenu();