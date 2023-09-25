public class program
{
    public static void Main()
    {
        //Criando claases anonimas (classe sem definição inicial)
        var pessoa1 = new {
            nome = "João",
            idade =17
        };
        var pessoa2 = new {
            nome = "Maria",
            email ="rayssa.mendes@portalsesisp.org.br"
        };
            Console.WriteLine(pessoa1.nome + " " + pessoa1.idade);
            Console.WriteLine(pessoa2.nome + " " + pessoa2.email);

        var carro = new {
            marca = "Toyota",
            modelo = "Caminhonete 4x4",
            ano = 2022
        };
         var carro2 = new {
            marca = "VW",
            modelo = "Gol",
            ano = 2020
        };
        Console.WriteLine(carro.marca + " " + carro.modelo + " " + carro.ano);
        Console.WriteLine(carro2.marca + " " + carro2.modelo + " " + carro2.ano);


    }

}
