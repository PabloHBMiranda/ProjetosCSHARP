namespace Avaliacao
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBX1 = new System.Windows.Forms.TextBox();
            this.txtBX2 = new System.Windows.Forms.TextBox();
            this.txtBX3 = new System.Windows.Forms.TextBox();
            this.cancelarVenda = new System.Windows.Forms.Button();
            this.addProduto = new System.Windows.Forms.Button();
            this.removerLista = new System.Windows.Forms.Button();
            this.fehcarVenda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListBox();
            this.listView2 = new System.Windows.Forms.ListBox();
            this.listView3 = new System.Windows.Forms.ListBox();
            this.listView4 = new System.Windows.Forms.ListBox();
            this.valorT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sub Total:";
            // 
            // txtBX1
            // 
            this.txtBX1.Location = new System.Drawing.Point(24, 53);
            this.txtBX1.Name = "txtBX1";
            this.txtBX1.Size = new System.Drawing.Size(100, 22);
            this.txtBX1.TabIndex = 4;
            this.txtBX1.TextChanged += new System.EventHandler(this.txtBX1_TextChanged);
            // 
            // txtBX2
            // 
            this.txtBX2.Location = new System.Drawing.Point(155, 54);
            this.txtBX2.Name = "txtBX2";
            this.txtBX2.Size = new System.Drawing.Size(100, 22);
            this.txtBX2.TabIndex = 5;
            this.txtBX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBX2_KeyPress);
            // 
            // txtBX3
            // 
            this.txtBX3.Location = new System.Drawing.Point(287, 56);
            this.txtBX3.Name = "txtBX3";
            this.txtBX3.Size = new System.Drawing.Size(100, 22);
            this.txtBX3.TabIndex = 6;
            this.txtBX3.TextChanged += new System.EventHandler(this.txtBX3_TextChanged);
            this.txtBX3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBX3_KeyPress);
            // 
            // cancelarVenda
            // 
            this.cancelarVenda.Location = new System.Drawing.Point(469, 110);
            this.cancelarVenda.Name = "cancelarVenda";
            this.cancelarVenda.Size = new System.Drawing.Size(133, 36);
            this.cancelarVenda.TabIndex = 8;
            this.cancelarVenda.Text = "Cancelar Venda";
            this.cancelarVenda.UseVisualStyleBackColor = true;
            this.cancelarVenda.Click += new System.EventHandler(this.cancelarVenda_Click);
            // 
            // addProduto
            // 
            this.addProduto.Location = new System.Drawing.Point(34, 110);
            this.addProduto.Name = "addProduto";
            this.addProduto.Size = new System.Drawing.Size(221, 36);
            this.addProduto.TabIndex = 9;
            this.addProduto.Text = "Adicionar produto na lista";
            this.addProduto.UseVisualStyleBackColor = true;
            this.addProduto.Click += new System.EventHandler(this.addProduto_Click);
            // 
            // removerLista
            // 
            this.removerLista.Location = new System.Drawing.Point(12, 383);
            this.removerLista.Name = "removerLista";
            this.removerLista.Size = new System.Drawing.Size(596, 33);
            this.removerLista.TabIndex = 14;
            this.removerLista.Text = "Remover um produto da lista de compras";
            this.removerLista.UseVisualStyleBackColor = true;
            this.removerLista.Click += new System.EventHandler(this.removerLista_Click);
            // 
            // fehcarVenda
            // 
            this.fehcarVenda.Location = new System.Drawing.Point(34, 449);
            this.fehcarVenda.Name = "fehcarVenda";
            this.fehcarVenda.Size = new System.Drawing.Size(154, 34);
            this.fehcarVenda.TabIndex = 15;
            this.fehcarVenda.Text = "Fechar venda";
            this.fehcarVenda.UseVisualStyleBackColor = true;
            this.fehcarVenda.Click += new System.EventHandler(this.fehcarVenda_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total a pagar:";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.AutoSize = true;
            this.txtTOTAL.Location = new System.Drawing.Point(454, 458);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(0, 16);
            this.txtTOTAL.TabIndex = 17;
            // 
            // listView1
            // 
            this.listView1.FormattingEnabled = true;
            this.listView1.ItemHeight = 16;
            this.listView1.Location = new System.Drawing.Point(34, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(119, 164);
            this.listView1.TabIndex = 18;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.FormattingEnabled = true;
            this.listView2.ItemHeight = 16;
            this.listView2.Location = new System.Drawing.Point(178, 189);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(119, 164);
            this.listView2.TabIndex = 19;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // listView3
            // 
            this.listView3.FormattingEnabled = true;
            this.listView3.ItemHeight = 16;
            this.listView3.Location = new System.Drawing.Point(318, 189);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(119, 164);
            this.listView3.TabIndex = 20;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // listView4
            // 
            this.listView4.FormattingEnabled = true;
            this.listView4.ItemHeight = 16;
            this.listView4.Location = new System.Drawing.Point(483, 189);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(119, 164);
            this.listView4.TabIndex = 21;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
            // 
            // valorT
            // 
            this.valorT.AutoSize = true;
            this.valorT.Location = new System.Drawing.Point(446, 53);
            this.valorT.Name = "valorT";
            this.valorT.Size = new System.Drawing.Size(0, 16);
            this.valorT.TabIndex = 7;
            this.valorT.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Preço Unitário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 495);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fehcarVenda);
            this.Controls.Add(this.removerLista);
            this.Controls.Add(this.addProduto);
            this.Controls.Add(this.cancelarVenda);
            this.Controls.Add(this.valorT);
            this.Controls.Add(this.txtBX3);
            this.Controls.Add(this.txtBX2);
            this.Controls.Add(this.txtBX1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBX1;
        private System.Windows.Forms.TextBox txtBX2;
        private System.Windows.Forms.TextBox txtBX3;
        private System.Windows.Forms.Button cancelarVenda;
        private System.Windows.Forms.Button addProduto;
        private System.Windows.Forms.Button removerLista;
        private System.Windows.Forms.Button fehcarVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTOTAL;
        private System.Windows.Forms.ListBox listView1;
        private System.Windows.Forms.ListBox listView2;
        private System.Windows.Forms.ListBox listView3;
        private System.Windows.Forms.ListBox listView4;
        private System.Windows.Forms.Label valorT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

