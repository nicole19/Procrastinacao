using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Time : Form
    {
        private int tempo = 3;
        String text;

        public Time(String text)
        {
            InitializeComponent();
            this.text = text;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(tempo == 0)
            {
                timer1.Stop();
                lblTimer.Text = text;
            }
            if (tempo >= 1)
            {
                lblTimer.Text += tempo + "..   ";
                tempo--;
            }
        }
    }
}
