using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class CartView : Form
    {
        public CartView()
        {
            InitializeComponent();
        }

        private Control createCard(OrderItem item)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.Size = new Size(400, 200);
            //tlp.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            tlp.Dock = DockStyle.Top;

            tlp.ColumnCount = 2;
            tlp.RowCount = 1;

            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));

            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            PictureBox dp = new PictureBox();
            dp.Image = ImageAssets.placeholder;
            dp.Dock = DockStyle.Fill;
            dp.SizeMode = PictureBoxSizeMode.Zoom;
            //dp.MouseClick += (sender, e) => ProductClick(sender, e, product);

            Font font = new Font("Times New Roman", 12F);

            Label name = new Label();
            name.Text = item.Product.Description;
            name.Anchor = AnchorStyles.Left;
            name.Dock = DockStyle.None;
            name.Font = font;
            //name.MouseClick += (sender, e) => ProductClick(sender, e, product);

            Label price = new Label();
            price.Text = $"{Utils.convertToPriceString(item.Product.Price)} X {item.Quantity} = {Utils.convertToPriceString(item.TotalPrice)}";
            price.Anchor = AnchorStyles.Left;
            price.Dock = DockStyle.None;
            price.AutoSize = true;
            //price.MouseClick += (sender, e) => ProductClick(sender, e, product);

            Button del = new Button();
            del.BackgroundImage = ImageAssets.trash;
            del.Anchor = AnchorStyles.Left;
            del.BackgroundImageLayout = ImageLayout.Zoom;
            del.Size = new Size(32, 32);
            del.TextImageRelation = TextImageRelation.ImageBeforeText;

            TableLayoutPanel contentTlp = new TableLayoutPanel();
            contentTlp.ColumnCount = 1;
            contentTlp.RowCount = 3;
            contentTlp.Dock = DockStyle.Fill;

            contentTlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            contentTlp.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            contentTlp.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            contentTlp.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

            contentTlp.Controls.Add(name, 0, 0);
            contentTlp.Controls.Add(price, 0, 1);
            contentTlp.Controls.Add(del, 0, 2);

            tlp.Controls.Add(dp, 0, 0);
            tlp.Controls.Add(contentTlp, 1, 0);
            //tlp.Controls.Add(name, 1, 1);
            //tlp.Controls.Add(price, 1, 2);

            //tlp.MouseClick += (sender, e) => ProductClick(sender, e, product);

            return tlp;
        }

        private void CartView_Load(object sender, EventArgs e)
        {
            foreach(var item in Cart.getItems())
            {
                flp_items.Controls.Add(createCard(item));
            }

            lbl_total.Text = Utils.convertToPriceString(Cart.TotalBill);
        }
    }
}
