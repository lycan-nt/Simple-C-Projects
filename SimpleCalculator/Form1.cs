using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class FrmlCalculator : Form
    {
        public FrmlCalculator()
        {
            InitializeComponent();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {


            float N1, N2, ResultSum;

            
            //Converts the text of the edits and passes to the variables
            N1 = Convert.ToInt16(TxbN1.Text);
            N2 = Convert.ToInt16(TxbN2.Text);

            
            //records the sum of N1 and N2 in the result variable
            ResultSum = N1 + N2;

        }
    }
}
