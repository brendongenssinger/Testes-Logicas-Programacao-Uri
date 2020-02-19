using System;

namespace PraticasProgramacao2020
{
    public class ExecuteTodos
    {
        public static void Executar_1010()
        {
            while(true)
            {
                var primeirosDados = Obter().ToString().Split(' ');
                var segundosDados = Obter().ToString().Split(' ');

                var total1 = Convert.ToInt16(primeirosDados[1]) * Convert.ToDouble(primeirosDados[2]);
                var total2 = Convert.ToInt16(segundosDados[1]) * Convert.ToDouble(segundosDados[2]);

                var sumTotais = total1+total2;
                System.Console.WriteLine("VALOR A PAGAR: R$ "+sumTotais.ToString("0.00"));
            }
        }
        
        public static void Executar_1009()
        {
            while (true)
            {
                var NOME = Obter().ToString();
                var SALARIO = Convert.ToDouble(Obter());
                var VENDAS = Convert.ToDouble(Obter());
                double PORCENTAGEM = 15;

                double TOTAL = (VENDAS*(PORCENTAGEM/100)+ SALARIO);
                System.Console.WriteLine("TOTAL = R$ "+ TOTAL.ToString("0.00"));
            }
        }
        public static object Obter()
        {
            return Console.ReadLine();
        }
    }
}