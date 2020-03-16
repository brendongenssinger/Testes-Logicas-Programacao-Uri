using System;
using System.Collections.Generic;
using System.Reflection;
namespace PraticasProgramacao2020
{
    public class ExecuteTodos
    {

        public static void Executar(int pNumber)
        {
            var dic = new Dictionary<int,Action>();
            dic.Add(1010,new Action(Executar_1010));
            dic.Add(1009,new Action(Executar_1009));
            dic.Add(1011,new Action(Executar_1011));
            dic.Add(1012,new Action(Executar_1012));
            if(dic.ContainsKey(pNumber))
            {
                while (true)
                {
                    dic[pNumber]();
                }
            }

        }
        private static void Executar_1010()
        {
        
            var primeirosDados = Obter().ToString().Split(' ');
            var segundosDados = Obter().ToString().Split(' ');

            var total1 = Convert.ToInt16(primeirosDados[1]) * Convert.ToDouble(primeirosDados[2]);
            var total2 = Convert.ToInt16(segundosDados[1]) * Convert.ToDouble(segundosDados[2]);

            var sumTotais = total1+total2;
            System.Console.WriteLine("VALOR A PAGAR: R$ "+sumTotais.ToString("0.00"));
            
        }
        
        private static void Executar_1009()
        {
            
            var NOME = Obter().ToString();
            var SALARIO = Convert.ToDouble(Obter());
            var VENDAS = Convert.ToDouble(Obter());
            double PORCENTAGEM = 15;

            double TOTAL = (VENDAS*(PORCENTAGEM/100)+ SALARIO);
            System.Console.WriteLine("TOTAL = R$ "+ TOTAL.ToString("0.00"));
            
        }

        private static void Executar_1011()
        {
            
            double R = Convert.ToDouble(Obter());
            double pi = 3.14159;

            var resultado = 4/3.0*pi * Math.Pow(R,3);
            System.Console.WriteLine("VOLUME = "+resultado.ToString("0.000"));
            
        }

        private static void Executar_1012()
        {
            System.Console.WriteLine($"{MethodInfo.GetCurrentMethod().Name}");
            
            var entrada = Convert.ToString(Console.ReadLine()); 

            var _A = Convert.ToDecimal(entrada.Split(" ")[0]);
            var _B = Convert.ToDecimal(entrada.Split(" ")[1]);
            var _C = Convert.ToDecimal(entrada.Split(" ")[2]);

            var areaTriangulo = Convert.ToDecimal((( _A * _C )/2));
            var areaCirculo = Convert.ToDecimal( ( _C * _C )  * 3.14159m);
            var areaTrapezio = Convert.ToDecimal((_A + _B)/2 * _C );
            var areaQuadrado = Convert.ToDecimal(Convert.ToDecimal(Math.Pow(Convert.ToDouble(_B),2)));
            

            Console.WriteLine("TRIANGULO: "+areaTriangulo.ToString("0.000"));
            Console.WriteLine("CIRCULO: "+areaCirculo.ToString("0.000"));
            Console.WriteLine("TRAPEZIO: "+areaTrapezio.ToString("0.000"));
            Console.WriteLine("QUADRADO: "+areaQuadrado.ToString("0.000"));
            Console.WriteLine("RETANGULO: "+ (_A*_B).ToString("0.000"));
            Console.ReadLine();
             
        }

        public static object Obter()
        {
            return Console.ReadLine();
        }

        public static double asDouble(string pValor)
        {
            return Convert.ToDouble(pValor);
        }
    }
}