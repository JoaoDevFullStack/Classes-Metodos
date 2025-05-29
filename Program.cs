Music musica= new Music();
musica.nome = "Bohemian Rhapsody";
musica.artista = "Queen";
musica.disponivel = false;
musica.duracao = 354; // duração em segundos

Music musica2 = new Music
{
    nome = "Imagine",
    artista = "John Lennon",
    disponivel = true,
    duracao = 183 // duração em segundos
};

musica.Play(); // Chama o método Play para tocar a música


Console.WriteLine($@"
Nome: {musica2.nome}
Artista: {musica2.artista}
Disponível: {musica2.disponivel}
Duração: {musica2.duracao} segundos");

musica2.Play(); // Chama o método Play para tocar a música

Animals animal = new Animals
{
    nome = "Rex",
    idade = 3,
    especie = "Cachorro",
    domestico = true
};

animal.MakeSound(); // Chama o método MakeSound para o animal

Console.WriteLine($"{animal.nome} é adulto? {animal.IsAdult()}"); // Verifica se o animal é adulto

RPG rpg = new RPG
{
    name = "Final Fantasy",
    gender = "Fantasia",
    nivel = 10,
    multiplayer = true
}; 

rpg.Play();


EscolaDoRock escolaDoRock = new EscolaDoRock
{
    titulo = "Escola do Rock",
    anoLancamento = 2003,
};

escolaDoRock.ExibirInformacoes();

BankAccount bankAccount = new BankAccount
{
    user = "João da Silva",
    balance = true,
    indicatorNumber = "123456789"
};

bankAccount.Account();

Musica musica1 = new Musica
{
    nome = "Stairway to Heaven",
    artista = "Led Zeppelin",
};

musica1.ExibirFichaTecnica();


