using animais.Model;
    class program
    {
        public static void Main()
        {
            var pantera1 = new Pantera();

            pantera1.especie = "Pantera Negra";
            pantera1.peso = 36;
            pantera1.cor = "preto";
            pantera1.tamanho = 80;
            pantera1.alimentacao = "Carnívoros";

            pantera1.Apresentar();
            pantera1.correr();
            pantera1.reproduzir();
        }
    }


