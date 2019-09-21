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

            //convert result to text and display in result edit
            TxbR.Text = Convert.ToString(ResultSum);

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

            //Cleaning up the edits
            TxbN1.Clear();
            TxbN2.Clear();
            TxbR.Clear();

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {

            
            float N1, N2, ResultSub;

            //Converts the text of the edits and passes to the variables
            N1 = Convert.ToInt16(TxbN1.Text);
            N2 = Convert.ToInt16(TxbN2.Text);

            //Records the subtraction of N1 and N2 in the result variable
            ResultSub = N1 - N2;

            //convert result to text and display in result edit
            TxbR.Text = Convert.ToString(ResultSub);

        }

        private void BtnMul_Click(object sender, EventArgs e)
        {

            float N1, N2, ResultMult;

            //Converts the text of the edits and passes to the variables
            N1 = Convert.ToInt16(TxbN1.Text);
            N2 = Convert.ToInt16(TxbN2.Text);

            //Records the multiplication of N1 and N2 in the result variable
            ResultMult = N1 * N2;

            //Convert result to text and display in result edit
            TxbR.Text = Convert.ToString(ResultMult);

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {

            float N1, N2, ResultDiv;

            //Convert the text of the edits and passes to the variables
            N1 = Convert.ToInt16(TxbN1.Text);
            N2 = Convert.ToInt16(TxbN2.Text);

            //Records the division of N1 and N2 in the result variable
            ResultDiv = N1 / N2;

            //Convert result to text and display in result edit
            TxbR.Text = Convert.ToString(ResultDiv);

        }
    }
}
