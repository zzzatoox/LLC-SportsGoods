namespace LLC_SportsGoods.Forms
{
    partial class CaptchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnUpdateCaptch = new System.Windows.Forms.Button();
            this.btnEnterCaptch = new System.Windows.Forms.Button();
            this.tbCaptch = new System.Windows.Forms.TextBox();
            this.lblCaptch = new System.Windows.Forms.Label();
            this.pbCaptch = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptch)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(368, 132);
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
            // btnUpdateCaptch
            // 
            this.btnUpdateCaptch.Location = new System.Drawing.Point(190, 316);
            this.btnUpdateCaptch.Name = "btnUpdateCaptch";
            this.btnUpdateCaptch.Size = new System.Drawing.Size(166, 36);
            this.btnUpdateCaptch.TabIndex = 10;
            this.btnUpdateCaptch.Text = "Обновить капчу";
            this.btnUpdateCaptch.UseVisualStyleBackColor = true;
            this.btnUpdateCaptch.Click += new System.EventHandler(this.btnUpdateCaptch_Click);
            // 
            // btnEnterCaptch
            // 
            this.btnEnterCaptch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnEnterCaptch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterCaptch.ForeColor = System.Drawing.Color.White;
            this.btnEnterCaptch.Location = new System.Drawing.Point(69, 438);
            this.btnEnterCaptch.Name = "btnEnterCaptch";
            this.btnEnterCaptch.Size = new System.Drawing.Size(242, 36);
            this.btnEnterCaptch.TabIndex = 9;
            this.btnEnterCaptch.Text = "Подтвердить";
            this.btnEnterCaptch.UseVisualStyleBackColor = false;
            this.btnEnterCaptch.Click += new System.EventHandler(this.btnEnterCaptch_Click);
            // 
            // tbCaptch
            // 
            this.tbCaptch.Location = new System.Drawing.Point(163, 383);
            this.tbCaptch.MaxLength = 4;
            this.tbCaptch.Name = "tbCaptch";
            this.tbCaptch.Size = new System.Drawing.Size(171, 30);
            this.tbCaptch.TabIndex = 8;
            // 
            // lblCaptch
            // 
            this.lblCaptch.AutoSize = true;
            this.lblCaptch.Location = new System.Drawing.Point(37, 390);
            this.lblCaptch.Name = "lblCaptch";
            this.lblCaptch.Size = new System.Drawing.Size(120, 23);
            this.lblCaptch.TabIndex = 7;
            this.lblCaptch.Text = "Введите капчу";
            // 
            // pbCaptch
            // 
            this.pbCaptch.Location = new System.Drawing.Point(70, 138);
            this.pbCaptch.Name = "pbCaptch";
            this.pbCaptch.Size = new System.Drawing.Size(241, 172);
            this.pbCaptch.TabIndex = 11;
            this.pbCaptch.TabStop = false;
            // 
            // CaptchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 505);
            this.Controls.Add(this.pbCaptch);
            this.Controls.Add(this.btnUpdateCaptch);
            this.Controls.Add(this.btnEnterCaptch);
            this.Controls.Add(this.tbCaptch);
            this.Controls.Add(this.lblCaptch);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "CaptchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Капча";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnUpdateCaptch;
        private System.Windows.Forms.Button btnEnterCaptch;
        private System.Windows.Forms.TextBox tbCaptch;
        private System.Windows.Forms.Label lblCaptch;
        private System.Windows.Forms.PictureBox pbCaptch;
    }
}