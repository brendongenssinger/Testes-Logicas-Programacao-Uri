using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace PraticasProgramacao2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //_1002.Execute();
            //_1006.Executar();
            //_1007.Executar();
            //_1008.Executar();
            //ExecuteTodos.Executar_1010();
            //ExecuteTodos.Executar_1011();
            //ExecuteTodos.Executar_1012();

                string[] entrada = Console.ReadLine().ToString().Split(" ",3); 
                double A = Convert.ToDouble(entrada[0]);
                double B = Convert.ToDouble(entrada[1]);
                double C = Convert.ToDouble(entrada[2]);
                double pi = 3.14159;
                double areaTriangulo = ( A * C )/2;
                double areaCirculo = (C*C)  * pi;
                double areaTrapezio = (A + B)/2* C ;
                double areaQuadrado =  Math.Pow(B,2);
                double areaRetangulo = A * B;
                System.Console.WriteLine("TRIANGULO: "+areaTriangulo.ToString("0.000"));
                System.Console.WriteLine("CIRCULO: "+areaCirculo.ToString("0.000"));
                System.Console.WriteLine("TRAPEZIO: "+areaTrapezio.ToString("0.000"));
                System.Console.WriteLine("QUADRADO: "+areaQuadrado.ToString("0.000"));
                System.Console.WriteLine("RETANGULO: "+ areaRetangulo.ToString("0.000"));

                
                var lista = new List<Exception>();
                    for (int i = 0; i < 13; i++)
                    {
                        try
                        {
                            // roda 
                        }
                        catch(Exception eXs)
                        {   lista.Add(eXs);
                        }         
                    }
                if(lista.Count > 0)
                {
                    System.Console.WriteLine(string.Join(",",lista.Select(pX=> pX.Message)) );
                }
            
            Console.ReadLine();
        }

        public static object Obter()
        {
            return Console.ReadLine();
        }

    }






}
