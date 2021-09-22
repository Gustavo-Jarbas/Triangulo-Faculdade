using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo.PadraoMVC
{
    public abstract class absPropriedades
    {

        public double L1;
        public double L2;
        public double L3;

        public string Lado1;
        public string Lado2;
        public string Lado3;

        public string Resposta { get; set; }
        public string Mensagem { get; set; }

        protected double l1;
        protected double l2;
        protected double l3;

        protected string lado1;
        protected string lado2;
        protected string lado3;

        private string resposta { get; set; }
        private string mensagem { get; set; }

        public absPropriedades(double l1, double l2, double l3)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;
        }

        public absPropriedades(string lado1, string lado2, string lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public virtual void Verificar() { }
        public virtual void Validar() { }
    }
}
