//Função em Javascript
//function nomeFunção (nome){
//}

//Função / Método em c#
//publico static string NomeFuncao(string nome){
//}
class sesi
{
    public static void Main()
    {
        //Chamando métodos sem retorno
        MostrarMensagem("Seja bem vindo");
        MostrarMensagem("SESI/ SENAI");
        ImprimeDataHora();
        double potencia = Potenciacao(4);
        Console.WriteLine($"potenciação {potencia}");
        Console.WriteLine($"potenciação {potencia}");

        contagemregressiva(10);

        jogoquenrsoueu();
    }

    public static double Potenciacao(int num)
    {
        double resultado = Math.Pow(num, 2);
        return resultado;
    }
    //metodo sem retorno e sem parametro
    public static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }
    //metodo com parametros e sem retorno 
    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void contagemregressiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine("BOOOOOOM");
    }

    public static void jogoquenrsoueu()
    {
        Console.WriteLine("* * * * * * * * * * * * *");
        Console.WriteLine("        Bem Vindo ao Jogo      ");
        Console.WriteLine("Sorteei um n° de 1 a 20, tente adivinha-lo");
        Console.WriteLine("* * * * * * * * * * * * *");
        Console.WriteLine("");//Linha em branco 

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = -1;

        do
        {
            Console.WriteLine("Digitei um n°");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
                Console.WriteLine("O numero digitado é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
                Console.WriteLine("O numero digitado é MENOR que o numero sorteado");
        } while (nrDigitado != nrSorteado);
        Console.WriteLine("Parabens você acertou");
        
}
}
