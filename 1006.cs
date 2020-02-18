using System;

namespace PraticasProgramacao2020
{   public static class _1006
    {
        public static void Executar()
        {
            double A = double.Parse(Console.ReadLine())*2;
            double B = double.Parse(Console.ReadLine())*3;
            double C = double.Parse(Console.ReadLine())*5;

            double MEDIA = (A+B+C)/10;
            System.Console.WriteLine("MEDIA = "+MEDIA.ToString("0.0"));
        }
    }
}