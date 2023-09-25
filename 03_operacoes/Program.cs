Console.WriteLine("Digite o valor de x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y");
int y = int.Parse(Console.ReadLine());

// Exemplos de operadores aritímeticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restodiv2 = x % 2;// calculando o resto da divisao de x \ 2
// console para exibir na tela as variaveis em cada linha 
int restodiv3 = y % 2;
//soma: 15
Console.WriteLine($"Soma: {soma}");
Console.WriteLine("subtraçao:" + subtracao);
Console.WriteLine(" Multiplicacao" + multiplicacao);
Console.WriteLine("Divisao" + divisao);
Console.WriteLine("Resto" + resto);

if (restodiv2 == 0)
{
    Console.WriteLine($"O numero {x} é par");
}
else
{
    Console.WriteLine($"O numero {x} é impar");
}

if (restodiv3 == 0)
{
    Console.WriteLine($"O resto {y} é par");
}
else
{
    Console.WriteLine($"O resto {y} é impar");
}
// Oprerador ternario
//Condição ? se verdade : senão
string resultado = (restoDiv2 == 0) ? $"O numero {x} é par" : $"O numero {x} é impar";
Console.WriteLine(resultado);

int diaSemana = 3
//aprendendo o Switch Case
switch (diaSemana){
    case 1:
    console.WriteLine("Hoje é Domingo");
    break;
    case 2:
    Console.WriteLine("Hoje é Segunda!");
    break;
    case 3:
    Console.WriteLine("Hoje é Terça");
    break
    case 4:
    Console.WriteLine("Hoje é Quarta");
    break
     case 5:
    Console.WriteLine("Hoje é Quinto");
    break
     case 6:
    Console.WriteLine("Hoje é Sexta");
    break
     case 7:
    Console.WriteLine("Hoje é Sabado");
    break
    default:
    caseonsole.WriteLine("Dia invalido");
}
