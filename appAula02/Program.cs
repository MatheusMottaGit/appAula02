//string nome;
//byte idade;

//Console.Write("digite seu nome: ");
//nome = Console.ReadLine();


//Console.Write("digite sua idade: ");
//idade = Convert.ToByte(Console.ReadLine());

//Console.WriteLine(nome + idade);

//idade *= 2;

//Console.WriteLine($"Idade atual: {idade++}");


// exercicio
double salary;

Console.Write("Digite seu salário: ");
salary = Convert.ToDouble(Console.ReadLine());

if (salary <= 1518)
{
    salary -= salary * 0.075;
} else if (salary >= 1518 && salary <= 2793.88) {
    salary -= salary * 0.095;
} else if (salary >= 2793.88 && salary <= 4190.83) {
    salary -= salary * 0.12;
} else if (salary >= 4190.84 && salary <= 8157.41)
{
    salary -= salary * 0.14;
}

Console.WriteLine($"Salário com desconto: {salary}");