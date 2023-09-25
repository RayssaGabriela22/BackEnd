namespace Models
{
    public class Pessoa
    {
        //atributos da nossa classe pessoa
        private string nome { get; set; }
        private int idade { get; set; }
        private string email { get; set; }
        private int anonascimento { get; set; }

        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anonascimento = DateTime.Now.Year - idadePessoa;


            ;
        }

        //metodo de classe passoas 
        public void cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }
        public void informacoes()
        {
            Console.WriteLine($"{nome} está cantando, tem {idade} e seu email é {email}. Nasceu no ano de {anonascimento}");
        }
    }
}
