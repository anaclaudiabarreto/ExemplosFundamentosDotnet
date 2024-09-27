using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro para somar</param>
        /// <param name="y">O segundo número inteiro para somar</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} : {y} = {x / y}");
        }

        public void RetornarRestoDivisao(int x, int y)
        {
            Console.WriteLine($"O resto da divisão de {x} por {y} é {x % y}");
        }  

        public void RealizarPotenciacao(int x, int y)
        {
            double potencia = Math.Pow(x,y); //método já existente que realiza a potenciação na classe Math
            Console.WriteLine($"{x}^{y} = {potencia}");
        } 

        public void LocalizarRaizQuadrada(double x)
        {
          double raizQuadrada = Math.Sqrt(x);  
          var raizQuadradaResumida = Math.Round(raizQuadrada, 4);
          Console.WriteLine($"A raiz quadrada de {x} é {raizQuadradaResumida}");
        }

        public void ObterSeno(double angulo)
        {
            var radiano = angulo * Math.PI / 180;
            var seno = Math.Sin(radiano);
            var senoResumido = Math.Round(seno, 4);
            Console.WriteLine($"Seno de {angulo}° = {senoResumido}");
        }

        public void ObterCoseno(double angulo)
        {
            var radiano = angulo * Math.PI / 180;
            var coseno = Math.Cos(radiano);
            var cosenoResumido = Math.Round(coseno, 4);
            Console.WriteLine($"Coseno de {angulo}° = {cosenoResumido}");
        }

        public void ObterTangente(double angulo)
        {
            var radiano = angulo * Math.PI / 180;
            var tangente = Math.Tan(radiano);
            var tangenteResumida = Math.Round(tangente, 4);
            Console.WriteLine($"Tangente de {angulo}° = {tangenteResumida}");
        }
    }
}