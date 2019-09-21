using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if ((TxbLogin.Text == "Master") && (TxbPassword.Text == "1") )
            {

                MessageBox.Show("Welcome to the system!");

            }
            else
            {

                MessageBox.Show("Invalid login or password.");

            }

        }
    }
}
