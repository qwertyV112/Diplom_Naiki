using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class Form1 : Form
    {
        public Graphics image;
        public Pen pen;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ellipse K = new Ellipse(image, pictureBox1.Size.Height, pictureBox1.Size.Width);
            FormsSetting(); 
            
            
          //  image.DrawEllipse(p, 10, 10, 40, 40); 
        }
        private void FormsSetting(){
            image = pictureBox1.CreateGraphics();
           // Pen p = new Pen(Color.Red);
            //image.DrawLine(p, 10, 10, 51, 51);
            //image.DrawLine(p, 10, 10, 51, 51);
            //image.DrawEllipse(p, 10, 10, 280, 280);
        }
        public Color Colr()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                return colorDialog1.Color;
            }
            return Color.Black;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkColor = Colr();
            linkLabel1.Text = linkLabel1.LinkColor.ToString();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkColor = Colr();
            linkLabel2.Text = linkLabel2.LinkColor.ToString();
        }
    }
}
