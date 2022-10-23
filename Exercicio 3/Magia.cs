public class Magia : Artefato{
    
    
    //Metodo Construtor: Magia
    /*
    Vincula os dados as respectivas variaveis
    e printa na tela
    */
     public Magia(string n, string d, int da){
        Console.WriteLine("");
        this.nome = n;
        this.descricao = d;
        this.dano = da;

         Console.WriteLine($"Você sabe: {n}\n{d}\nDano da Magia: {da}\n");
    }
}
