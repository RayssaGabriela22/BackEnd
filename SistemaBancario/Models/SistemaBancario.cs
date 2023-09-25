namespace Models
{
    public class ContaCorrente
    {
        //atributos da nossa classe pessoa
        public string nome { get; set; }

        public decimal saldo { get; set; } = 0;

        public ContaCorrente (string nome)
        {
            this.nome = nome;
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu Saldo é de {saldo}");
        }
        
        public void Depositar(decimal valordoDeposito)
        {
            
            saldo += valordoDeposito;
        }
        public void Sacar(decimal valorSaque)
        {
            if (valorSaque > saldo)
            {
                Console.WriteLine ($"Infelizmente você não pode sacar");
            }
            else{
                Console.WriteLine ($"Você retirou {valorSaque} da sua conta");
                saldo -= valorSaque;
            }

        }

    }


}