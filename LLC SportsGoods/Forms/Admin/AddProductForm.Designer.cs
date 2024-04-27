namespace LLC_SportsGoods.Forms.Admin
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCategories = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.lblManufacturers = new System.Windows.Forms.Label();
            this.cbManufacturers = new System.Windows.Forms.ComboBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.mtbQuantity = new System.Windows.Forms.MaskedTextBox();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.pnlTop.Controls.Add(this.lblName);
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(749, 132);
            this.pnlTop.TabIndex = 1;
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(566, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 103);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(371, 349);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(90, 23);
            this.lblCategories.TabIndex = 29;
            this.lblCategories.Text = "Категории";
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(375, 378);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(171, 31);
            this.cbCategories.TabIndex = 28;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(194, 349);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(107, 23);
            this.lblSuppliers.TabIndex = 27;
            this.lblSuppliers.Text = "Поставщики";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(198, 378);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(171, 31);
            this.cbSuppliers.TabIndex = 26;
            // 
            // lblManufacturers
            // 
            this.lblManufacturers.AutoSize = true;
            this.lblManufacturers.Location = new System.Drawing.Point(17, 349);
            this.lblManufacturers.Name = "lblManufacturers";
            this.lblManufacturers.Size = new System.Drawing.Size(132, 23);
            this.lblManufacturers.TabIndex = 25;
            this.lblManufacturers.Text = "Производители";
            // 
            // cbManufacturers
            // 
            this.cbManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManufacturers.FormattingEnabled = true;
            this.cbManufacturers.Location = new System.Drawing.Point(21, 378);
            this.cbManufacturers.Name = "cbManufacturers";
            this.cbManufacturers.Size = new System.Drawing.Size(171, 31);
            this.cbManufacturers.TabIndex = 24;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(20, 178);
            this.tbTitle.MaxLength = 50;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(172, 30);
            this.tbTitle.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 152);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 23);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Наименование товара";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(16, 216);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(177, 23);
            this.lblQuantity.TabIndex = 31;
            this.lblQuantity.Text = "Количество на складе";
            // 
            // mtbQuantity
            // 
            this.mtbQuantity.Location = new System.Drawing.Point(21, 242);
            this.mtbQuantity.Mask = "000";
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.Size = new System.Drawing.Size(65, 30);
            this.mtbQuantity.TabIndex = 33;
            // 
            // tbUnit
            // 
            this.tbUnit.Location = new System.Drawing.Point(21, 311);
            this.tbUnit.MaxLength = 50;
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(172, 30);
            this.tbUnit.TabIndex = 35;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(17, 285);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(160, 23);
            this.lblUnit.TabIndex = 34;
            this.lblUnit.Text = "Еденица измерения";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(214, 152);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(147, 23);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "Стоимость товара";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(218, 178);
            this.tbPrice.MaxLength = 50;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(172, 30);
            this.tbPrice.TabIndex = 37;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(409, 178);
            this.rtbDescription.MaxLength = 255;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(328, 104);
            this.rtbDescription.TabIndex = 39;
            this.rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(405, 152);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 23);
            this.lblDescription.TabIndex = 38;
            this.lblDescription.Text = "Описание товара";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 475);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.lblManufacturers);
            this.Controls.Add(this.cbManufacturers);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddProductForm";
            this.Text = "Добавление товара";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Label lblManufacturers;
        private System.Windows.Forms.ComboBox cbManufacturers;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.MaskedTextBox mtbQuantity;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}