using System;

namespace CalculadoraConsole
{
	public class Calculadora
	{
		public double Adicionar(double NumeroUm, double NumeroDois)
		{
			return NumeroUm + NumeroDois;
		}

		public double Subtrair(double NumeroUm, double NumeroDois)
		{
			return NumeroUm - NumeroDois;
		}

		public double Multiplicar(double NumeroUm, double NumeroDois)
		{
			return NumeroUm * NumeroDois;
		}

		public double Dividir(double NumeroUm, double NumeroDois)
		{
			// O tratamento de erro continua existindo para proteger o método
			if (NumeroDois == 0)
			{
				throw new DivideByZeroException("Não é possível dividir por zero!");
			}
			return NumeroUm / NumeroDois;
		}
	}
}