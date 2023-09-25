//O namepasce é um nome em que usaremos para fazer referencia quando usarmos 
// em outras classes
namespace Sesi.Model
{
    //Declarando nossa classe aluno
    public class Aluno
    {
        //Declarando nossos atributos (propriedades) da classe;
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        private int nrFaltas { get; set; }

        //Criando um método 
        public void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma}");
        }

        public void AdcionandoFaltas(int nr)
        {
            nrFaltas = nrFaltas + nr;
        }
        public void ResumirFaltas()
        {
            Console.WriteLine($"{nome} você tem {nrFaltas} faltas");
        }
         public void JustificarFaltas(int nr)
        {
            nrFaltas = nrFaltas - nr;
            Console.WriteLine($"{nome} você tem {nrFaltas} faltas");
        }
    }

}