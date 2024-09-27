using System;
interface OperacaoMatematica
{
    double Soma(double a, double b);
    double Subtracao(double a, double b);
    double Multiplicacao(double a, double b);
    double Divisao(double a, double b);
}

class Calculadora : OperacaoMatematica
{
    public double Soma(double a, double b)
    {
        return a + b;
    }

    public double Subtracao(double a, double b)
    {
        return a - b;
    }

    public double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    public double Divisao(double a, double b)
    {
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        Console.Write("Digite a operação: ");
        int operacao = Convert.ToInt32(Console.ReadLine());

        {
            switch (operacao)
            {
                case 1:
                    Console.WriteLine("Resultado da Soma: " + calc.Soma(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Resultado da Subtração: " + calc.Subtracao(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Resultado da Multiplicacao: " + calc.Multiplicacao(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Resultado da Divisão: " + calc.Divisao(num1, num2));
                    break;
                default:
                    Console.WriteLine("Operação inválida. Por favor, escolha entre 1 e 4.");
                    break;
            }
        }

    }
}
