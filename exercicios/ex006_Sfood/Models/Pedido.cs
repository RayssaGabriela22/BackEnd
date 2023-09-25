namespace Models
{
    public class Pedido
    {
        private int data { get; set; }
        private decimal preco { get; set; }
        private string quantidade { get; set; }
        private string Descricao { get; set; }
        public int ID_categoria { get; set; }

        public Pedido(int dataPedido, decimal precoPedido, string quantidadePedido, string descricaoPedido)
        {
            this.data = dataPedido;
            this.preco = precoPedido;
            this.quantidade =quantidadePedido;
            this.descricao =quantidadePedido;

        }

    }
}