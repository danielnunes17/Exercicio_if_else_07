/*Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
mostre o valor que essa pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

Renda
0.00 a 2000.00 - isento
2000.01 a 3000.00 - 8%
3000.01 a 4500.00 - 18%
acima de 4500.00 - 28%

Lembre que, se o salário for R$ 3000.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
duas casas decimais.*/

using System.Globalization;

public class Program
{
    public static void Main(string[] arg)
    {
        Console.WriteLine("Digite o valor do seu salario: ");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salarioTributavel = salario - 2000;

        if (salario < 2000)
            Console.WriteLine("Isento");
        else if (salario >= 2000.01 && salario <= 3000)
            CalcularSalarioLiquido(0.08, salarioTributavel);
        else if (salario >= 3000.01 && salario <= 4500)
            CalcularSalarioLiquido(0.18, salarioTributavel);
        else
            CalcularSalarioLiquido(0.28, salarioTributavel);
    }
    private static void CalcularSalarioLiquido(double porcentagemImposto, double salarioTributavel)
    {
        double imposto = salarioTributavel * porcentagemImposto;
        Console.WriteLine("R$: " + imposto.ToString("F2", CultureInfo.InvariantCulture));
    }
}

