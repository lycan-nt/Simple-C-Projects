using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class FrmCachier : Form
    {

        string [] codProd   = new string[6];
        string [] nameProd  = new string[6];
        decimal[] valueProd = new decimal[6];
        decimal   totSum;

        public FrmCachier()
        {
            InitializeComponent();
        }

        private void FrmCachier_Load(object sender, EventArgs e)
        {

            loadProducts();
            totSum = 0;

        }

        //Method to load the products and start the variables
        private void loadProducts ()
        {

            codProd[1] = "1";
            codProd[2] = "2";
            codProd[3] = "3";
            codProd[4] = "4";
            codProd[5] = "5";

            nameProd[1] = "Coca-Cola";
            nameProd[2] = "Chocolate";
            nameProd[3] = "MotorCycle";
            nameProd[4] = "Car";
            nameProd[5] = "Katana";

            valueProd[1] = 4.50M;
            valueProd[2] = 2.20M;
            valueProd[3] = 12.000M;
            valueProd[4] = 20.000M;
            valueProd[5] = 3.000M;



        

        }

        private void LblProCod_Click(object sender, EventArgs e)
        {

        }

        private void TxbCod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
