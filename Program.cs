using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(2, 2, 2);


            if(triangulo.Verificacao() == "Sim")
            {
                Console.WriteLine("É um triângulo.");
                triangulo.TipoTriangulo();
            }
            else
            {
                Console.WriteLine("Não é um triângulo.");
            }
            

            Triangulo triangulo2 = new Triangulo(2, 2, 3);


            if (triangulo.Verificacao() == "Sim")
            {
                Console.WriteLine("É um triângulo.");
                triangulo2.TipoTriangulo();
            }
            else
            {
                Console.WriteLine("Não é um triângulo.");
            }
            


            Triangulo triangulo3 = new Triangulo(3, 4, 5);

            if (triangulo.Verificacao() == "Sim")
            {
                Console.WriteLine("É um triângulo.");
                triangulo3.TipoTriangulo();
            }
            else
            {
                Console.WriteLine("Não é um triângulo.");
            }
            

            

            Triangulo trianguloErrado = new Triangulo(10, 1, 2);

            if (trianguloErrado.Verificacao() == "Sim")
            {
                Console.WriteLine("É um triângulo.");
                trianguloErrado.TipoTriangulo();
            }
            else
            {
                Console.WriteLine("Não é um triângulo.");
            }

            

            Console.ReadLine();
        }
    }
}
