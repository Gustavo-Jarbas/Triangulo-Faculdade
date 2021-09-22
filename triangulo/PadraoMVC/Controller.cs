using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangulo.PadraoMVC.Models;

namespace triangulo.PadraoMVC
{
    class Controller : absPropriedades
    {
        private absPropriedades TrianguloConverter;

        public Controller(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3) { 
            Verificar();
        }

        public override void Verificar()
        {
            TrianguloConverter = new Validacao(this.Lado1, this.Lado2, this.Lado3);

            if(TrianguloConverter.Resposta == "Entrada valida")
            {
                TrianguloConverter = new Triangulos(TrianguloConverter.L1, TrianguloConverter.L2, TrianguloConverter.L3);
            }
            this.Resposta = TrianguloConverter.Resposta;
        }
    }
}
