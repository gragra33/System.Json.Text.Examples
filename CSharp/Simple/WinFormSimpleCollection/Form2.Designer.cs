namespace WinFormSimpleCollection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.butGetData = new System.Windows.Forms.Button();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.txtNumChildren = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLongName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPageTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPageDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMetaDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMetaKeywords = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMetaTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 31);
            this.label11.TabIndex = 4;
            this.label11.Text = "Etsy Category Collection";
            // 
            // butGetData
            // 
            this.butGetData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butGetData.Location = new System.Drawing.Point(578, 19);
            this.butGetData.Name = "butGetData";
            this.butGetData.Size = new System.Drawing.Size(75, 23);
            this.butGetData.TabIndex = 3;
            this.butGetData.Text = "Get Data";
            this.butGetData.UseVisualStyleBackColor = true;
            this.butGetData.Click += new System.EventHandler(this.GetDataClicked);
            // 
            // lbCategories
            // 
            this.lbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.Location = new System.Drawing.Point(12, 58);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(180, 368);
            this.lbCategories.TabIndex = 5;
            // 
            // gbCategory
            // 
            this.gbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCategory.Controls.Add(this.txtNumChildren);
            this.gbCategory.Controls.Add(this.label10);
            this.gbCategory.Controls.Add(this.txtLongName);
            this.gbCategory.Controls.Add(this.label9);
            this.gbCategory.Controls.Add(this.txtShortName);
            this.gbCategory.Controls.Add(this.label8);
            this.gbCategory.Controls.Add(this.txtCategoryName);
            this.gbCategory.Controls.Add(this.label7);
            this.gbCategory.Controls.Add(this.txtPageTitle);
            this.gbCategory.Controls.Add(this.label6);
            this.gbCategory.Controls.Add(this.txtPageDescription);
            this.gbCategory.Controls.Add(this.label5);
            this.gbCategory.Controls.Add(this.txtMetaDescription);
            this.gbCategory.Controls.Add(this.label4);
            this.gbCategory.Controls.Add(this.txtMetaKeywords);
            this.gbCategory.Controls.Add(this.label3);
            this.gbCategory.Controls.Add(this.txtMetaTitle);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Controls.Add(this.txtName);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Location = new System.Drawing.Point(204, 55);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(468, 371);
            this.gbCategory.TabIndex = 6;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "[UNKNOWN]";
            // 
            // txtNumChildren
            // 
            this.txtNumChildren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumChildren.Location = new System.Drawing.Point(162, 339);
            this.txtNumChildren.Name = "txtNumChildren";
            this.txtNumChildren.ReadOnly = true;
            this.txtNumChildren.Size = new System.Drawing.Size(287, 20);
            this.txtNumChildren.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Number of Children";
            // 
            // txtLongName
            // 
            this.txtLongName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLongName.Location = new System.Drawing.Point(162, 313);
            this.txtLongName.Name = "txtLongName";
            this.txtLongName.ReadOnly = true;
            this.txtLongName.Size = new System.Drawing.Size(287, 20);
            this.txtLongName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Long Name";
            // 
            // txtShortName
            // 
            this.txtShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShortName.Location = new System.Drawing.Point(162, 287);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.ReadOnly = true;
            this.txtShortName.Size = new System.Drawing.Size(287, 20);
            this.txtShortName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Short Name";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryName.Location = new System.Drawing.Point(162, 261);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.Size = new System.Drawing.Size(287, 20);
            this.txtCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Category Name";
            // 
            // txtPageTitle
            // 
            this.txtPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageTitle.Location = new System.Drawing.Point(162, 235);
            this.txtPageTitle.Name = "txtPageTitle";
            this.txtPageTitle.ReadOnly = true;
            this.txtPageTitle.Size = new System.Drawing.Size(287, 20);
            this.txtPageTitle.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Page Title";
            // 
            // txtPageDescription
            // 
            this.txtPageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageDescription.Location = new System.Drawing.Point(162, 209);
            this.txtPageDescription.Name = "txtPageDescription";
            this.txtPageDescription.ReadOnly = true;
            this.txtPageDescription.Size = new System.Drawing.Size(287, 20);
            this.txtPageDescription.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Page Description";
            // 
            // txtMetaDescription
            // 
            this.txtMetaDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetaDescription.Location = new System.Drawing.Point(162, 138);
            this.txtMetaDescription.Multiline = true;
            this.txtMetaDescription.Name = "txtMetaDescription";
            this.txtMetaDescription.ReadOnly = true;
            this.txtMetaDescription.Size = new System.Drawing.Size(287, 65);
            this.txtMetaDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Meta Description";
            // 
            // txtMetaKeywords
            // 
            this.txtMetaKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetaKeywords.Location = new System.Drawing.Point(162, 67);
            this.txtMetaKeywords.Multiline = true;
            this.txtMetaKeywords.Name = "txtMetaKeywords";
            this.txtMetaKeywords.ReadOnly = true;
            this.txtMetaKeywords.Size = new System.Drawing.Size(287, 65);
            this.txtMetaKeywords.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meta Keywords";
            // 
            // txtMetaTitle
            // 
            this.txtMetaTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetaTitle.Location = new System.Drawing.Point(162, 41);
            this.txtMetaTitle.Name = "txtMetaTitle";
            this.txtMetaTitle.ReadOnly = true;
            this.txtMetaTitle.Size = new System.Drawing.Size(287, 20);
            this.txtMetaTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Meta Title";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(162, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(287, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.butGetData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON SERIALIZATION - CodeProject | Simple Collection";
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butGetData;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.TextBox txtNumChildren;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLongName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPageTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPageDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMetaDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMetaKeywords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMetaTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}