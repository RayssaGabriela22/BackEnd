//somente declaranado uma variavel do tipo inteira e sem valor 
//int num1;
//declarando uma variavel do tipo inteira e atribuindo o numero 5
//int num2 =5;
//declarando uma variavel String (texto/dado)
//string nomeAluno = "Paulo";
//variavel do tipo logica 
//bool resultado = true;
//variavel do tipo double valor com varias casas decimais 
//double coordenada = 1.089;
//variavel do tipo decimal - utilizando para valores 
//decimal valor = 1.80M;
int idade = 17;
string meuNome = "Rayssa";
Console.WriteLine($"Meu Nome é {meuNome} e tenho {idade} anos");
Console.WriteLine("Em qual cidade você nasceu?");
//Readline serve apenas para que eu receba um informção do suário e armazeno em um varíavel 
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomeCidade}");