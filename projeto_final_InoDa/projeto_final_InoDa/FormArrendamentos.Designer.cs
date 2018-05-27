namespace projeto_final_InoDa
{
    partial class FormArrendamentos
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lbCasa = new System.Windows.Forms.Label();
            this.txtbCasa = new System.Windows.Forms.TextBox();
            this.dtpContrato = new System.Windows.Forms.DateTimePicker();
            this.lbContrato = new System.Windows.Forms.Label();
            this.lbDuração = new System.Windows.Forms.Label();
            this.nupDuração = new System.Windows.Forms.NumericUpDown();
            this.cbRenovavel = new System.Windows.Forms.CheckBox();
            this.lbArrendatário = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbArrendatário = new System.Windows.Forms.ComboBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nupDuração)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(44, 367);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(304, 23);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(463, 338);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(200, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lbCasa
            // 
            this.lbCasa.AutoSize = true;
            this.lbCasa.Location = new System.Drawing.Point(41, 44);
            this.lbCasa.Name = "lbCasa";
            this.lbCasa.Size = new System.Drawing.Size(37, 13);
            this.lbCasa.TabIndex = 2;
            this.lbCasa.Text = "Casa: ";
            this.lbCasa.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbCasa
            // 
            this.txtbCasa.Location = new System.Drawing.Point(44, 96);
            this.txtbCasa.Multiline = true;
            this.txtbCasa.Name = "txtbCasa";
            this.txtbCasa.Size = new System.Drawing.Size(304, 265);
            this.txtbCasa.TabIndex = 3;
            // 
            // dtpContrato
            // 
            this.dtpContrato.Location = new System.Drawing.Point(463, 137);
            this.dtpContrato.Name = "dtpContrato";
            this.dtpContrato.Size = new System.Drawing.Size(200, 20);
            this.dtpContrato.TabIndex = 4;
            // 
            // lbContrato
            // 
            this.lbContrato.AutoSize = true;
            this.lbContrato.Location = new System.Drawing.Point(460, 121);
            this.lbContrato.Name = "lbContrato";
            this.lbContrato.Size = new System.Drawing.Size(90, 13);
            this.lbContrato.TabIndex = 5;
            this.lbContrato.Text = "Inicio do Contrato";
            // 
            // lbDuração
            // 
            this.lbDuração.AutoSize = true;
            this.lbDuração.Location = new System.Drawing.Point(460, 169);
            this.lbDuração.Name = "lbDuração";
            this.lbDuração.Size = new System.Drawing.Size(48, 13);
            this.lbDuração.TabIndex = 6;
            this.lbDuração.Text = "Duração";
            // 
            // nupDuração
            // 
            this.nupDuração.Location = new System.Drawing.Point(463, 185);
            this.nupDuração.Name = "nupDuração";
            this.nupDuração.Size = new System.Drawing.Size(200, 20);
            this.nupDuração.TabIndex = 8;
            // 
            // cbRenovavel
            // 
            this.cbRenovavel.AutoSize = true;
            this.cbRenovavel.Location = new System.Drawing.Point(463, 222);
            this.cbRenovavel.Name = "cbRenovavel";
            this.cbRenovavel.Size = new System.Drawing.Size(78, 17);
            this.cbRenovavel.TabIndex = 9;
            this.cbRenovavel.Text = "Renovavel";
            this.cbRenovavel.UseVisualStyleBackColor = true;
            // 
            // lbArrendatário
            // 
            this.lbArrendatário.AutoSize = true;
            this.lbArrendatário.Location = new System.Drawing.Point(460, 266);
            this.lbArrendatário.Name = "lbArrendatário";
            this.lbArrendatário.Size = new System.Drawing.Size(64, 13);
            this.lbArrendatário.TabIndex = 10;
            this.lbArrendatário.Text = "Arrendatário";
            // 
            // cbArrendatário
            // 
            this.cbArrendatário.FormattingEnabled = true;
            this.cbArrendatário.Location = new System.Drawing.Point(463, 282);
            this.cbArrendatário.Name = "cbArrendatário";
            this.cbArrendatário.Size = new System.Drawing.Size(200, 21);
            this.cbArrendatário.TabIndex = 11;
            // 
            // FormArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbArrendatário);
            this.Controls.Add(this.lbArrendatário);
            this.Controls.Add(this.cbRenovavel);
            this.Controls.Add(this.nupDuração);
            this.Controls.Add(this.lbDuração);
            this.Controls.Add(this.lbContrato);
            this.Controls.Add(this.dtpContrato);
            this.Controls.Add(this.txtbCasa);
            this.Controls.Add(this.lbCasa);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnRemover);
            this.Name = "FormArrendamentos";
            this.Text = "FormArrendamentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupDuração)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lbCasa;
        private System.Windows.Forms.TextBox txtbCasa;
        private System.Windows.Forms.DateTimePicker dtpContrato;
        private System.Windows.Forms.Label lbContrato;
        private System.Windows.Forms.Label lbDuração;
        private System.Windows.Forms.NumericUpDown nupDuração;
        private System.Windows.Forms.CheckBox cbRenovavel;
        private System.Windows.Forms.Label lbArrendatário;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbArrendatário;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}