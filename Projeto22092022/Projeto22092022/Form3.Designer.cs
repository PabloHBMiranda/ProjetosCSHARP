namespace Projeto22092022
{
    partial class Listagem
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
            this.Selecione = new System.Windows.Forms.ComboBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Idade = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Idade);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.Selecione);
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alunos Cadastrados:";
            // 
            // Selecione
            // 
            this.Selecione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Selecione.FormattingEnabled = true;
            this.Selecione.Location = new System.Drawing.Point(192, 33);
            this.Selecione.Name = "Selecione";
            this.Selecione.Size = new System.Drawing.Size(217, 24);
            this.Selecione.TabIndex = 7;
            this.Selecione.SelectedIndexChanged += new System.EventHandler(this.Selecione_SelectedIndexChanged);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(577, 245);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(93, 23);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma Matrícula:";
            // 
            // Nome
            // 
            this.Nome.Enabled = false;
            this.Nome.Location = new System.Drawing.Point(192, 90);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(459, 22);
            this.Nome.TabIndex = 9;
            // 
            // Idade
            // 
            this.Idade.Enabled = false;
            this.Idade.Location = new System.Drawing.Point(193, 145);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(72, 22);
            this.Idade.TabIndex = 10;
            // 
            // Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 291);
            this.Controls.Add(this.groupBox1);
            this.Name = "Listagem";
            this.Text = "Listagem de Alunos";
            this.Enter += new System.EventHandler(this.Listagem_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Selecione;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Idade;
        private System.Windows.Forms.TextBox Nome;
    }
}