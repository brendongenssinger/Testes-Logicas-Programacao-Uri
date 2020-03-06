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

        public static void Executar_1011()
        {
            while (true)
            {
                double R = Convert.ToDouble(Obter());
                double pi = 3.14159;

                var resultado = 4/3.0*pi * Math.Pow(R,3);
                System.Console.WriteLine("VOLUME = "+resultado.ToString("0.000"));
            }
        }

        public static void Executar_1012()
        {
            while (true)
            {
                var entrada = Convert.ToString(Obter()).Split(" "); 

                var triangulo = (asDouble(entrada[0]) * asDouble(entrada[2]))/2;

                var areaCirculo = Math.Pow(asDouble(entrada[2]),2) * 3.14159;

                var areaTrapezio = ((asDouble(entrada[0]) + asDouble(entrada[1]))*asDouble(entrada[2]))/2;

                var areaQuadrado =  Math.Pow(asDouble(entrada[1]),2);

                var areaRetangulo = asDouble(entrada[0]) * asDouble(entrada[1]);

                System.Console.WriteLine("TRIANGULO: "+triangulo.ToString("0.000"));
                System.Console.WriteLine("CIRCULO: "+areaCirculo.ToString("0.000"));
                System.Console.WriteLine("TRAPEZIO: "+areaTrapezio.ToString("0.000"));
                System.Console.WriteLine("QUADRADO: "+areaQuadrado.ToString("0.000"));
                System.Console.WriteLine("RETANGULO: "+ areaRetangulo.ToString("0.000"));
            }      
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