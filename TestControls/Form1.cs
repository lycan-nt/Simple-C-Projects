using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDeControles
{
    public partial class FrmControles : Form
    {
        public FrmControles()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            
            string NameUser, City;
            DateTime DateBirth;
            bool Sex1, Sex2;
            int RegNumber;

            
            //Assigning Form Values ​​to Variables
            NameUser = TxbName.Text;
            DateBirth = dateTimePicker1.Value;
            Sex1 = radioButton1.Checked;
            Sex2 = radioButton2.Checked;
            City = CbCity.Text;
            RegNumber = Convert.ToInt32(TxbRegNum.Text);

            //Displays filled values ​​on screen
            MessageBox.Show("Nome: " + NameUser);
            MessageBox.Show("Data de nascimeno: " + DateBirth);
            MessageBox.Show("Cidade: " + City);

            //Check which radiobuton is marked and display the result on screen
            if (Sex1 == true)
                {


                MessageBox.Show("O genero é: Masculino" );

                }
            else if (Sex2 == true)
            {

                MessageBox.Show("O genero é: Feiminino");

            }
            else
            {

                MessageBox.Show("Sex Required");

            }

            MessageBox.Show("O numero de registro é: " + Convert.ToString(RegNumber));

        }
    }
}
