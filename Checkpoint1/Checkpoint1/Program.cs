using System;

namespace CalculadoraConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			// Variável para controlar a continuidade do loop
			bool ManterExecucao = true;

			do
			{
				Console.Clear();
				Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");
				Console.WriteLine("\nEscolha uma opção:");
				Console.WriteLine("1-Adição");
				Console.WriteLine("2-Subtração");
				Console.WriteLine("3-Multiplicação");
				Console.WriteLine("4-Divisão");
				Console.WriteLine("5-Sair");
				Console.Write("\nOpção: ");

				string Opcao = Console.ReadLine();

				// Verifica se o usuário deseja sair antes de pedir os números
				if (Opcao == "5")
				{
					ManterExecucao = false;
					Console.WriteLine("Encerrando o programa...");
					continue;
				}

				// Validação rudimentar da opção
				if (Opcao != "1" && Opcao != "2" && Opcao != "3" && Opcao != "4")
				{
					Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
					Console.ReadKey();
					continue;
				}

				// Solicitação dos números ao usuário
				Console.Write("Digite o primeiro número: ");
				double NumeroUm = Convert.ToDouble(Console.ReadLine());

				Console.Write("Digite o segundo número: ");
				double NumeroDois = Convert.ToDouble(Console.ReadLine());

				double Resultado = 0;
				bool OperacaoValida = true;

				// Estrutura de controle Switch para as operações
				switch (Opcao)
				{
					case "1":
						Resultado = NumeroUm + NumeroDois;
						Console.WriteLine($"\nResultado da Adição: {Resultado}");
						break;
					case "2":
						Resultado = NumeroUm - NumeroDois;
						Console.WriteLine($"\nResultado da Subtração: {Resultado}");
						break;
					case "3":
						Resultado = NumeroUm * NumeroDois;
						Console.WriteLine($"\nResultado da Multiplicação: {Resultado}");
						break;
					case "4":
						// Tratamento de erro: Divisão por zero
						if (NumeroDois != 0)
						{
							Resultado = NumeroUm / NumeroDois;
							Console.WriteLine($"\nResultado da Divisão: {Resultado}");
						}
						else
						{
							Console.WriteLine("\nErro: Não é possível dividir por zero!");
							OperacaoValida = false;
						}
						break;
				}

				Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
				Console.ReadKey();

			} while (ManterExecucao);
		}
	}
}