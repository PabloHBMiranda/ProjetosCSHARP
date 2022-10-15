



namespace BancoDados

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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BancoDados.DataSet1();
            this.informacoesTableAdapter = new BancoDados.DataSet1TableAdapters.informacoesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "N1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mátricula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "N2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "MÉDIA:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(94, 17);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(544, 22);
            this.txtMatricula.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(544, 22);
            this.txtNome.TabIndex = 9;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(94, 103);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(147, 22);
            this.txtN1.TabIndex = 10;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(280, 104);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(147, 22);
            this.txtN2.TabIndex = 11;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(491, 107);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(147, 22);
            this.txtMedia.TabIndex = 12;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(659, 21);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(129, 23);
            this.Salvar.TabIndex = 13;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(659, 58);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(129, 23);
            this.Limpar.TabIndex = 14;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(659, 106);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(129, 23);
            this.Sair.TabIndex = 15;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.n1DataGridViewTextBoxColumn,
            this.n2DataGridViewTextBoxColumn,
            this.mediaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.informacoesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 285);
            this.dataGridView1.TabIndex = 16;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "matricula";
            this.matriculaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.Width = 125;
            // 
            // n1DataGridViewTextBoxColumn
            // 
            this.n1DataGridViewTextBoxColumn.DataPropertyName = "n1";
            this.n1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.n1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.n1DataGridViewTextBoxColumn.Name = "n1DataGridViewTextBoxColumn";
            this.n1DataGridViewTextBoxColumn.Width = 125;
            // 
            // n2DataGridViewTextBoxColumn
            // 
            this.n2DataGridViewTextBoxColumn.DataPropertyName = "n2";
            this.n2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.n2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.n2DataGridViewTextBoxColumn.Name = "n2DataGridViewTextBoxColumn";
            this.n2DataGridViewTextBoxColumn.Width = 125;
            // 
            // mediaDataGridViewTextBoxColumn
            // 
            this.mediaDataGridViewTextBoxColumn.DataPropertyName = "media";
            this.mediaDataGridViewTextBoxColumn.HeaderText = "media";
            this.mediaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mediaDataGridViewTextBoxColumn.Name = "mediaDataGridViewTextBoxColumn";
            this.mediaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // informacoesBindingSource
            // 
            this.informacoesBindingSource.DataMember = "informacoes";
            this.informacoesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informacoesTableAdapter
            // 
            this.informacoesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource informacoesBindingSource;
        private DataSet1TableAdapters.informacoesTableAdapter informacoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

