using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASPP.Core;
using ASPP.DL;

namespace ASPP.Forms
{
    public partial class ProductView : Form
    {
        private Product product;
        public ProductView(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            lbl_name_val.Text = product.Name;
            lbl_category_val.Text = product.Category.Name;
            lbl_price_val.Text = Utils.convertToPriceString(product.Price);
            num_stock.Maximum = product.Stock;
            lbl_description.Text = product.Description;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Cart.addItem(product, (int)num_stock.Value);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
