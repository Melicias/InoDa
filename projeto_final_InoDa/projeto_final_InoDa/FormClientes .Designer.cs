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
            this.tbPesquisarClientes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPesquisaClientes = new System.Windows.Forms.ComboBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // tbPesquisarClientes
            // 
            this.tbPesquisarClientes.Location = new System.Drawing.Point(9, 19);
            this.tbPesquisarClientes.Name = "tbPesquisarClientes";
            this.tbPesquisarClientes.Size = new System.Drawing.Size(345, 20);
            this.tbPesquisarClientes.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPesquisaClientes);
            this.groupBox1.Controls.Add(this.btFiltrar);
            this.groupBox1.Controls.Add(this.tbPesquisarClientes);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar clientes";
            // 
            // cbPesquisaClientes
            // 
            this.cbPesquisaClientes.FormattingEnabled = true;
            this.cbPesquisaClientes.Items.AddRange(new object[] {
            "Nome",
            "NIF",
            "Contacto"});
            this.cbPesquisaClientes.Location = new System.Drawing.Point(10, 46);
            this.cbPesquisaClientes.Name = "cbPesquisaClientes";
            this.cbPesquisaClientes.Size = new System.Drawing.Size(263, 21);
            this.cbPesquisaClientes.TabIndex = 4;
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(279, 46);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btFiltrar.TabIndex = 3;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnNIF,
            this.ColumnContacto});
            this.dataGridViewClientes.Location = new System.Drawing.Point(9, 22);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(344, 398);
            this.dataGridViewClientes.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewClientes);
            this.groupBox2.Location = new System.Drawing.Point(3, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 426);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnNIF
            // 
            this.ColumnNIF.HeaderText = "NIF";
            this.ColumnNIF.Name = "ColumnNIF";
            // 
            // ColumnContacto
            // 
            this.ColumnContacto.HeaderText = "Contacto";
            this.ColumnContacto.Name = "ColumnContacto";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(500, -16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 521);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btGerirClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClientes_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btGerirClientes;
        private System.Windows.Forms.TextBox tbPesquisarClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbPesquisaClientes;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContacto;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

