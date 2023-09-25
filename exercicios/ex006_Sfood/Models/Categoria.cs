namespace Models
{
    public class Categoria
    {
        public int ID_categoria { get; set; }
        private string nome { get; set; }

        public Categoria(string nomeCategoria)
        {
            this.nome = nomeCategoria;
        }

    }
}