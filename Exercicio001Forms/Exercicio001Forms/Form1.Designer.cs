namespace Exercicio001Forms
{
    partial class FrmPrincipal
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
            this.Sair = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.CalcularVTotal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbFrete = new System.Windows.Forms.Label();
            this.lbVProduto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(605, 459);
            this.Sair.Margin = new System.Windows.Forms.Padding(4);
            this.Sair.Name = "Sair";
            this.Sair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sair.Size = new System.Drawing.Size(129, 71);
            this.Sair.TabIndex = 0;
            this.Sair.Text = "&Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(306, 459);
            this.Limpar.Margin = new System.Windows.Forms.Padding(4);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(141, 71);
            this.Limpar.TabIndex = 1;
            this.Limpar.Text = "&Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // CalcularVTotal
            // 
            this.CalcularVTotal.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularVTotal.Location = new System.Drawing.Point(16, 459);
            this.CalcularVTotal.Margin = new System.Windows.Forms.Padding(4);
            this.CalcularVTotal.Name = "CalcularVTotal";
            this.CalcularVTotal.Size = new System.Drawing.Size(158, 71);
            this.CalcularVTotal.TabIndex = 2;
            this.CalcularVTotal.Text = "Calcular Valor Total";
            this.CalcularVTotal.UseVisualStyleBackColor = true;
            this.CalcularVTotal.Click += new System.EventHandler(this.CalcularVTotal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.lbFrete);
            this.groupBox1.Controls.Add(this.lbVProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações de Valores:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(236, 148);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 22);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "R$ 0";
            // 
            // lbFrete
            // 
            this.lbFrete.AutoSize = true;
            this.lbFrete.Location = new System.Drawing.Point(236, 94);
            this.lbFrete.Name = "lbFrete";
            this.lbFrete.Size = new System.Drawing.Size(45, 22);
            this.lbFrete.TabIndex = 4;
            this.lbFrete.Text = "R$ 0";
            // 
            // lbVProduto
            // 
            this.lbVProduto.AutoSize = true;
            this.lbVProduto.Location = new System.Drawing.Point(236, 35);
            this.lbVProduto.Name = "lbVProduto";
            this.lbVProduto.Size = new System.Drawing.Size(45, 22);
            this.lbVProduto.TabIndex = 3;
            this.lbVProduto.Text = "R$ 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frete:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLocal);
            this.groupBox2.Controls.Add(this.cmbProdutos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione oque deseja: ";
            // 
            // cmbLocal
            // 
            this.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Items.AddRange(new object[] {
            "[ Selecione ]",
            "Anápolis",
            "Caldas Novas",
            "Faina",
            "Goiania",
            "Goiânira"});
            this.cmbLocal.Location = new System.Drawing.Point(236, 132);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(121, 30);
            this.cmbLocal.Sorted = true;
            this.cmbLocal.TabIndex = 5;
            this.cmbLocal.SelectionChangeCommitted += new System.EventHandler(this.cmbLocal_SelectionChangeCommitted);
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Items.AddRange(new object[] {
            "[ Selecione ]",
            "Fogão",
            "Freezer ",
            "Geladeira",
            "Mesa",
            "Microondas"});
            this.cmbProdutos.Location = new System.Drawing.Point(236, 63);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(121, 30);
            this.cmbProdutos.Sorted = true;
            this.cmbProdutos.TabIndex = 4;
            this.cmbProdutos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Local da entregua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Produto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalcularVTotal);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Sair);
            this.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Calcula Frete";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button CalcularVTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbFrete;
        private System.Windows.Forms.Label lbVProduto;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.ComboBox cmbLocal;
    }
}

