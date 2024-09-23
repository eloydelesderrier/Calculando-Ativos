using System;

class Program
    {
        static void Main()
        {
            // Recebe a entrada do número de ativos
            int N = int.Parse(Console.ReadLine());
            
            // Recebe e divide os valores de mercado em um array de strings
            string[] valoresMercadoStr = Console.ReadLine().Split(',');
            
            double[] valoresMercado = Array.ConvertAll(valoresMercadoStr, double.Parse);
            
            
            // Recebe o valor total investido
            double valorTotalInvestido = double.Parse(Console.ReadLine());
            
            // Recebe e divide as alocações mínimas em um array de strings
            string[] alocacoesMinimasStr = Console.ReadLine().Split(',');
            
            double[] alocacoesMinimas = Array.ConvertAll(alocacoesMinimasStr, double.Parse);
            
            // Recebendo e dividindo as alocações máximas em um array de strings
            string[] alocacoesMaximasStr = Console.ReadLine().Split(',');
            
            double[] alocacoesMaximas = Array.ConvertAll(alocacoesMaximasStr, double.Parse);
            
            // Calcula o total do mercado
            double totalmercado = 0;
            for (int i = 0; i < N; i++)
            {
                
                totalmercado += totalmercado;// TODO: Some os valores de mercado para obter o total
            }

            // Calcula as alocações proporcionais e ajustando aos limites mínimos e máximos
            double[] alocacoes = new double[N];
            for (int i = 0; i < N; i++)
            {
                // TODO: Calcule a alocação proporcional
                double proporcional = (valoresMercado[i] / totalmercado ) * valorTotalInvestido;
                
                Console.WriteLine(proporcional);
                
                alocacoes[i] = Math.Max(alocacoesMinimas[i], Math.Min(alocacoesMaximas[i], proporcional)); // Ajusta dentro dos limites mínimos e máximos
              
            }

            // Imprime as alocações formatadas com duas casas decimais
            for (int i = 0; i < N; i++)
            {
                if (alocacoesMaximas[0] + alocacoesMaximas[1] < valorTotalInvestido)
                    Console.WriteLine($"{alocacoesMaximas[i]:F2}");
                else
                    Console.WriteLine($"{alocacoes[i]}:F2"); // Mostra cada alocação formatada com duas casas decimais
            }
        }
    }
