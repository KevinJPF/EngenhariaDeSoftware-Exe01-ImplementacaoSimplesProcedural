using System;

class Program
{
    #region Variables
    private static double valorDelta, valorEquacaoSoma, valorEquacaoSubtracao;
    private static double valorA;
    private static double valorB;
    private static double valorC;
    #endregion

    #region Functions  
    public static void Main(string[] args)
    {
        string valorDigitado;
    
        Console.WriteLine("Programa para cálculo de equações de segundo grau.\nPara começar, digite os 3 valores.\n");

        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine($"{i + 1}º valor: ");
            do
            {
              valorDigitado = Console.ReadLine();
            } while (!NumeroValido(valorDigitado));
          
            switch (i)
            {
                case 0:
                    valorA = Double.Parse(valorDigitado);
                    break;
                case 1:
                    valorB = Double.Parse(valorDigitado);
                    break;
                case 2:
                    valorC = Double.Parse(valorDigitado);
                    break;
                default:
                    break;
            }
        }

        if (CalculoDelta() < 0)
        {
            Console.WriteLine("\nNão há solução para os valores inseridos. O resultado de Delta foi: " + valorDelta.ToString("N2"));
        }
        else
        {
            Console.WriteLine("\nO valor de Delta dos valores inseridos foi: " + valorDelta.ToString("N2"));
            CalculoEquacaoSegundoGrauSoma();
            CalculoEquacaoSegundoGrauSubtracao();
            if (valorDelta > 0)
            {
                Console.WriteLine($"\nA equação de segundo grau dos valores inseridos tem dois resultados para 'X'.\nResultado da equação com soma da raiz de Delta: {valorEquacaoSoma}\nResultado da equação com subtração da raiz de Delta: {valorEquacaoSubtracao}");
            }
            else {
              Console.WriteLine($"\nA equação de segundo grau dos valores inseridos tem um resultado para 'X'.\nResultado da equação com a raiz de Delta: {valorEquacaoSoma}");
            }
        }
    }
    private static bool NumeroValido(string numeroDigitado)
    {
      double valorConvertido;
        if (!double.TryParse(numeroDigitado, out valorConvertido))
        {
            Console.WriteLine("Você digitou um número inválido.");
            return false;
        }
        else
        {
            return true;
        }
    }
    private static double CalculoDelta() {
        return valorDelta = (valorB * valorB) - 4 * valorA * valorC;
    }
    private static double CalculoEquacaoSegundoGrauSoma() {
      return valorEquacaoSoma = (-valorB + Math.Sqrt(CalculoDelta())) / (2 * valorA);
    }
    private static double CalculoEquacaoSegundoGrauSubtracao() {
      return valorEquacaoSubtracao = (-valorB - Math.Sqrt(CalculoDelta())) / (2 * valorA);
    }
    #endregion
}