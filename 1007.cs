using System;
namespace PraticasProgramacao2020
{
    public class _1007
    {
        public static void Executar()
        {
            int A = ObterValor();
            int B = ObterValor();
            int C = ObterValor();
            int D = ObterValor();
            int DIFERENCA = (A*B-C*D);
            
            System.Console.WriteLine("DIFERENCA = "+DIFERENCA);
        }
        public static int ObterValor()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}