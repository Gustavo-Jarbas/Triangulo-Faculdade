
namespace triangulo
{
    partial class CalcularTriangulo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Lado1 = new System.Windows.Forms.TextBox();
            this.txb_Lado2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Lado3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado 1";
            // 
            // txb_Lado1
            // 
            this.txb_Lado1.Location = new System.Drawing.Point(80, 59);
            this.txb_Lado1.Name = "txb_Lado1";
            this.txb_Lado1.Size = new System.Drawing.Size(100, 20);
            this.txb_Lado1.TabIndex = 1;
            // 
            // txb_Lado2
            // 
            this.txb_Lado2.Location = new System.Drawing.Point(80, 121);
            this.txb_Lado2.Name = "txb_Lado2";
            this.txb_Lado2.Size = new System.Drawing.Size(100, 20);
            this.txb_Lado2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lado 2";
            // 
            // txb_Lado3
            // 
            this.txb_Lado3.Location = new System.Drawing.Point(80, 184);
            this.txb_Lado3.Name = "txb_Lado3";
            this.txb_Lado3.Size = new System.Drawing.Size(100, 20);
            this.txb_Lado3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lado 3";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.Location = new System.Drawing.Point(91, 223);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Verificar.TabIndex = 6;
            this.btn_Verificar.Text = "Verificar";
            this.btn_Verificar.UseVisualStyleBackColor = true;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(101, 273);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(52, 13);
            this.lbl_Resultado.TabIndex = 7;
            this.lbl_Resultado.Text = "Resposta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 316);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.txb_Lado3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Lado2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Lado1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Lado1;
        private System.Windows.Forms.TextBox txb_Lado2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Lado3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}

