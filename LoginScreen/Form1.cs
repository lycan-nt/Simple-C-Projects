using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LoginScreen
{
    public partial class FrmLogin : Form
    {

        Thread nt; 


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //Validetes if the login and password entered is the same as login: Master
            //and password 1, the returns a message and the close the login form and initializes the second form
            if ((TxbLogin.Text == "Master") && (TxbPassword.Text == "1") )
            {

                MessageBox.Show("Welcome to the system!");

                this.Close();

                nt = new Thread(NewForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

                
            }
            //If the conditions is not met issues an erro message
            else
            {

                MessageBox.Show("Invalid login or password.");

            }

        

        }

        private void NewForm()
        {

            Application.Run(new Form2());

        }
    }
}
