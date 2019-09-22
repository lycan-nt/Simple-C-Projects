using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class FrmTimer : Form
    {

        int Time = 0;
        int Minute = 0;
        int Second = 0;

        public FrmTimer()
        {
            InitializeComponent();
        }

        private void FrmTimer_Load(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;

            Time = Convert.ToInt16(TxbTime.Text);

            if (Time >= 60)
            {

                Minute = Time / 60;
                Second = Time % 60;

            }
            else
            {

                Minute = 0;
                Second = Time;

            }

            LblTime.Text = "0" + Minute + ":" + Second;

            timer1.Enabled = true;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            Second--;

            if (Minute > 0)
            {

                if (Second < 0)
                {

                    Second = 59;
                    Minute--;
                }

                LblTime.Text = "0" + Minute + ":" + Second;

            }

            Second--;

            if (Minute == 0 && Second == 0)
            {

                timer1.Enabled = false;
                pictureBox1.Visible = true;

            }

        }
    }
}