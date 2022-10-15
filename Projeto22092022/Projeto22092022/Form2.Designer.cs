namespace Projeto22092022
{
    partial class Cadastro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Idade = new System.Windows.Forms.TextBox();
            this.Matricula = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.Limpar);
            this.groupBox1.Controls.Add(this.Salvar);
            this.groupBox1.Controls.Add(this.Idade);
            this.groupBox1.Controls.Add(this.Matricula);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 359);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Aluno:";
            // 
            // Idade
            // 
            this.Idade.Location = new System.Drawing.Point(102, 148);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(100, 22);
            this.Idade.TabIndex = 5;
            // 
            // Matricula
            // 
            this.Matricula.Location = new System.Drawing.Point(101, 99);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(164, 22);
            this.Matricula.TabIndex = 4;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(102, 55);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(520, 22);
            this.Nome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrícula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(37, 288);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(172, 32);
            this.Salvar.TabIndex = 6;
            this.Salvar.Text = "Salvar Dados";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(232, 288);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(172, 32);
            this.Limpar.TabIndex = 7;
            this.Limpar.Text = "Limpar Campos";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(557, 306);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(78, 32);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 386);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.Text = "Cadastro de Aluno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Idade;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Salvar;
    }
}