namespace Models
{
    public class Produto
    {
        private string nome { get; set; }
        private decimal preco { get; set; }

        private string imagem { get; set; }
        public int ID_categoria { get; set; }

        public Produto(string nomeProduto, decimal precoProduto, string imagemProduto)
        {
            this.nome = nomeProduto;
            this.preco = precoProduto;
            this.imagem =imagemProduto;

        }

    }
}