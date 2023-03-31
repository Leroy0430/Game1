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
    public partial class slot : Form
    {
        public struct SlotCh
        {
            public bool Status;
            public int CurrentImg;
            public PictureBox PicBox;
        }
        public SlotCh[] SlotNo = new SlotCh[3];
        public Image[] ImgTbl = new Image[7];
        public slot()
        {
            InitializeComponent();
            ImgTbl[0] = Image.FromFile("fruit1.gif");
            ImgTbl[1] = Image.FromFile("fruit2.gif");
            ImgTbl[2] = Image.FromFile("fruit3.gif");
            ImgTbl[3] = Image.FromFile("fruit4.gif");
            ImgTbl[4] = Image.FromFile("fruit5.gif");
            ImgTbl[5] = Image.FromFile("fruit6.gif");
            ImgTbl[6] = Image.FromFile("fruit7.gif");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < SlotNo.Length; i++)
            {
                SlotNo[i].Status = true;
                SlotNo[i].CurrentImg = i;
            }
            SlotNo[0].PicBox = this.pictureBox2;
            SlotNo[1].PicBox = this.pictureBox3;
            SlotNo[2].PicBox = this.pictureBox4;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Round_stop(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Round_stop(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Round_stop(2);
        }
        public void Round_stop(int ch)
        {
            SlotNo[ch].Status = false;
            if (SlotNo[0].Status == false && SlotNo[1].Status == false && SlotNo[2].Status == false)
            {
                timer1.Stop();
                if (SlotNo[0].CurrentImg == SlotNo[1].CurrentImg && SlotNo[0].CurrentImg == SlotNo[2].CurrentImg)
                {
                    MessageBox.Show("やったね！", "結果");
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < SlotNo.Length; i++)
            {
                if (SlotNo[i].Status == true)
                {
                    SlotNo[i].CurrentImg = (SlotNo[i].CurrentImg + 1) % ImgTbl.Length;
                    SlotNo[i].PicBox.Image = ImgTbl[SlotNo[i].CurrentImg];
                }
            }
        }
    }
}
    
