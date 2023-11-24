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
    public partial class ProductCatalog : Form
    {
        public ProductCatalog()
        {
            InitializeComponent();
        }

        private Control createCard(Product product)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.Size = new Size(210, 190);

            tlp.ColumnCount = 3;
            tlp.RowCount = 3;

            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));

            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 10));

            PictureBox dp = new PictureBox();
            dp.Image = ImageAssets.placeholder;
            dp.Dock = DockStyle.Fill;
            dp.SizeMode = PictureBoxSizeMode.Zoom;
            dp.MouseClick += (sender, e) => ProductClick(sender, e, product);

            Font font = new Font("Times New Roman", 12F);

            Label description = new Label();
            description.Text = product.Description;
            description.Anchor = AnchorStyles.None;
            description.Dock = DockStyle.None;
            description.Font = font;
            description.MouseClick += (sender, e) => ProductClick(sender, e, product);

            Label price = new Label();
            price.Text = Utils.convertToPriceString(product.Price);
            price.Anchor = AnchorStyles.None;
            price.Dock = DockStyle.None;
            price.MouseClick += (sender, e) => ProductClick(sender, e, product);

            tlp.Controls.Add(dp, 1, 0);
            tlp.Controls.Add(description, 1, 1);
            tlp.Controls.Add(price, 1, 2);

            tlp.MouseClick += (sender, e) => ProductClick(sender, e, product);

            return tlp;
        }

        private void ProductCatalog_Load(object sender, EventArgs e)
        {
            List<Product> products = ProductDL.getProducts();

            //foreach(Product product in products)
            //{
            //    flp_items.Controls.Add(createCard(product));
            //}

            for (int i = 0; i < 10; i++)
                flp_items.Controls.Add(createCard(products[0]));
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductClick(object sender, MouseEventArgs e, Product product)
        {
            Form frm = new ProductView(product);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
