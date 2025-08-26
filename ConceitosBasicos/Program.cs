/*
try
{
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe seu salario: ");
    decimal salario = decimal.Parse(Console.ReadLine());
    Console.WriteLine($"Bem vindo {nome}, Você tem ${salario} kwanzas.");

    //Informar o valor do IRPF a ser pago de acordo com salario informado. utilize a tabela real de desconto do IRPF

    var calculo = salario * 0.075m - 169.21m;
    var calculo1 = salario * 0.15m - 381.44m;
    var calculo2 = salario * 0.225m - 662.77m;
    var calculo3 = salario * 0.275m - 896m;

    if (salario <= 2259.20m)
        Console.WriteLine("Isento");
    else if (salario >= 2259.20m && salario <= 2826.65m)
    {
        Console.WriteLine($"Terá que pagar a aliquota de 7,5% que é {calculo} que será descontado");
        Console.WriteLine($"Seu salario liquido é de {salario - calculo} kwanzas");
    }
    else if (salario >= 2826.65m && salario <= 3751.05m)
    {
        Console.WriteLine($"Terá que pagar a aliquota de 15% que é {calculo1} que será descontado");
        Console.WriteLine($"Seu salario liquido é de {salario - calculo1} kwanzas");
    }
    else if (salario >= 2751.05m && salario <= 4664.68m)
    {
        Console.WriteLine($"Terá que pagar a aliquota de 22,5% que é {calculo2} que será descontado");
        Console.WriteLine($"Seu salario liquido é de {salario - calculo2} kwanzas");
    }
    else
    {
        Console.WriteLine($"Terá que pagar a aliquota de 27,5% que é {calculo3} que será descontado");
        Console.WriteLine($"Seu salario liquido é de {salario - calculo3} kwanzas");
    }
}
catch (FormatException)
{
    Console.WriteLine("O salario deve ser informado em numérico.");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro. Informe ao técnico. e trate de largar de ser burro.");
    Console.WriteLine(e.StackTrace);
}
*/

using ConceitosBasicos.uteis;

SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
int resultado = somaDoisNumeros.Somar(20, 22);
Console.WriteLine(resultado);

/*
MetrosMilimetricos metrosMilimetricos = new MetrosMilimetricos();
int resultado1 = metrosMilimetricos.MetrosToM(8);
Console.WriteLine(resultado1);
*/

int milimetros = MetrosMilimetricos.MetrosToM(8);
Console.WriteLine(milimetros);j


