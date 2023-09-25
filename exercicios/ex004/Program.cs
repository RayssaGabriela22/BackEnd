class senai
{
    public static void Main()
    {
        int divisoes = Divisao(int.Parse(Console.ReadLine()));
        Console.WriteLine($"divisão {divisoes}");

        int multiplicacao = int.Parse(Console.ReadLine());
        double valor = Multiplicacao(multiplicacao);
        Console.WriteLine($"O dobro do {valor}");
        tabuada(int.Parse(Console.ReadLine()));
        ResumoSalarios();
    }

    public static int Divisao(int num)
    {
        int resultado = num / 2;
        return resultado;
    }

    public static double Multiplicacao(int num)
    {
        double resultado = num * 2;
        return resultado;
    }

    public static void tabuada(int numero)
    {
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine($"{contador} x {numero} = {contador * numero}");
            contador++;
        }

    }
    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;
        do
        {
            Console.WriteLine("Digite o saario do empregado:");
            salarioEmpregado = int.Parse(Console.ReadLine());
          
            if (salarioEmpregado > 0)
                somaSalarios = somaSalarios + salarioEmpregado;
            {
                maiorSalario = salarioEmpregado;
            }
            if (salarioEmpregado < menorSalario && salarioEmpregado > 0)
            {
                menorSalario = salarioEmpregado;
            }

        }
        while (salarioEmpregado > 0);
        Console.WriteLine($"A soma dos salarios é {somaSalarios} o maior salario é {maiorSalario} e o menor salario é {menorSalario}");
     }

}
