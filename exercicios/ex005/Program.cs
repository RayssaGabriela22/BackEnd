class program
{
    public static void Main()
    {
        listadechurrasco();
    }
    public static void listadechurrasco()
    {
        string[] lista = new string[6];
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("digite o produto que vamos comprar");
            string produto = Console.ReadLine();
            lista[i] = produto;
        }

        Array.Sort(lista);
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }
    }
    public static void Listadesonhos()
    {
        string[] sonhos = new string[3];
        decimal[] valores = new decimal[3];
        decimal total = 0;

        for(int i = 0; i < 3;i++){
            Console.WriteLine($"Informe o seu {i}º sonho");
            string sonho = Console.ReadLine();
            Console.WriteLine($"Informe o valor do {i}º sonho");
            decimal valor = decimal.Parse(Console.ReadLine());
            sonhos [i] = sonho;
            valores[i] = valor;
        }

        foreach (decimal val in valores)
        {
            total = total + val;
        }
        Console.WriteLine($"Seus sonhos custaram aprox. R${total}");
    }

}





