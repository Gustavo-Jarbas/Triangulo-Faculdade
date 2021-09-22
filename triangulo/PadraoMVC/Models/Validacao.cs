using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo.PadraoMVC.Models
{
    class Validacao : absPropriedades
    {
        public Validacao(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
            Validar();
        }
        public override void Validar()
        {
            try
            {
                this.L1 = Convert.ToDouble(this.Lado1);
                this.L2 = Convert.ToDouble(this.Lado2);
                this.L3 = Convert.ToDouble(this.Lado3);

                this.Resposta = "Entrada valida";

            }
            catch (Exception)
            {
                this.Resposta = "Entrada invalida";
            }
        }
    }
}
