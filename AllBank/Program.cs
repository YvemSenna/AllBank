using AllBank;
using Microsoft.Web.Mvc.Controls;
using sun.security.util;
using System.Globalization;

ContaBancaria conta;

Console.Write("Entre com númerro da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre com o titular da Conta: ");
string titular = Console.ReadLine();
Console.WriteLine("Your password is: " + password);
Console.ReadLine();
Console.Write("Haverá depósito inicial (S/N)? ");
char resp = char.Parse(Console.ReadLine());
if (resp == 'S' || resp == 'S')
{
    Console.Write(" Entre com o valor de depósito inicial: ");
    double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, DepositoInicial);
}
else 
{
    conta = new ContaBancaria( numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da Conta: ");
Console.WriteLine(conta);
    




