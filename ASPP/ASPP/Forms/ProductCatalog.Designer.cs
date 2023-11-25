namespace ASPP.Forms
{
    partial class ProductCatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flp_items = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.pbx_user = new System.Windows.Forms.PictureBox();
            this.pbx_cart = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flp_items, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flp_items
            // 
            this.flp_items.AutoScroll = true;
            this.flp_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_items.Location = new System.Drawing.Point(3, 78);
            this.flp_items.Name = "flp_items";
            this.flp_items.Size = new System.Drawing.Size(794, 369);
            this.flp_items.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel2.Controls.Add(this.pbx_logo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_search, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbx_user, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbx_cart, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 69);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(122, 11);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(549, 47);
            this.txt_search.TabIndex = 1;
            // 
            // pbx_logo
            // 
            this.pbx_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_logo.Image = global::ASPP.ImageAssets.logo_zoomed;
            this.pbx_logo.Location = new System.Drawing.Point(3, 3);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(113, 63);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 0;
            this.pbx_logo.TabStop = false;
            // 
            // pbx_user
            // 
            this.pbx_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_user.Image = global::ASPP.ImageAssets.user;
            this.pbx_user.Location = new System.Drawing.Point(677, 3);
            this.pbx_user.Name = "pbx_user";
            this.pbx_user.Size = new System.Drawing.Size(53, 63);
            this.pbx_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_user.TabIndex = 2;
            this.pbx_user.TabStop = false;
            // 
            // pbx_cart
            // 
            this.pbx_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_cart.Image = global::ASPP.ImageAssets.cart;
            this.pbx_cart.Location = new System.Drawing.Point(736, 3);
            this.pbx_cart.Name = "pbx_cart";
            this.pbx_cart.Size = new System.Drawing.Size(55, 63);
            this.pbx_cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_cart.TabIndex = 3;
            this.pbx_cart.TabStop = false;
            this.pbx_cart.Click += new System.EventHandler(this.pbx_cart_Click);
            // 
            // ProductCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductCatalog";
            this.Text = "AS Printing Point - Product Catalog";
            this.Load += new System.EventHandler(this.ProductCatalog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flp_items;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox pbx_user;
        private System.Windows.Forms.PictureBox pbx_cart;
    }
}

