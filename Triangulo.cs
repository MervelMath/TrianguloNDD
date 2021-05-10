using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.ConsoleApp
{
    public class Triangulo
    {
        public int lado1;
        public int lado2;
        public int lado3;

        public Triangulo()
        {
        }
        public Triangulo(int lado1, int lado2, int lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public virtual void Tipo()
        {

        }
        public string Verificacao()
        {
            string verifica = "Não";
            if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
            {
                verifica = "Sim";
                return verifica;
            }
            else
            {
                return verifica;
            }
        }

        public void TipoTriangulo()
        {
            if (Verificacao() == "Sim")
            {
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Equilatero equi = new Equilatero();
                    equi.Tipo();
                }
                else if ((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) || lado2 == lado3 && lado2 != lado1)
                {
                    Isosceles iso = new Isosceles();
                    iso.Tipo();
                }
                else if (lado1 != lado2 && lado1 != lado3 && lado3 != lado2)
                {
                    Escaleno esc = new Escaleno();
                    esc.Tipo();
                }
            }
        }
    }
}
