public class Music
{
    public string nome;
    public string artista;
    public bool disponivel;
    public int duracao;

    public void Play()
    {
        Console.WriteLine($"Tocando a música: {nome} do artista {artista} com duração de {duracao}");
        if (disponivel)
        {
            Console.WriteLine("A música está disponível para reprodução.");
        }
        else
        {
            Console.WriteLine("A música não está disponível para reprodução.");
        }
    }
}


    class Animals
    {
        public string nome;
        public int idade;
        public string especie;
        public bool domestico;
        public bool IsAdult()
        {
            return idade >= 1; // Considera adulto se a idade for 1 ano ou mais
        }

        public void MakeSound()
        {
            Console.WriteLine($@"
{nome} faz um som.");
        if (domestico)
            {
                Console.WriteLine($@"
{nome} é um animal doméstico.");
            }
            else
            {
                Console.WriteLine($@"
{nome} é um animal selvagem.");
        }
    }
}

    class RPG
    {
        public string name;
        public string gender;
        public int nivel;
        public bool multiplayer; // Método que retorna se o jogo é multiplayer, sempre retorna true para simplificação

    public void Play()
    {
        Console.WriteLine($"\nJogando RPG: {name}, Gênero: {gender}");
        if (multiplayer)
        {
            Console.WriteLine("Este jogo é multiplayer.");
        }
        else
        {
            Console.WriteLine("Este jogo é single player.");
        }
    }


    }

class EscolaDoRock
{
    public string titulo;
    public int anoLancamento;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"\nTítulo: {titulo}");
        Console.WriteLine($"Ano de Lançamento: {anoLancamento}");
    }
}

class BankAccount
{
    public string indicatorNumber;
    public string user;
    public bool balance;
    public string password;

    public void Account()
    {
        Console.WriteLine($"\nTitular da conta: {user}");
        Console.WriteLine($"Saldo da conta: {balance}");
        if (balance)
        {
            Console.WriteLine("A conta está ativa.");
        }
        else
        {
            Console.WriteLine("A conta está inativa.");
        }
    }
}


class Musica
{
    public string nome;
    public string artista;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome da música: {nome}");
        Console.WriteLine($"Artista: {artista}");
    }
}
