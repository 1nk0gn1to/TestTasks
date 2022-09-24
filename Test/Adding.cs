using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Adding : Form
    {
        IProductRepository repo;

        public string productName;
        public string description;
        public decimal price;
        public int id;

        public Adding(IProductRepository repo)
        {
            InitializeComponent();
            this.repo = repo;
        }
        private void Adding_Load(object sender, EventArgs e)
        {
            tbProductName.Text = productName;
            tbDescription.Text = description;
            tbPrice.Text = price.ToString();
        }

        private void Adding_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var ids = id;
                var name = tbProductName.Text;
                var descriptions = tbDescription.Text;
                var prices = Convert.ToDecimal(tbPrice.Text, System.Globalization.NumberFormatInfo.CurrentInfo);

                if (DialogResult == DialogResult.OK)
                {
                    var product = new Product() { Id = ids, ProductName = name, Info = descriptions, Price = prices };
                    repo.UpdateProduct(product);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

    }
}
