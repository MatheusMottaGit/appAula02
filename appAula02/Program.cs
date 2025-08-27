//string nome;
//byte idade;

//Console.Write("digite seu nome: ");
//nome = Console.ReadLine();


//Console.Write("digite sua idade: ");
//idade = Convert.ToByte(Console.ReadLine());

//Console.WriteLine(nome + idade);

//idade *= 2;

//Console.WriteLine($"Idade atual: {idade++}");

//try {
//    // exercicio
//    double salary;

//    Console.Write("Digite seu salário: ");
//    salary = Convert.ToDouble(Console.ReadLine());

//    if (salary <= 1518)
//    {
//        salary -= salary * 0.075;
//    }
//    else if (salary >= 1518 && salary <= 2793.88)
//    {
//        salary -= salary * 0.095;
//    }
//    else if (salary >= 2793.88 && salary <= 4190.83)
//    {
//        salary -= salary * 0.12;
//    }
//    else if (salary >= 4190.84 && salary <= 8157.41)
//    {
//        salary -= salary * 0.14;
//    }

//    Console.WriteLine($"Salário com desconto: {salary}");
//}
//catch (Exception e) { 
//    Console.WriteLine(e.Message);
//}


using System.Drawing;
using appAula02.uteis;

// 1
int result;

// 2
double resultMilimetros;

// 3
double resultAumento;
double valorA = 100;
double percentualAumento = 0.1;

// 4
double resultDesconto;
double valorD = 100;
double percentual = 0.1;

Console.WriteLine("Escolha uma opção: soma, conversao, aumento, desconto");
string option = Console.ReadLine();

do
{
    switch (option)
    {
        case "soma":
            SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
            result = somaDoisNumeros.somar(10, 20);
            Console.WriteLine(result);
            break;

        case "conversao":
            MetrosMilimetros metrosMilimetros = new MetrosMilimetros();
            resultMilimetros = metrosMilimetros.converter(2.5);
            Console.WriteLine(resultMilimetros);
            break;

        case "aumento":
            CalculaAumento calculaAumento = new CalculaAumento();
            resultAumento = calculaAumento.aumentar(valorA, percentualAumento);

            Console.WriteLine($"Valor escolhido: {valorA}");
            Console.WriteLine($"Percentual de aumento: {percentualAumento * 100}%");
            Console.WriteLine($"Valor com aumento: {resultAumento}");
            break;

        case "desconto":
            AplicaDesconto aplicaDesconto = new AplicaDesconto();
            resultDesconto = aplicaDesconto.descontar(valorD, percentual);

            Console.WriteLine($"Valor escolhido: {valorD}");
            Console.WriteLine($"Percentual de desconto: {percentual * 100}%");
            Console.WriteLine($"Valor com desconto: {resultDesconto}");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
while (option != "");