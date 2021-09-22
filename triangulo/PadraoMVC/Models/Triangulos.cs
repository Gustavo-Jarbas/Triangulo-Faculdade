using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo.PadraoMVC.Models
{
    class Triangulos : absPropriedades
    {
        public Triangulos(double l1, double l2, double l3) : base(l1, l2, l3)
        {
            Verificar();
        }
        public override void Verificar()
        {
            if ((L1 < L2 + L3) && (L2 < L1 + L3) && (L3 < L1 + L2))
            {
                if ((L1 == L2) && (L2 == L3))
                {
                    this.Resposta = "Triângulo Equilátero";
                }
                else if ((L1 == L2) || (L2 == L3) || (L1 == L3))
                {
                    this.Resposta = "Triângulo Isósceles";
                }
                else
                {
                    this.Resposta = "Triângulo Escaleno";
                }
            }
            else
            {
                this.Resposta = "Não é um Triângulo";
            }
        }
    }
}
