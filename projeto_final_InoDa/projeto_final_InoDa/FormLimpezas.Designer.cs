﻿namespace projeto_final_InoDa
{
    partial class formLimpezas
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
            this.lbBase = new System.Windows.Forms.Label();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.tbLimpeza = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbServiço = new System.Windows.Forms.Label();
            this.lbVUnitario = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.cbServiço = new System.Windows.Forms.ComboBox();
            this.nupQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.dtpFatura = new System.Windows.Forms.DateTimePicker();
            this.gbDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Location = new System.Drawing.Point(46, 38);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(31, 13);
            this.lbBase.TabIndex = 0;
            this.lbBase.Text = "Base";
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.btnInserir);
            this.gbDetalhes.Controls.Add(this.nupQuantidade);
            this.gbDetalhes.Controls.Add(this.cbServiço);
            this.gbDetalhes.Controls.Add(this.lbQuantidade);
            this.gbDetalhes.Controls.Add(this.lbVUnitario);
            this.gbDetalhes.Controls.Add(this.lbServiço);
            this.gbDetalhes.Controls.Add(this.tbLimpeza);
            this.gbDetalhes.Location = new System.Drawing.Point(357, 68);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(590, 501);
            this.gbDetalhes.TabIndex = 1;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Detalhes da Limpeza";
            // 
            // tbLimpeza
            // 
            this.tbLimpeza.Location = new System.Drawing.Point(6, 125);
            this.tbLimpeza.Multiline = true;
            this.tbLimpeza.Name = "tbLimpeza";
            this.tbLimpeza.Size = new System.Drawing.Size(578, 370);
            this.tbLimpeza.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 445);
            this.textBox1.TabIndex = 2;
            // 
            // lbServiço
            // 
            this.lbServiço.AutoSize = true;
            this.lbServiço.Location = new System.Drawing.Point(29, 41);
            this.lbServiço.Name = "lbServiço";
            this.lbServiço.Size = new System.Drawing.Size(46, 13);
            this.lbServiço.TabIndex = 4;
            this.lbServiço.Text = "Serviço:";
            // 
            // lbVUnitario
            // 
            this.lbVUnitario.AutoSize = true;
            this.lbVUnitario.Location = new System.Drawing.Point(29, 77);
            this.lbVUnitario.Name = "lbVUnitario";
            this.lbVUnitario.Size = new System.Drawing.Size(73, 13);
            this.lbVUnitario.TabIndex = 5;
            this.lbVUnitario.Text = "Valor Unitário:";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(251, 44);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lbQuantidade.TabIndex = 6;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // cbServiço
            // 
            this.cbServiço.FormattingEnabled = true;
            this.cbServiço.Location = new System.Drawing.Point(81, 41);
            this.cbServiço.Name = "cbServiço";
            this.cbServiço.Size = new System.Drawing.Size(164, 21);
            this.cbServiço.TabIndex = 7;
            // 
            // nupQuantidade
            // 
            this.nupQuantidade.Location = new System.Drawing.Point(322, 42);
            this.nupQuantidade.Name = "nupQuantidade";
            this.nupQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nupQuantidade.TabIndex = 8;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(458, 39);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 23);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnEmitir
            // 
            this.btnEmitir.Location = new System.Drawing.Point(49, 520);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(302, 23);
            this.btnEmitir.TabIndex = 3;
            this.btnEmitir.Text = "Emitir Fatura";
            this.btnEmitir.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(276, 549);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 15;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            // 
            // dtpFatura
            // 
            this.dtpFatura.Location = new System.Drawing.Point(47, 549);
            this.dtpFatura.Name = "dtpFatura";
            this.dtpFatura.Size = new System.Drawing.Size(223, 20);
            this.dtpFatura.TabIndex = 16;
            // 
            // formLimpezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 636);
            this.Controls.Add(this.dtpFatura);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnEmitir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbDetalhes);
            this.Controls.Add(this.lbBase);
            this.Name = "formLimpezas";
            this.Text = "Limpezas";
            this.Load += new System.EventHandler(this.formLimpezas_Load);
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.GroupBox gbDetalhes;
        private System.Windows.Forms.TextBox tbLimpeza;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbVUnitario;
        private System.Windows.Forms.Label lbServiço;
        private System.Windows.Forms.ComboBox cbServiço;
        private System.Windows.Forms.NumericUpDown nupQuantidade;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.DateTimePicker dtpFatura;
    }
}