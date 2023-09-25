public class program
{
    public static void Main()
    {
        //try significa tentar
        //O Try serve para tratar um erro e nao parar a execução do programa se ocorrer qualquer erro dentro do bloco try
        // o sistema interrompe 
        //a execução do bloco e vai para o catch
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digito o nº {numero}");
            int resultado = numero / 10;
            Console.WriteLine($"O resultado é: {resultado}");
        }
        //Tratando excesão de Overflow (Estouro de campo)
        catch(OverflowException)
        {
            Console.WriteLine("Este numero inteiro é maior que o suportado");
        }

        catch(FormatException)
        {
            Console.WriteLine($"Erro: Digite um numero inteiro");
        }
         // catch é o tratamento do erro, normalmente colocamos as mensagens de acordo
         //com o tipo de erro, para melhor compreensão do usuário
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro:{ex.Message}");
        }
        //No finally é um bloco executado independentemente se ocorrer erro ou não 
        finally
        {
            Console.WriteLine("Entrando no finally");
        }
    }
}
