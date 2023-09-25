namespace animais.Model
{

    public class Pantera
    {
        public string especie { get; set; }
        public decimal peso { get; set; }
        public string cor { get; set; }
        public decimal tamanho { get; set; }
        public string alimentacao { get; set; }
        public decimal velocidade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"a pantera {especie}, tem o {peso}, contendo a cor {cor} e o tmanho {tamanho} cm. Se alimentando de {alimentacao}");
        }
         public void correr()
        {
            Console.WriteLine($"a pantera esta correndo");
        }
          public void reproduzir()
        {
            Console.WriteLine($"a pantera esta reproduzindo");
        }

}
}