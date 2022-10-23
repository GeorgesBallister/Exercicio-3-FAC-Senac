// Exercicio: RPG
// Write by Georges Ballister
/*
            -----Objetivos do Programa-----

1 - Criar classe: Personagem
    Atributos: força, raça, vida, nome
    Objetivo da Classe: 
    -A Classe personagem, possuira atributos das classes: "Magia" e "Arma"  
    -Criar 4 tipos de Personagens

2 - Criar classe: Artefato
    Objetivo da Classe: Encapsular as classes "Magia", "Arma"

    2.1 - Criar classe: Magia
          Atributos: Nome, Dano, descricao
          Objetivo da Classe: Sera uma classe que sera integrada ao objeto "Personagem" 

    2.2 - Criar classe: Arma
          Atributos: Nome, Dano, 
          Objetivo da Classe: Sera uma classe que sera integrada ao objeto "Personagem" 
*/

//Assim que o Objeto Personagem for Criado Pedira para colocar o nome e selecionar a classe

//Criar Personagem 1
Console.WriteLine("-------------------------");
Personagem p1 = new Personagem("Harry Porter","Humano",15, 20);
p1.arma = new Arma("Varinha","Use a varinha Harry", 15);
p1.magia = new Magia("Bola de Fogo","Pega fogo AHHHHHH", 40);
Console.WriteLine("-------------------------");

//Criar Personagem 2
Console.WriteLine("-------------------------");
Personagem p2 = new Personagem("Dio Brando","Vampiro",40, 50);
p2.arma = new Arma("The World","Um Stand que para o tempo", 20);
p2.magia = new Magia("ZA WARUUUUDOOOOOO","Você paraliza o tempo por 6 segundos e MUDA MUDA MUDA MUDA MUDA MUDA MUDA MUDA WRYYYYYYYYYYYYY!!!!!!", 60);
Console.WriteLine("-------------------------");

//Criar Personagem 3
Console.WriteLine("-------------------------");
Personagem p3 = new Personagem("Dudu Du Gera","Bacteria",15, 20);
p3.arma = new Arma("Passinho","Remexa sem parar ate o seu inimigo ficar perplexo com seus movimentos", 25);
p3.magia = new Magia("A Lendaria Sarrada no Ar","Você já ouviu falar, da lendária sarrada? (yaah)\n Se não ouviu não diz nada que eu vou te contar (aaah)\n O movimento é fútil, usa o músculo do glúteo\n Para propulsionar o seu bilau\n Só isso combinado, com um poderoso salto\n Num movimento suculento, ao vento que todos vão pirar!", 40);
Console.WriteLine("-------------------------");

//Criar Personagem 4
Console.WriteLine("-------------------------");
Personagem p4 = new Personagem("Georges","Estudante",0, 15);
p4.arma = new Arma("Nenhuma","", 0);
p4.magia = new Magia("Disposição Forçada","Você consegue tirar disposição de onde não existe", 100);
Console.WriteLine("-------------------------");
