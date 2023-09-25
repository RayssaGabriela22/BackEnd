//Sempre que formos utilizar Bibliotecas ou classes ja criadas 
//importamos ela com o using
using Sesi.Model;


class program
{
    public static void Main()
    {
        //Criando um variavel aluno1 e instanciando da classe Aluno
        //ou seja estamos criando nosso objeto 
        var aluno1 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno-1
        aluno1.nome = "Rayssa";
        aluno1.idade = 17;
        aluno1.turma = "2ºEM";
        //Chamando o método da classe aluno
        aluno1.Apresentar();
        aluno1.AdcionandoFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdcionandoFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);

        var aluno2 = new Aluno();
        aluno2.nome = "Kaio";
        aluno2.idade = 16;
        aluno2.turma = "2ºEM";

        aluno2.Apresentar();
    }
}
