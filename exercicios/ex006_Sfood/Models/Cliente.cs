namespace Models
{
    public class Cliente
    {
        private string nome { get; set; }
        private string email { get; set; }
        private int senha { get; set; }
        private string endereco { get; set; }
        public int ID_categoria { get; set; }

        public Cliente(string nomeCliente, string emailCliente, int senhaCliente, string enderecoCliente)
        {
            this.nome = nomeCliente;
            this.email = emailCliente;
            this.senha = senhaCliente;
             this.endereco =enderecoCliente;
        }

    }
}