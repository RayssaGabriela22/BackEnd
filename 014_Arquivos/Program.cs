using System.IO;
public class Pogram
{
    public static void Main()
    {
        //Chamando o metodo Gravararquivo
        GravarArquivo();
        //Chamando o metodo LerArquivo
        LerArquivo();
    }

    public static void LerArquivo()
    {
        try
        {
             string CaminhoArquivo = "Arquivo/arquivo.txt";
            //Verificar se o arquivo existe
            if (File.Exists(CaminhoArquivo) == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando
                // a verificação no if é falsa ou seja o arquivo não existe
                File.Create(CaminhoArquivo);
            }
            //Instancionando um objeto da classe StreamReader para ler o arquivo
            using (StreamReader arquivo = new StreamReader(CaminhoArquivo))
            {
                string linha;
                //Fazendo o while para ler linha por linha que contém no arquivo
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo {erro.Message}");
        }
    }

    public static void GravarArquivo()
    {
        try
        {
            //Instanciando um objeto da classeStreamWriter para gravar em arquivo
            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            {
                Console.WriteLine("Digite uma informação para gravar no arquivo");
                arquivo.WriteLine(Console.ReadLine());

            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($" Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}




