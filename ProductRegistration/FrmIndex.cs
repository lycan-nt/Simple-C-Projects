using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductRegistration.Models;


namespace ProductRegistration
{
    public partial class FrmProductReg : Form
    {
        public FrmProductReg()
        {
            InitializeComponent();
        }

        private void BtnRecord_Click(object sender, EventArgs e)
        {

            using (var db = new Context())
            {

                string nameProduct = TxbName.Text;

                string BarCodProduct = TxbBarCod.Text;

                String ProviderProduct = TxbProvider.Text;


                if (string.IsNullOrEmpty(nameProduct) == false &&
                    string.IsNullOrEmpty(BarCodProduct) == false &&
                    string.IsNullOrEmpty(ProviderProduct) == false)
                {

                    var Product = new Product { Name = nameProduct, BarCod = BarCodProduct, Provider = ProviderProduct };

                    db.Product.Add(Product);

                    db.SaveChanges();

                    List<Product> products = db.Product.OrderByDescending(t => t.ID).ToList();

                    GridProduct.DataSource = products;

                    TxbName.Text = "";
                    TxbBarCod.Text = "";
                    TxbProvider.Text = "";
                 

                }

            }

        }
    }
}
