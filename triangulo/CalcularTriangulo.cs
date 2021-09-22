using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using triangulo.PadraoMVC;

namespace triangulo
{
    public partial class CalcularTriangulo : Form
    {
        private Controller MeuControlador;

        public CalcularTriangulo()
        {
            InitializeComponent();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            MeuControlador = new Controller(txb_Lado1.Text, txb_Lado2.Text, txb_Lado3.Text);
            lbl_Resultado.Text = MeuControlador.Resposta;
        }
    }
}
