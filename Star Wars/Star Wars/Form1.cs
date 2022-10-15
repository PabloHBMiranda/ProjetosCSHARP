using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Wars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Personagens_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picPrincipal.AllowDrop = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(pictureBox1.Image,DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.DoDragDrop(pictureBox3.Image, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.DoDragDrop(pictureBox4.Image, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void picPrincipal_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void picPrincipal_DragDrop(object sender, DragEventArgs e)
        {
            picPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPrincipal.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
