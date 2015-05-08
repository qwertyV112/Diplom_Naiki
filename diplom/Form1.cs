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

            
            
          //  image.DrawEllipse(p, 10, 10, 40, 40); 
        }
        private void FormsSetting(){
            image = pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.Red);
        }
        private void Ellipse()
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
