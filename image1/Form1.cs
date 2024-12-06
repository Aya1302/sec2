using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image1
{
    public partial class Form1 : Form
    {
        int count = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(o.FileName);
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            pictureBox1.Image = imageList1.Images[count];
        }

        private void next_Click(object sender, EventArgs e)
        {   
            if (count < 4)
            { count++; 
            } 
            pictureBox1.Image= imageList1.Images[count];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
