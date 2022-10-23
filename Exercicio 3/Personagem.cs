public class Personagem
{
    private string nomePersonagem = "";
    private string racaPersonagem = "";
    private int forcaPersonagem;
    private int vidaPersonagem;

    //Get & Set: vidaPersonagem
    public int VidaPersonagem{
        get => vidaPersonagem;
        set
        {
            vidaPersonagem = value;
        }
    }

//Adcionar classe Arma
public Arma arma;
//Adcionar classe Magia
public Magia magia;

//Metodo Construtor: Personagem
/*
Vincula os dados as respectivas variaveis
e printa na tela
*/
public Personagem(string n, string r, int f, int v)
{
    Console.WriteLine("");
    this.nomePersonagem = n;
    this.racaPersonagem = r;
    this.forcaPersonagem = f;
    this.vidaPersonagem = v;

    Console.WriteLine($"Seu nome é: {n}\nSua raça é: {r}\nSua força é: {f}\nSua Vida é: {v}");
}
}