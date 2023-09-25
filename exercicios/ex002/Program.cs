Console.WriteLine("Digite a placa");
string placa = Console.ReadLine();
string final = placa.Substring(placa.Length-1, 1);

if
    (final == "1" || final == "2"){
        Console.WriteLine(" Voce nao pode andar na segunda feira ");
    }

else if
    ( final == "3" ||  final == "4"){
        Console.WriteLine(" Voce nao pode andar na terca feira ");
    }

else if
    ( final == "5" ||  final == "6"){
        Console.WriteLine(" Voce nao pode andar na quarta feira ");
    }

else if
    ( final == "7" ||  final == "8"){
        Console.WriteLine(" Voce nao pode andar na quinta feira ");
    }

else if
    ( final == "9" ||  final == "0"){
        Console.WriteLine(" Voce nao pode andar na sexta feira ");
    }
