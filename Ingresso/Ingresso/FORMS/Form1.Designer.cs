namespace Ingresso
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oláIngresserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbQueen = new System.Windows.Forms.PictureBox();
            this.pbCorra = new System.Windows.Forms.PictureBox();
            this.pbFormes = new System.Windows.Forms.PictureBox();
            this.pbVingadores = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVingadores)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oláIngresserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oláIngresserToolStripMenuItem
            // 
            this.oláIngresserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarContaToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.oláIngresserToolStripMenuItem.Name = "oláIngresserToolStripMenuItem";
            this.oláIngresserToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.oláIngresserToolStripMenuItem.Text = "Olá, Ingresser";
            // 
            // criarContaToolStripMenuItem
            // 
            this.criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            this.criarContaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.criarContaToolStripMenuItem.Text = "Criar Conta";
            this.criarContaToolStripMenuItem.Click += new System.EventHandler(this.criarContaToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pbQueen);
            this.panel1.Controls.Add(this.pbCorra);
            this.panel1.Controls.Add(this.pbFormes);
            this.panel1.Controls.Add(this.pbVingadores);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 559);
            this.panel1.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(191, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(202, 22);
            this.txtUser.TabIndex = 12;
            this.txtUser.Text = "Visitante";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Ingresso.Properties.Resources.ingresso1;
            this.pictureBox6.Location = new System.Drawing.Point(218, 90);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(146, 414);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pbQueen
            // 
            this.pbQueen.Image = global::Ingresso.Properties.Resources.queen;
            this.pbQueen.Location = new System.Drawing.Point(399, 295);
            this.pbQueen.Name = "pbQueen";
            this.pbQueen.Size = new System.Drawing.Size(179, 261);
            this.pbQueen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQueen.TabIndex = 10;
            this.pbQueen.TabStop = false;
            // 
            // pbCorra
            // 
            this.pbCorra.Image = global::Ingresso.Properties.Resources.corra;
            this.pbCorra.Location = new System.Drawing.Point(6, 296);
            this.pbCorra.Name = "pbCorra";
            this.pbCorra.Size = new System.Drawing.Size(179, 260);
            this.pbCorra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCorra.TabIndex = 9;
            this.pbCorra.TabStop = false;
            // 
            // pbFormes
            // 
            this.pbFormes.Image = global::Ingresso.Properties.Resources.transformes;
            this.pbFormes.Location = new System.Drawing.Point(399, 20);
            this.pbFormes.Name = "pbFormes";
            this.pbFormes.Size = new System.Drawing.Size(179, 260);
            this.pbFormes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormes.TabIndex = 8;
            this.pbFormes.TabStop = false;
            // 
            // pbVingadores
            // 
            this.pbVingadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbVingadores.Image = global::Ingresso.Properties.Resources.vingadores;
            this.pbVingadores.Location = new System.Drawing.Point(6, 21);
            this.pbVingadores.Name = "pbVingadores";
            this.pbVingadores.Size = new System.Drawing.Size(179, 260);
            this.pbVingadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVingadores.TabIndex = 7;
            this.pbVingadores.TabStop = false;
            this.pbVingadores.Click += new System.EventHandler(this.pbVingadores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartaz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVingadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oláIngresserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pbQueen;
        private System.Windows.Forms.PictureBox pbCorra;
        private System.Windows.Forms.PictureBox pbFormes;
        private System.Windows.Forms.PictureBox pbVingadores;
        private System.Windows.Forms.Panel panel1;
    }
}