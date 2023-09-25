using Models;

public class program
{
    public static void Main()
    {
        //Criando um objeto da classe pessoa
        //instanciando sem um metodo estrutor 
       /* Pessoa pessoa1 = new Pessoa();
        pessoa1 .nome = "Rayssa";
        pessoa1.idade = 17;
        pessoa1.cantar();

        //alterando para criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
            nome = "ricardo",
            idade = 17
        };
        pessoa2.cantar();
        */

        Pessoa pessoa1 = new Pessoa("Rayssa", 17, "rayssa.mendes@portalsesisp.org.br");
        pessoa1.cantar();
        pessoa1.informacoes();

        Pessoa pessoa2 = new Pessoa("Bruna", 16, "bruna.dutra@portalsesisp.org.br");
        pessoa2.cantar();
        pessoa2.informacoes();

        Pessoa pessoa3 = new Pessoa("Kaio", 16, "adalberto.kaio@portalsesisp.org.br");
        pessoa3.cantar();
        pessoa3.informacoes();


    }
   

}