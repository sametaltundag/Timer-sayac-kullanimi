using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 1)
            {
                this.BackColor = Color.Red;
            }
            if (sayac == 30)
            {
                this.BackColor = Color.Yellow;
            }
            if (sayac == 40)
            {
                this.BackColor = Color.Green;
            }
            if (sayac == 70)
            {
                sayac = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            timer1.Start();
        }

        //INSTAGRAM ==>> samet_altundag63
        //INSTAGRAM ==>> samethecode
    }
}
