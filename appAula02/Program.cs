string nome;
byte idade;

Console.Write("digite seu nome: ");
nome = Console.ReadLine();


Console.Write("digite sua idade: ");
idade = Convert.ToByte(Console.ReadLine());

Console.WriteLine(nome + idade);
