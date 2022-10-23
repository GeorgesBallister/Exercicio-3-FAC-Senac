public class Arma : Artefato
{

    //Metodo Construtor: Arma
    /*
    Vincula os dados as respectivas variaveis
    e printa na tela
    */
    public Arma(string n, string d, int da)
    {
        Console.WriteLine("");
        this.nome = n;
        this.descricao = d;
        this.dano = da;

        Console.WriteLine($"Você possui uma: {n}\n{d}\nDano da arma: {da}\n");
    }
}