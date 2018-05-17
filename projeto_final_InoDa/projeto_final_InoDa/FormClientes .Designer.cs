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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbMorada = new System.Windows.Forms.Label();
            this.lbNif = new System.Windows.Forms.Label();
            this.lbContacto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.lbCasas = new System.Windows.Forms.Label();
            this.lbArrendamentos = new System.Windows.Forms.Label();
            this.lbAquisições = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbDetalhes.SuspendLayout();
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
            this.dataGridViewClientes.Size = new System.Drawing.Size(344, 509);
            this.dataGridViewClientes.TabIndex = 4;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewClientes);
            this.groupBox2.Location = new System.Drawing.Point(3, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 537);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.lbAquisições);
            this.gbDetalhes.Controls.Add(this.lbArrendamentos);
            this.gbDetalhes.Controls.Add(this.lbCasas);
            this.gbDetalhes.Controls.Add(this.richTextBox3);
            this.gbDetalhes.Controls.Add(this.richTextBox2);
            this.gbDetalhes.Controls.Add(this.richTextBox1);
            this.gbDetalhes.Controls.Add(this.btnGuardar);
            this.gbDetalhes.Controls.Add(this.btnNovo);
            this.gbDetalhes.Controls.Add(this.textBox4);
            this.gbDetalhes.Controls.Add(this.textBox3);
            this.gbDetalhes.Controls.Add(this.textBox2);
            this.gbDetalhes.Controls.Add(this.textBox1);
            this.gbDetalhes.Controls.Add(this.lbContacto);
            this.gbDetalhes.Controls.Add(this.lbNome);
            this.gbDetalhes.Controls.Add(this.lbMorada);
            this.gbDetalhes.Controls.Add(this.lbNif);
            this.gbDetalhes.Location = new System.Drawing.Point(382, 92);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(376, 566);
            this.gbDetalhes.TabIndex = 6;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Detalhes";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(13, 635);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(350, 23);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(44, 37);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome:";
            this.lbNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMorada
            // 
            this.lbMorada.AutoSize = true;
            this.lbMorada.Location = new System.Drawing.Point(44, 82);
            this.lbMorada.Name = "lbMorada";
            this.lbMorada.Size = new System.Drawing.Size(46, 13);
            this.lbMorada.TabIndex = 6;
            this.lbMorada.Text = "Morada:";
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.Location = new System.Drawing.Point(44, 61);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(27, 13);
            this.lbNif.TabIndex = 7;
            this.lbNif.Text = "NIF:";
            // 
            // lbContacto
            // 
            this.lbContacto.AutoSize = true;
            this.lbContacto.Location = new System.Drawing.Point(44, 104);
            this.lbContacto.Name = "lbContacto";
            this.lbContacto.Size = new System.Drawing.Size(53, 13);
            this.lbContacto.TabIndex = 8;
            this.lbContacto.Text = "Contacto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 20);
            this.textBox4.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(103, 138);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(197, 138);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(47, 446);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(266, 96);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(47, 206);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(266, 96);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(47, 331);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(266, 96);
            this.richTextBox3.TabIndex = 15;
            this.richTextBox3.Text = "";
            // 
            // lbCasas
            // 
            this.lbCasas.AutoSize = true;
            this.lbCasas.Location = new System.Drawing.Point(47, 190);
            this.lbCasas.Name = "lbCasas";
            this.lbCasas.Size = new System.Drawing.Size(36, 13);
            this.lbCasas.TabIndex = 16;
            this.lbCasas.Text = "Casas";
            this.lbCasas.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbArrendamentos
            // 
            this.lbArrendamentos.AutoSize = true;
            this.lbArrendamentos.Location = new System.Drawing.Point(44, 315);
            this.lbArrendamentos.Name = "lbArrendamentos";
            this.lbArrendamentos.Size = new System.Drawing.Size(78, 13);
            this.lbArrendamentos.TabIndex = 17;
            this.lbArrendamentos.Text = "Arrendamentos";
            // 
            // lbAquisições
            // 
            this.lbAquisições.AutoSize = true;
            this.lbAquisições.Location = new System.Drawing.Point(44, 430);
            this.lbAquisições.Name = "lbAquisições";
            this.lbAquisições.Size = new System.Drawing.Size(58, 13);
            this.lbAquisições.TabIndex = 18;
            this.lbAquisições.Text = "Aquisições";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 697);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.gbDetalhes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btGerirClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClientes_FormClosing);
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btGerirClientes;
        private System.Windows.Forms.TextBox tbPesquisarClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPesquisaClientes;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContacto;
        private System.Windows.Forms.GroupBox gbDetalhes;
        private System.Windows.Forms.Button btnApagar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbMorada;
        private System.Windows.Forms.Label lbNif;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbContacto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lbCasas;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbAquisições;
        private System.Windows.Forms.Label lbArrendamentos;
    }
}

