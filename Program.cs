string inicial, nome, sobrenome;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;
inicial = nome.Substring(0, 1);
inicial = inicial.ToUpper();
//Configuração para a primeira letra do nome aparecer maiúscula automaticamente
nome = nome.Remove(0, 1);
nome = inicial + nome;

Console.Write("Digite seu segundo nome: ");
sobrenome=Console.ReadLine()!;
inicial=sobrenome.Substring(0,1);
inicial = inicial.ToUpper();
//Configuração para a primeira letra do nome aparecer maiúscula automaticamente
sobrenome = sobrenome.Remove(0, 1);
sobrenome = inicial + sobrenome;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");