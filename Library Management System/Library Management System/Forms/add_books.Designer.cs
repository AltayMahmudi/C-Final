namespace Library_Management_System.Forms
{
    partial class add_books
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_books));
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPublication = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxAuthor = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.BtnSave = new System.Windows.Forms.Button();
			this.dateTimePickerBook = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// textBoxBookName
			// 
			this.textBoxBookName.Location = new System.Drawing.Point(143, 21);
			this.textBoxBookName.Name = "textBoxBookName";
			this.textBoxBookName.Size = new System.Drawing.Size(194, 20);
			this.textBoxBookName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Book Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Book Publication";
			// 
			// textBoxPublication
			// 
			this.textBoxPublication.Location = new System.Drawing.Point(143, 93);
			this.textBoxPublication.Name = "textBoxPublication";
			this.textBoxPublication.Size = new System.Drawing.Size(194, 20);
			this.textBoxPublication.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Book Quantity";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Location = new System.Drawing.Point(143, 166);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.Size = new System.Drawing.Size(194, 20);
			this.textBoxQuantity.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Book Price";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(143, 130);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(194, 20);
			this.textBoxPrice.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Author Name";
			// 
			// textBoxAuthor
			// 
			this.textBoxAuthor.Location = new System.Drawing.Point(143, 57);
			this.textBoxAuthor.Name = "textBoxAuthor";
			this.textBoxAuthor.Size = new System.Drawing.Size(194, 20);
			this.textBoxAuthor.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(28, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Purchase Date";
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(95, 252);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(168, 60);
			this.BtnSave.TabIndex = 12;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// dateTimePickerBook
			// 
			this.dateTimePickerBook.CustomFormat = "dd-MM-yyyy";
			this.dateTimePickerBook.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerBook.Location = new System.Drawing.Point(143, 207);
			this.dateTimePickerBook.Name = "dateTimePickerBook";
			this.dateTimePickerBook.Size = new System.Drawing.Size(194, 20);
			this.dateTimePickerBook.TabIndex = 13;
			// 
			// add_books
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 329);
			this.Controls.Add(this.dateTimePickerBook);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxAuthor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxQuantity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPublication);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxBookName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "add_books";
			this.Text = "Add Books";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPublication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.DateTimePicker dateTimePickerBook;
	}
}