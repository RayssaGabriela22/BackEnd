using System.Collections.Generic;
using Sesi.models;
public class Program
{
    public static void Main()
    {
        //Criando uma lista de inteiros 
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos á lista
        listaNumeros.Add(10); //Posição [0]
        listaNumeros.Add(20); //Posição [1]
        listaNumeros.Add(45); //Posição [2]

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[0]);
        //Contagem de elementos
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55);
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");
        Console.WriteLine($"------------ // ------------");
        List<string> listaNome = new List<string>();

        //Adicionando elementos á lista
        listaNome.Add("Rayssa"); //Posição [0]
        listaNome.Add("Vinicius"); //Posição [1]
        listaNome.Add("Bianca"); //Posição [2]

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNome[2]);
        //Contagem de elementos
        Console.WriteLine($"Neste momento temos {listaNome.Count} elementos");

        //Criando uma lista de numeros já atribuindo valores
        List<int> numeros = new List<int> {1,2,5,6,8,9};
        Console.WriteLine($"Quantidade de elementos na lista numeros:{numeros.Count}");
        numeros.Remove(2);//ele vai remover o elemento 5
        numeros.RemoveAt(1); // Remover o elemento no indice 1
        numeros.RemoveRange(2,2);//Remover 2 elementos a partir do indice 2
        //Substituindo informações do item da lista
        numeros[0] = 100;
        //Iterando sobre todos os itens da lista
        foreach(int numero in numeros)
        {
            Console.WriteLine(numero);
        }

         foreach(string nome in listaNome)
        {
            Console.WriteLine(nome);
        }

        //Criando uma lista com objetos da Classe Aluno 
        List<Aluno> listaAlunos = new List<Aluno>();
        //Adcionando um novo aluno a miha lista
        Aluno novoAluno = new Aluno("Rayssa", 17);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));

        //Exibindo lista de Alunos
        Console.WriteLine("Lista Alunos:");
        foreach(Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos");
        }
        //Criando uma nova lista, ordenada por nome
        //LINQ utilizando Sintaxe de consolta
        var ordenacao = from aluno in listaAlunos
                    where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;
        foreach (var aluno in ordenacao)
            Console.WriteLine(aluno);
        //LINQ utilizando Sintaxe de método
        var consulta = listaAlunos
                        .Where(aluno => aluno.idade == 17)
                        .OrderBy(aluno => aluno.idade);
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }


    }
}


