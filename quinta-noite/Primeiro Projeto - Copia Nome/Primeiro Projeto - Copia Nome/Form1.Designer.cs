
namespace Primeiro_Projeto___Copia_Nome
{
    partial class frmCopiaNome
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
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btCopia = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbsobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Transparent;
            this.lbNome.Location = new System.Drawing.Point(12, 45);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(202, 20);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Informe seu primeiro nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(220, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 26);
            this.txtNome.TabIndex = 1;
            // 
            // btCopia
            // 
            this.btCopia.BackColor = System.Drawing.Color.LightCoral;
            this.btCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCopia.ForeColor = System.Drawing.Color.Transparent;
            this.btCopia.Location = new System.Drawing.Point(53, 134);
            this.btCopia.Name = "btCopia";
            this.btCopia.Size = new System.Drawing.Size(348, 33);
            this.btCopia.TabIndex = 2;
            this.btCopia.Text = "Copiar";
            this.btCopia.UseVisualStyleBackColor = false;
            this.btCopia.Click += new System.EventHandler(this.btCopia_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.Color.Yellow;
            this.lbResultado.Location = new System.Drawing.Point(48, 213);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(47, 26);
            this.lbResultado.TabIndex = 3;
            this.lbResultado.Text = "-----";
            this.lbResultado.Visible = false;
            // 
            // lbsobrenome
            // 
            this.lbsobrenome.AutoSize = true;
            this.lbsobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsobrenome.ForeColor = System.Drawing.Color.Transparent;
            this.lbsobrenome.Location = new System.Drawing.Point(32, 90);
            this.lbsobrenome.Name = "lbsobrenome";
            this.lbsobrenome.Size = new System.Drawing.Size(182, 20);
            this.lbsobrenome.TabIndex = 4;
            this.lbsobrenome.Text = "Informe seu sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(220, 87);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(204, 26);
            this.txtSobrenome.TabIndex = 5;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(53, 173);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(348, 23);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Limpar tudo";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // frmCopiaNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(456, 257);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lbsobrenome);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btCopia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Name = "frmCopiaNome";
            this.Text = "Copiador de nome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btCopia;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbsobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Button btLimpar;
    }
}

