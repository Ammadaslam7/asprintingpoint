namespace ASPP.Forms
{
    partial class ProductView
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.pbx_product = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_name_val = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_category_val = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_price_val = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.num_stock = new System.Windows.Forms.NumericUpDown();
            this.lbl_description = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_picCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_product)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_description, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btn_right, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_left, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbx_product, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_picCount, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 219);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_right
            // 
            this.btn_right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right.Location = new System.Drawing.Point(357, 81);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(33, 34);
            this.btn_right.TabIndex = 0;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left.Location = new System.Drawing.Point(3, 81);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(33, 34);
            this.btn_left.TabIndex = 1;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // pbx_product
            // 
            this.pbx_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_product.Image = global::ASPP.ImageAssets.placeholder;
            this.pbx_product.InitialImage = global::ASPP.ImageAssets.placeholder;
            this.pbx_product.Location = new System.Drawing.Point(42, 3);
            this.pbx_product.Name = "pbx_product";
            this.pbx_product.Size = new System.Drawing.Size(309, 191);
            this.pbx_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_product.TabIndex = 2;
            this.pbx_product.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_name, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_name_val, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_category, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_category_val, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_price, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_price_val, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_qty, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.num_stock, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 219);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(35, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(127, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Product Name:";
            // 
            // lbl_name_val
            // 
            this.lbl_name_val.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name_val.AutoSize = true;
            this.lbl_name_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_val.Location = new System.Drawing.Point(234, 18);
            this.lbl_name_val.Name = "lbl_name_val";
            this.lbl_name_val.Size = new System.Drawing.Size(122, 18);
            this.lbl_name_val.TabIndex = 1;
            this.lbl_name_val.Text = "<<Placeholder>>";
            // 
            // lbl_category
            // 
            this.lbl_category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(55, 71);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(86, 20);
            this.lbl_category.TabIndex = 2;
            this.lbl_category.Text = "Category:";
            // 
            // lbl_category_val
            // 
            this.lbl_category_val.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_category_val.AutoSize = true;
            this.lbl_category_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category_val.Location = new System.Drawing.Point(234, 72);
            this.lbl_category_val.Name = "lbl_category_val";
            this.lbl_category_val.Size = new System.Drawing.Size(122, 18);
            this.lbl_category_val.TabIndex = 3;
            this.lbl_category_val.Text = "<<Placeholder>>";
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(71, 125);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(54, 20);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_price_val
            // 
            this.lbl_price_val.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_price_val.AutoSize = true;
            this.lbl_price_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_val.Location = new System.Drawing.Point(234, 126);
            this.lbl_price_val.Name = "lbl_price_val";
            this.lbl_price_val.Size = new System.Drawing.Size(122, 18);
            this.lbl_price_val.TabIndex = 5;
            this.lbl_price_val.Text = "<<Placeholder>>";
            // 
            // lbl_qty
            // 
            this.lbl_qty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(58, 180);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(81, 20);
            this.lbl_qty.TabIndex = 6;
            this.lbl_qty.Text = "Quantity:";
            // 
            // num_stock
            // 
            this.num_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_stock.Location = new System.Drawing.Point(235, 178);
            this.num_stock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_stock.Name = "num_stock";
            this.num_stock.Size = new System.Drawing.Size(120, 24);
            this.num_stock.TabIndex = 7;
            this.num_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_stock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(146, 329);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(108, 16);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "<<Placeholder>>";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_add, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_cancel, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(403, 228);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(394, 219);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(35, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 52);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(232, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(127, 52);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_picCount
            // 
            this.lbl_picCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_picCount.AutoSize = true;
            this.lbl_picCount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_picCount.Location = new System.Drawing.Point(184, 201);
            this.lbl_picCount.Name = "lbl_picCount";
            this.lbl_picCount.Size = new System.Drawing.Size(24, 13);
            this.lbl_picCount.TabIndex = 3;
            this.lbl_picCount.Text = "1/1";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductView";
            this.Text = "ProductView";
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_product)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.PictureBox pbx_product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_name_val;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_category_val;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_price_val;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.NumericUpDown num_stock;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_picCount;
    }
}