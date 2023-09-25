string Seunome = Console.ReadLine();
Console.WriteLine($"Nome do aluno {Seunome}");

Console.WriteLine("Digite o valor de x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de z");
int z = int.Parse(Console.ReadLine());

int nota = x;
int nota2 = y;
int nota3 = z;
int notafinal = (nota + nota2 + nota3)/3;

string resultado = (notafinal >= 7) ? $"A media do aluno foi {notafinal} Aprovado!" : $"A media do aluno for {notafinal} Repetiu de ano";
Console.WriteLine(resultado);
