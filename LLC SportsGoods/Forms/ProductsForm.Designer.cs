namespace LLC_SportsGoods.Forms
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlQuantityInStock = new System.Windows.Forms.Panel();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pnlInfoProduct = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbManufacturers = new System.Windows.Forms.ComboBox();
            this.lblManufacturers = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.btnFilterReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.cmsProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.rbDescending = new System.Windows.Forms.RadioButton();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlQuantityInStock.SuspendLayout();
            this.pnlInfoProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Controls.Add(this.lblName);
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1063, 132);
            this.pnlTop.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(891, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 36);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(120, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(208, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ООО Спортивные товары";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(102, 106);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.pnlQuantityInStock);
            this.panel1.Controls.Add(this.pnlInfoProduct);
            this.panel1.Controls.Add(this.pbProductImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 582);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 273);
            this.panel1.TabIndex = 2;
            // 
            // pnlQuantityInStock
            // 
            this.pnlQuantityInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuantityInStock.Controls.Add(this.tbQuantity);
            this.pnlQuantityInStock.Controls.Add(this.lblQuantity);
            this.pnlQuantityInStock.Location = new System.Drawing.Point(844, 65);
            this.pnlQuantityInStock.Name = "pnlQuantityInStock";
            this.pnlQuantityInStock.Size = new System.Drawing.Size(192, 145);
            this.pnlQuantityInStock.TabIndex = 4;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(57, 55);
            this.tbQuantity.MaxLength = 50;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.ReadOnly = true;
            this.tbQuantity.Size = new System.Drawing.Size(73, 30);
            this.tbQuantity.TabIndex = 13;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(7, 12);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(177, 23);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "Количество на складе";
            // 
            // pnlInfoProduct
            // 
            this.pnlInfoProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoProduct.Controls.Add(this.tbPrice);
            this.pnlInfoProduct.Controls.Add(this.lblPrice);
            this.pnlInfoProduct.Controls.Add(this.tbManufacturer);
            this.pnlInfoProduct.Controls.Add(this.lblManufacturer);
            this.pnlInfoProduct.Controls.Add(this.rtbDescription);
            this.pnlInfoProduct.Controls.Add(this.lblDescription);
            this.pnlInfoProduct.Controls.Add(this.tbTitle);
            this.pnlInfoProduct.Controls.Add(this.lblTitle);
            this.pnlInfoProduct.Location = new System.Drawing.Point(279, 14);
            this.pnlInfoProduct.Name = "pnlInfoProduct";
            this.pnlInfoProduct.Size = new System.Drawing.Size(545, 247);
            this.pnlInfoProduct.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(214, 212);
            this.tbPrice.MaxLength = 50;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(239, 30);
            this.tbPrice.TabIndex = 12;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 212);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 23);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Цена";
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Location = new System.Drawing.Point(214, 172);
            this.tbManufacturer.MaxLength = 50;
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.ReadOnly = true;
            this.tbManufacturer.Size = new System.Drawing.Size(239, 30);
            this.tbManufacturer.TabIndex = 10;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(12, 172);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(130, 23);
            this.lblManufacturer.TabIndex = 9;
            this.lblManufacturer.Text = "Производитель";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(214, 60);
            this.rtbDescription.MaxLength = 255;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(239, 104);
            this.rtbDescription.TabIndex = 8;
            this.rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 23);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Описание товара";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(214, 12);
            this.tbTitle.MaxLength = 50;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(239, 30);
            this.tbTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 23);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Наименование товара";
            // 
            // pbProductImage
            // 
            this.pbProductImage.Location = new System.Drawing.Point(16, 14);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(247, 247);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductImage.TabIndex = 2;
            this.pbProductImage.TabStop = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 308);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(1039, 268);
            this.dgvProducts.TabIndex = 3;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_CellMouseClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(78, 152);
            this.tbSearch.MaxLength = 50;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(171, 30);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 155);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 23);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Поиск";
            // 
            // cbManufacturers
            // 
            this.cbManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManufacturers.FormattingEnabled = true;
            this.cbManufacturers.Location = new System.Drawing.Point(279, 171);
            this.cbManufacturers.Name = "cbManufacturers";
            this.cbManufacturers.Size = new System.Drawing.Size(171, 31);
            this.cbManufacturers.TabIndex = 6;
            this.cbManufacturers.SelectedIndexChanged += new System.EventHandler(this.cbManufacturers_SelectedIndexChanged);
            // 
            // lblManufacturers
            // 
            this.lblManufacturers.AutoSize = true;
            this.lblManufacturers.Location = new System.Drawing.Point(275, 142);
            this.lblManufacturers.Name = "lblManufacturers";
            this.lblManufacturers.Size = new System.Drawing.Size(132, 23);
            this.lblManufacturers.TabIndex = 7;
            this.lblManufacturers.Text = "Производители";
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(452, 142);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(107, 23);
            this.lblSuppliers.TabIndex = 9;
            this.lblSuppliers.Text = "Поставщики";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(456, 171);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(171, 31);
            this.cbSuppliers.TabIndex = 8;
            this.cbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbManufacturers_SelectedIndexChanged);
            // 
            // btnFilterReset
            // 
            this.btnFilterReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnFilterReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterReset.ForeColor = System.Drawing.Color.White;
            this.btnFilterReset.Location = new System.Drawing.Point(865, 171);
            this.btnFilterReset.Name = "btnFilterReset";
            this.btnFilterReset.Size = new System.Drawing.Size(171, 36);
            this.btnFilterReset.TabIndex = 10;
            this.btnFilterReset.Text = "Сбросить фильтры";
            this.btnFilterReset.UseVisualStyleBackColor = false;
            this.btnFilterReset.Click += new System.EventHandler(this.btnFilterReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Найдено: ";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(629, 142);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(90, 23);
            this.lblCategories.TabIndex = 13;
            this.lblCategories.Text = "Категории";
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(633, 171);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(171, 31);
            this.cbCategories.TabIndex = 12;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbManufacturers_SelectedIndexChanged);
            // 
            // cmsProducts
            // 
            this.cmsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditProduct,
            this.tsmiDeleteProduct,
            this.tsmiOrder});
            this.cmsProducts.Name = "cmsProducts";
            this.cmsProducts.Size = new System.Drawing.Size(189, 70);
            // 
            // tsmiEditProduct
            // 
            this.tsmiEditProduct.Name = "tsmiEditProduct";
            this.tsmiEditProduct.Size = new System.Drawing.Size(188, 22);
            this.tsmiEditProduct.Text = "Редактировать товар";
            this.tsmiEditProduct.Visible = false;
            // 
            // tsmiDeleteProduct
            // 
            this.tsmiDeleteProduct.Name = "tsmiDeleteProduct";
            this.tsmiDeleteProduct.Size = new System.Drawing.Size(188, 22);
            this.tsmiDeleteProduct.Text = "Удалить товар";
            this.tsmiDeleteProduct.Visible = false;
            // 
            // tsmiOrder
            // 
            this.tsmiOrder.Name = "tsmiOrder";
            this.tsmiOrder.Size = new System.Drawing.Size(188, 22);
            this.tsmiOrder.Text = "Заказать товар";
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Location = new System.Drawing.Point(12, 242);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(171, 23);
            this.lblOrderBy.TabIndex = 15;
            this.lblOrderBy.Text = "Отсортировать цену:";
            // 
            // rbAscending
            // 
            this.rbAscending.AutoSize = true;
            this.rbAscending.Checked = true;
            this.rbAscending.Location = new System.Drawing.Point(189, 240);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(150, 27);
            this.rbAscending.TabIndex = 16;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "по возрастанию";
            this.rbAscending.UseVisualStyleBackColor = true;
            this.rbAscending.CheckedChanged += new System.EventHandler(this.rbAscending_CheckedChanged);
            // 
            // rbDescending
            // 
            this.rbDescending.AutoSize = true;
            this.rbDescending.Location = new System.Drawing.Point(189, 266);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(131, 27);
            this.rbDescending.TabIndex = 17;
            this.rbDescending.Text = "по убыванию";
            this.rbDescending.UseVisualStyleBackColor = true;
            this.rbDescending.CheckedChanged += new System.EventHandler(this.rbDescending_CheckedChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(865, 213);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(171, 36);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Visible = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 855);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.rbDescending);
            this.Controls.Add(this.rbAscending);
            this.Controls.Add(this.lblOrderBy);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilterReset);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.lblManufacturers);
            this.Controls.Add(this.cbManufacturers);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlQuantityInStock.ResumeLayout(false);
            this.pnlQuantityInStock.PerformLayout();
            this.pnlInfoProduct.ResumeLayout(false);
            this.pnlInfoProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsProducts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbManufacturers;
        private System.Windows.Forms.Label lblManufacturers;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Button btnFilterReset;
        private System.Windows.Forms.Panel pnlInfoProduct;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Panel pnlQuantityInStock;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.ContextMenuStrip cmsProducts;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.RadioButton rbAscending;
        private System.Windows.Forms.RadioButton rbDescending;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrder;
    }
}