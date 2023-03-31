using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadai.F
{
    public partial class omikuji : Form
    {
        public omikuji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random cRandom = new System.Random();
            int Rnd = cRandom.Next(100);
            if (Rnd >= 90)
            {
                this.pictureBox3.Image = Image.FromFile("dai.gif");
            }
            else if (Rnd >= 70)
            {
                this.pictureBox3.Image = Image.FromFile("sue.gif");
            }             
            else if (Rnd >= 20)
            {
                this.pictureBox3.Image = Image.FromFile("kichi.gif");
            }
            else
            {
                this.pictureBox3.Image = Image.FromFile("kyo.gif");

            };
            this.pictureBox3.Visible = true; 
        }
    }
}
