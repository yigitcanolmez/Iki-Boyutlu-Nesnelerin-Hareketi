using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İki_Boyutlu_Nesnelerin_Hareketi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox3.Left += 18;
            pictureBox4.Left += 20;
  
            if(pictureBox3.Left>=770)
            {
                timer1.Stop();
                timer2.Start();
            } 
            if(pictureBox4.Left>=770)
            {
                timer1.Stop();
                timer2.Start();
            } 
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Top += 12;
            pictureBox4.Top += 10;
            if(pictureBox3.Top>=490 )
            {
                timer2.Stop();
                pictureBox3.Visible = false ;

            }

            if (pictureBox4.Top>=490 )
            {
                timer2.Stop();
                pictureBox4.Visible = false;
            } 
            
        }
    }
}
