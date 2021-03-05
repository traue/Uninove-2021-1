
namespace Primeira_Calculadora
{
    partial class Form1
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
            this.lvValorA = new System.Windows.Forms.Label();
            this.lbValorB = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.btSomar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvValorA
            // 
            this.lvValorA.AutoSize = true;
            this.lvValorA.Location = new System.Drawing.Point(52, 62);
            this.lvValorA.Name = "lvValorA";
            this.lvValorA.Size = new System.Drawing.Size(44, 13);
            this.lvValorA.TabIndex = 0;
            this.lvValorA.Text = "Valor A:";
            // 
            // lbValorB
            // 
            this.lbValorB.AutoSize = true;
            this.lbValorB.Location = new System.Drawing.Point(52, 88);
            this.lbValorB.Name = "lbValorB";
            this.lbValorB.Size = new System.Drawing.Size(47, 13);
            this.lbValorB.TabIndex = 1;
            this.lbValorB.Text = "Valor B: ";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(102, 59);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 20);
            this.txtValorA.TabIndex = 2;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(102, 85);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 20);
            this.txtValorB.TabIndex = 3;
            // 
            // btSomar
            // 
            this.btSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSomar.Location = new System.Drawing.Point(55, 121);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(44, 36);
            this.btSomar.TabIndex = 4;
            this.btSomar.Text = "+";
            this.btSomar.UseVisualStyleBackColor = true;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.Color.White;
            this.lbResultado.Location = new System.Drawing.Point(49, 9);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 31);
            this.lbResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 204);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btSomar);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lbValorB);
            this.Controls.Add(this.lvValorA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvValorA;
        private System.Windows.Forms.Label lbValorB;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.Label lbResultado;
    }
}

