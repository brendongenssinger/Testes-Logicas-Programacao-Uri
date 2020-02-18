using System;

namespace PraticasProgramacao2020
{
    public static class _1002
    {
     // formula para calcular a área de uma circuferencia area = n.raio2.
     // n = 3,14159
     // Efeute o calculo da area, elevando o valor de raio ao quadrado e mutiplicando por n.
        
        public static void Execute()
        {
            double n = 3.14159;
            var raio = double.Parse(Console.ReadLine());

            var area = (Math.Pow(raio,2)*n).ToString("0.0000");
            System.Console.WriteLine("A="+area);
            
        }    
    } 
    
}