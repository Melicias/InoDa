namespace projeto_final_InoDa
{
    partial class FormClientes
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
            this.btGerirClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGerirClientes
            // 
            this.btGerirClientes.Location = new System.Drawing.Point(76, 253);
            this.btGerirClientes.Name = "btGerirClientes";
            this.btGerirClientes.Size = new System.Drawing.Size(118, 23);
            this.btGerirClientes.TabIndex = 1;
            this.btGerirClientes.Text = "Gerir clientes";
            this.btGerirClientes.UseVisualStyleBackColor = true;
            this.btGerirClientes.Click += new System.EventHandler(this.btGerirClientes_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGerirClientes);
            this.Name = "FormClientes";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btGerirClientes;
    }
}

