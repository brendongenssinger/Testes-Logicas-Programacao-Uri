using System;
namespace PraticasProgramacao2020
{
    public static class _1008
    {
        public static void Executar()
        {
            while (true)
            {
                var HORAS_TRABALHADAS = Convert.ToInt16(Obter());
                var VALOR = Convert.ToInt16(Obter());
                var SALARIO = Convert.ToDouble(Obter());

                System.Console.WriteLine("NUMBER = "+HORAS_TRABALHADAS);
                System.Console.WriteLine("SALARY = U$ "+(SALARIO*VALOR).ToString("0.00"));
            }
        }
        public static object Obter()
        {
            return Console.ReadLine();
        }
    }
}