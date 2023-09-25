class program
{
   public static string[] poltronas = new string[43];

    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao SesiBus");
        Console.WriteLine("-----------");
        Console.WriteLine("Contamos com 42 lugares disponiveis");

        Menu();
    }
    public static void Menu()
    {

        string opcao = "";
        //significa faça
        do
        {
            Console.WriteLine("#######  MENU  #########");
            Console.WriteLine("1- Para comprar passagem");
            Console.WriteLine("2- Para poltronas disponiveis");
            Console.WriteLine("0- Para fechar o sistema");
            opcao = Console.ReadLine();
            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado,volte sempre!!!");
                    System.Threading.Thread.Sleep(1000); //Espera 1s 
                    break;
                case "1":
                    comprarpassagem();
                    break;
                case "2":
                    poltronadisponiveis();

                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }

        } while (opcao != "0");
    }
    public static void comprarpassagem()
    {
        Console.WriteLine("Quantas passagem deseja comprar?");
        int nrpassagens = int.Parse(Console.ReadLine());

        for (int i = 0; i < nrpassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i}º passagem:");
            int nrpoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o nome do passageiro:");
            string nome = Console.ReadLine();
            marcapoltrona(nrpoltrona, nome);
        }
    }
    public static void marcapoltrona(int nrpoltrona, string nome)
    {
        poltronas[nrpoltrona] = nome;
    }
    public static void poltronadisponiveis()
    {
        Console.WriteLine("Lista de poltronas disponiveis");
        for (int i = 1; i <= 42; i++){
            if (poltronas[i] == null ){
                Console.WriteLine($"Nº {i}");
            }
        }
    }
}