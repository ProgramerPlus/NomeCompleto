string inicial, nome, sobrenome;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;
//Configuração para a primeira letra do nome aparecer maiúscula automaticamente e impedir minúsculas após
inicial = nome.Substring(0, 1);
inicial = inicial.ToUpper();
nome = nome.Remove(0, 1);
nome = nome.ToLower();
nome = inicial + nome;

Console.Write("Digite seu segundo nome: ");
sobrenome = Console.ReadLine()!;
//Configuração para a primeira letra do nome aparecer maiúscula automaticamente e impedir minúsculas após
inicial=sobrenome.Substring(0,1);
inicial = inicial.ToUpper();
sobrenome = sobrenome.Remove(0, 1);
sobrenome = sobrenome.ToLower();
sobrenome = inicial + sobrenome;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");