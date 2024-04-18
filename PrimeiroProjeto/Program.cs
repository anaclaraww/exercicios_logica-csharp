//Screnn Sound
using System;

string mensagem = "\nBoas vindas ao Screen Sound!";
//List<string> bandas = new List<string> { "marron5","ColdPlay", "Melim"};
Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string, List<int>>() ;
bandasRegistradas.Add("ColdPlay", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The beatles", new List<int>());

ExibirOpcoes();

void ExibirMensagem()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagem);

}


void ExibirOpcoes()
{   
    ExibirMensagem();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\n Digite a sua opção...");
    int opcao =int.Parse(Console.ReadLine()!);
    switch (opcao)
    {
        case 1: 
            Console.WriteLine("Você digitou: " + opcao);
            RegistrarBanda();
            break;
        case 2:
            Console.WriteLine("Você digitou: " + opcao);
            ListarBandas();
            break;
        case 3:
            Console.WriteLine("Você digitou: " + opcao);
            AvaliarBanda();
            break;
        case 4:
            Console.WriteLine($"Você digitou:{opcao} " + opcao);
            break;
        case 0: Console.WriteLine("Bye bye :)");
            break;
        default: Console.WriteLine("Você não escolheu uma opção valida");
            break;

    }
}

void TituloPadrao(string titulo)
{
    int quantdadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantdadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void RegistrarBanda()
{
    Console.Clear();
    TituloPadrao("Registrar Banda");
    Console.WriteLine("Digite o nome da banda que deseja criar\n");
    string banda = Console.ReadLine()!;
    bandasRegistradas.Add(banda, new List<int>()); //criando uma chave e valor
    Console.WriteLine($"A banda {banda} foi cadastrada!");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoes();
}

void ListarBandas()
{
    Console.Clear();
    TituloPadrao("Listando bandas");
    // for por extenso
    //for(int i = 0; i < bandas.Count; i++)
    //{

    //    Console.WriteLine($"Banda {i + 1}: {bandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoes();

}

void AvaliarBanda()
{
    Console.Clear();
    TituloPadrao("Avalie uma banda: ");
    //Selecionar a banca;
    Console.Write("Digite qual bando você quer avaliar: ");
    string bandaSelecionada = Console.ReadLine();
    //verificar se ela existe no dicionário
    if(bandasRegistradas.ContainsKey(bandaSelecionada))
    {
        Console.Write("Qual a nota que deseja atribuir? ");
        int nota = int.Parse(Console.ReadLine()!);
        //selecionando pela chave e adicionando
        bandasRegistradas[bandaSelecionada].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {bandaSelecionada}");
        Thread.Sleep(2000); // em milisegundos
        Console.Clear();
        ExibirOpcoes();

    }
    else
    {
        Console.WriteLine($"A banda que você selecionou não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoes();

    }

    //atribuir a nota, caso exista
}





//VÁRIOS TESTES:

void LoginDictionary()
{
    bool login = false;
    while (!login)
    {
        Dictionary<string, string> user = new Dictionary<string, string>();
        user.Add("anaclaraw", "ana123");

        Console.WriteLine("Digite seu nome de usuario");
        string userName = Console.ReadLine();
        Console.WriteLine("Digite sua senha:");
        string password = Console.ReadLine();

        if (user.ContainsKey(userName) && user[userName] == password)
        {
            Console.WriteLine("Logado com sucesso!");
            login = true;
        }
        else
        {
            Console.WriteLine("Usuário ou senha incorretos.");
        }
    }
}



void Quiz()
{

    Dictionary<string, string> quiz = new Dictionary<string, string>();
    int pontuacao = 0;
    int qtd = 0;
    quiz.Add("Quantos países tem no mundo?", "193");
    quiz.Add("Quantos países tem no munxxdo?", "193");
    quiz.Add("Quantos países tem no muxxxndo?", "193");

    foreach (var key in quiz)
    {
        Console.WriteLine(key.Key);
        string respostaUsuario = Console.ReadLine();
        if (respostaUsuario == key.Value)
        {
            qtd++;
            pontuacao++;
        }
        else
        {
            qtd++;
        }
    }


    Console.WriteLine($"Você acertou {pontuacao}/{qtd}.");
}


Dictionary<string, List<float>> aluno = new Dictionary<string, List<float>>();
void AlunoDictionary()
{
    aluno.Add("Pedro", new List<float>());
}

void AdicionandoNotas()
{
    float n1 = 10;
    float n2 = 8;
    float n3 = 6;
    float n4 = 9;
    aluno["Pedro"].Add(n1);
    aluno["Pedro"].Add(n2);
    aluno["Pedro"].Add(n3);
    aluno["Pedro"].Add(n4);
}

void CalculandoMediaAluno()
{
    List<float> notas = aluno["Pedro"];
    float media = notas.Average();
    Console.WriteLine(media);
}

//AlunoDictionary();
//AdicionandoNotas();
//CalculandoMediaAluno();

void CalcularMedia()
{
    Console.Write("\n Digite o primeiro valor...");
    int valor1 = int.Parse(Console.ReadLine()!);
    Console.Write("\n Digite o segundo valor...");
    int valor2 = int.Parse(Console.ReadLine()!);
    Console.Write("\n Digite o terceito valor...");
    int valor3 = int.Parse(Console.ReadLine()!);
    Console.Write("\n Digite o quarto valor...");
    int valor4 = int.Parse(Console.ReadLine()!);

    float media = (valor1 + valor2 + valor3 + valor4) / 4;

    Console.WriteLine(media);
}

void ListaEstatica()
{
    string[] Lista = new string [3] {"C#", "Java", "JavaScript"};
    Console.WriteLine(Lista[0]);

}

void AdivinhaNumero()
{
    Random random = new Random();
    int numero = random.Next(1, 101);
    Console.WriteLine("Digite um número entre 1 e 100:");
    int num_tentativa = int.Parse(Console.ReadLine()!);

    while(num_tentativa != numero)
        {
        if(numero > num_tentativa)
        {
            Console.WriteLine($"É Maior que {num_tentativa}");
        }
        else
        {
            Console.WriteLine($"É Menor que {num_tentativa}");
        }
        Console.WriteLine("Digite um número:");
        num_tentativa = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine($"Você acertou o número era {numero}");
}

void SomarLista()
{
    List<int> lista = new List<int>() { 10,10,10,10,10,100};
    int SomarLista = 0;

    foreach (int numero in lista)
    {
        SomarLista =  SomarLista + numero;
    }
    Console.WriteLine(SomarLista);

}

void ExibirNumPares()
{
    List<int> lista = new List<int>() { 104, 102, 106, 103, 107, 108 };

    for (int i = 0; i < lista.Count; i++)
    {
        if (lista[i] %2 == 0)
        {
            Console.WriteLine(lista[i]);
        }
    }
}
