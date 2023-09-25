using Models;

public class program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("$$$$$$$$$$$$$$$");
        Console.WriteLine("Bem vindo ao Banco Santander");
        Console.WriteLine("$$$$$$$$$$$$$$$$");

        Menu();
    }
    public static void Menu()
    {
        var conta = new ContaCorrente("");

        string opcao = "";

        Console.WriteLine($"Digite o nome do Titular");
        string nome = Console.ReadLine();

        var Conta = new ContaCorrente(nome);
        //significa faça
        do
        {

            //Console.Clear();
            Console.WriteLine("    Opcões:  ");
            Console.WriteLine("1- Consultar Saldo.");
            Console.WriteLine("2- Depositar.");
            Console.WriteLine("3- Sacar.");
            Console.WriteLine("0- Sair.");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, espero ter ajudado");
                    System.Threading.Thread.Sleep(1000); //Espera 1s 
                    break;
                case "1":
                   Console.WriteLine($"Consulte seu saldo:");
                    conta.ConsultarSaldo();
                    System.Threading.Thread.Sleep(1000); //Espera 1s 
                    break;
                case "2":
                    Console.WriteLine($"Deposite o valo:");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                    System.Threading.Thread.Sleep(1000); //Espera 1s 
                    break;
                case "3":
                Console.WriteLine($"Valor do saque:");
                    decimal valorSacar = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSacar);
                    System.Threading.Thread.Sleep(1000); //Espera 1s 
                    break;
                default:
                    Console.WriteLine($"Opção invalida");
                    break;
            }

        } while (opcao != "0");
    }
}





