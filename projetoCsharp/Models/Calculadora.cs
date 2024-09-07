using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadoras.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x}+{y}= {x+y}");
        }
        public void Subtrair (int x, int y){
            Console.WriteLine($"{x}-{y}= {x-y}");
        }
        public void Dividir(int x, int y, int z){
            Console.WriteLine($"{x}/{y}= {x/y} e sobra %{z}");
        }
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x}*{y}= {x*y}");
        }
        public void potencia(int x, int y){
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void seno (double angulo){
            double radiano = angulo * Math.PI/180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
        }
        public void cosseno(double angulo){
            double radiano = angulo * Math.PI/180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo} = {Math.Round(cosseno, 4)}");
        }
        public void tangente(double angulo){
        double radiano = angulo * Math.PI/180;
        double tangente = Math.Tan(radiano);
        Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }
        public void raizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrade de {x} = {raiz}");
        }
    }
}