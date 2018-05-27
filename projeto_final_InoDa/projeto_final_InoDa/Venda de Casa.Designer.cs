namespace projeto_final_InoDa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbProprietario = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbComissão = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(96, 30);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(46, 13);
            this.lbEstado.TabIndex = 0;
            this.lbEstado.Text = "Estado: ";
            this.lbEstado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbProprietario
            // 
            this.lbProprietario.AutoSize = true;
            this.lbProprietario.Location = new System.Drawing.Point(96, 59);
            this.lbProprietario.Name = "lbProprietario";
            this.lbProprietario.Size = new System.Drawing.Size(63, 13);
            this.lbProprietario.TabIndex = 1;
            this.lbProprietario.Text = "Proprietario:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(96, 90);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 2;
            this.lbValor.Text = "Valor:";
            // 
            // lbComissão
            // 
            this.lbComissão.AutoSize = true;
            this.lbComissão.Location = new System.Drawing.Point(96, 119);
            this.lbComissão.Name = "lbComissão";
            this.lbComissão.Size = new System.Drawing.Size(79, 13);
            this.lbComissão.TabIndex = 3;
            this.lbComissão.Text = "Comissão Base";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbComissão);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbProprietario);
            this.Controls.Add(this.lbEstado);
            this.Name = "Form1";
            this.Text = "Venda de Casa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbProprietario;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbComissão;
    }
}