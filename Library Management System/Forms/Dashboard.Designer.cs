namespace Library_Management_System.Forms
{
	partial class Dashboard
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
            this.BookTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BTNBookDelete = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.dateTimePickerBook = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPublication = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.BTNSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBook = new System.Windows.Forms.TextBox();
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPublicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVPerson = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNPersonDelete = new System.Windows.Forms.Button();
            this.BTNPersonCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBoxSurname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtBoxPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtBoxPersonName = new System.Windows.Forms.TextBox();
            this.BTNPersonSave = new System.Windows.Forms.Button();
            this.SearchGrouPBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtSearchSurname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtSearchName = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerson)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SearchGrouPBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookTab
            // 
            this.BookTab.Controls.Add(this.tabPage1);
            this.BookTab.Controls.Add(this.tabPage2);
            this.BookTab.Location = new System.Drawing.Point(12, 12);
            this.BookTab.Name = "BookTab";
            this.BookTab.SelectedIndex = 0;
            this.BookTab.Size = new System.Drawing.Size(1016, 539);
            this.BookTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTNBookDelete);
            this.tabPage1.Controls.Add(this.BTNCancel);
            this.tabPage1.Controls.Add(this.dateTimePickerBook);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxAuthor);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxPrice);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxQuantity);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxPublication);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxBookName);
            this.tabPage1.Controls.Add(this.BTNSave);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SearchPrice);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SearchBook);
            this.tabPage1.Controls.Add(this.DGVBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTNBookDelete
            // 
            this.BTNBookDelete.Location = new System.Drawing.Point(551, 443);
            this.BTNBookDelete.Name = "BTNBookDelete";
            this.BTNBookDelete.Size = new System.Drawing.Size(166, 37);
            this.BTNBookDelete.TabIndex = 27;
            this.BTNBookDelete.Text = "Delete";
            this.BTNBookDelete.UseVisualStyleBackColor = true;
            this.BTNBookDelete.Click += new System.EventHandler(this.BTNBookDelete_Click_1);
            // 
            // BTNCancel
            // 
            this.BTNCancel.Location = new System.Drawing.Point(786, 443);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(166, 37);
            this.BTNCancel.TabIndex = 26;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click_1);
            // 
            // dateTimePickerBook
            // 
            this.dateTimePickerBook.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerBook.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBook.Location = new System.Drawing.Point(412, 389);
            this.dateTimePickerBook.Name = "dateTimePickerBook";
            this.dateTimePickerBook.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerBook.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Author Name";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(412, 355);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(194, 20);
            this.textBoxAuthor.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Book Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(758, 355);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ShortcutsEnabled = false;
            this.textBoxPrice.Size = new System.Drawing.Size(194, 20);
            this.textBoxPrice.TabIndex = 20;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Book Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(758, 389);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.ShortcutsEnabled = false;
            this.textBoxQuantity.Size = new System.Drawing.Size(194, 20);
            this.textBoxQuantity.TabIndex = 18;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Book Publication";
            // 
            // textBoxPublication
            // 
            this.textBoxPublication.Location = new System.Drawing.Point(758, 321);
            this.textBoxPublication.Name = "textBoxPublication";
            this.textBoxPublication.Size = new System.Drawing.Size(194, 20);
            this.textBoxPublication.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Book Name";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(412, 321);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(194, 20);
            this.textBoxBookName.TabIndex = 14;
            // 
            // BTNSave
            // 
            this.BTNSave.Location = new System.Drawing.Point(315, 443);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(166, 37);
            this.BTNSave.TabIndex = 5;
            this.BTNSave.Text = "Save";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.InsertNewBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "search by price";
            // 
            // SearchPrice
            // 
            this.SearchPrice.Location = new System.Drawing.Point(10, 71);
            this.SearchPrice.Name = "SearchPrice";
            this.SearchPrice.Size = new System.Drawing.Size(277, 20);
            this.SearchPrice.TabIndex = 3;
            this.SearchPrice.TextChanged += new System.EventHandler(this.SearchPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by book or author name";
            // 
            // SearchBook
            // 
            this.SearchBook.Location = new System.Drawing.Point(10, 26);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(277, 20);
            this.SearchBook.TabIndex = 1;
            this.SearchBook.TextChanged += new System.EventHandler(this.SearchBook_TextChanged);
            // 
            // DGVBooks
            // 
            this.DGVBooks.AllowUserToAddRows = false;
            this.DGVBooks.AllowUserToDeleteRows = false;
            this.DGVBooks.AllowUserToResizeColumns = false;
            this.DGVBooks.AllowUserToResizeRows = false;
            this.DGVBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.BookAuthor,
            this.BookPublicationName,
            this.BookPurchaseDate,
            this.BookPrice,
            this.BookQuantity});
            this.DGVBooks.Location = new System.Drawing.Point(300, 6);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.ReadOnly = true;
            this.DGVBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBooks.Size = new System.Drawing.Size(702, 291);
            this.DGVBooks.TabIndex = 0;
            this.DGVBooks.DoubleClick += new System.EventHandler(this.DGVBooks_DoubleClick_1);
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Visible = false;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookAuthor
            // 
            this.BookAuthor.DataPropertyName = "BookAuthor";
            this.BookAuthor.HeaderText = "Book Author";
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.ReadOnly = true;
            // 
            // BookPublicationName
            // 
            this.BookPublicationName.DataPropertyName = "BookPublicationName";
            this.BookPublicationName.HeaderText = "Publication Name";
            this.BookPublicationName.Name = "BookPublicationName";
            this.BookPublicationName.ReadOnly = true;
            // 
            // BookPurchaseDate
            // 
            this.BookPurchaseDate.DataPropertyName = "BookPurchaseDate";
            this.BookPurchaseDate.HeaderText = "PurchaseDate";
            this.BookPurchaseDate.Name = "BookPurchaseDate";
            this.BookPurchaseDate.ReadOnly = true;
            // 
            // BookPrice
            // 
            this.BookPrice.DataPropertyName = "BookPrice";
            this.BookPrice.HeaderText = "Price";
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.ReadOnly = true;
            // 
            // BookQuantity
            // 
            this.BookQuantity.DataPropertyName = "BookQuantity";
            this.BookQuantity.HeaderText = "Quantity";
            this.BookQuantity.Name = "BookQuantity";
            this.BookQuantity.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SearchGrouPBox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.DGVPerson);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Person";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVPerson
            // 
            this.DGVPerson.AllowUserToAddRows = false;
            this.DGVPerson.AllowUserToDeleteRows = false;
            this.DGVPerson.AllowUserToResizeColumns = false;
            this.DGVPerson.AllowUserToResizeRows = false;
            this.DGVPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DGVPerson.Location = new System.Drawing.Point(300, 19);
            this.DGVPerson.Name = "DGVPerson";
            this.DGVPerson.ReadOnly = true;
            this.DGVPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPerson.Size = new System.Drawing.Size(702, 291);
            this.DGVPerson.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNPersonDelete);
            this.groupBox1.Controls.Add(this.BTNPersonCancel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtBoxSurname);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtBoxPhone);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TxtBoxEmail);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtBoxPersonName);
            this.groupBox1.Controls.Add(this.BTNPersonSave);
            this.groupBox1.Location = new System.Drawing.Point(300, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 186);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // BTNPersonDelete
            // 
            this.BTNPersonDelete.Location = new System.Drawing.Point(270, 119);
            this.BTNPersonDelete.Name = "BTNPersonDelete";
            this.BTNPersonDelete.Size = new System.Drawing.Size(166, 37);
            this.BTNPersonDelete.TabIndex = 58;
            this.BTNPersonDelete.Text = "Delete";
            this.BTNPersonDelete.UseVisualStyleBackColor = true;
            // 
            // BTNPersonCancel
            // 
            this.BTNPersonCancel.Location = new System.Drawing.Point(505, 119);
            this.BTNPersonCancel.Name = "BTNPersonCancel";
            this.BTNPersonCancel.Size = new System.Drawing.Size(166, 37);
            this.BTNPersonCancel.TabIndex = 57;
            this.BTNPersonCancel.Text = "Cancel";
            this.BTNPersonCancel.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Surname";
            // 
            // TxtBoxSurname
            // 
            this.TxtBoxSurname.Location = new System.Drawing.Point(131, 64);
            this.TxtBoxSurname.Name = "TxtBoxSurname";
            this.TxtBoxSurname.Size = new System.Drawing.Size(194, 20);
            this.TxtBoxSurname.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Phone";
            // 
            // TxtBoxPhone
            // 
            this.TxtBoxPhone.Location = new System.Drawing.Point(477, 64);
            this.TxtBoxPhone.Name = "TxtBoxPhone";
            this.TxtBoxPhone.ShortcutsEnabled = false;
            this.TxtBoxPhone.Size = new System.Drawing.Size(194, 20);
            this.TxtBoxPhone.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(362, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Email";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(477, 30);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(194, 20);
            this.TxtBoxEmail.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = " Name";
            // 
            // TxtBoxPersonName
            // 
            this.TxtBoxPersonName.Location = new System.Drawing.Point(131, 30);
            this.TxtBoxPersonName.Name = "TxtBoxPersonName";
            this.TxtBoxPersonName.Size = new System.Drawing.Size(194, 20);
            this.TxtBoxPersonName.TabIndex = 49;
            // 
            // BTNPersonSave
            // 
            this.BTNPersonSave.Location = new System.Drawing.Point(34, 119);
            this.BTNPersonSave.Name = "BTNPersonSave";
            this.BTNPersonSave.Size = new System.Drawing.Size(166, 37);
            this.BTNPersonSave.TabIndex = 48;
            this.BTNPersonSave.Text = "Save";
            this.BTNPersonSave.UseVisualStyleBackColor = true;
            // 
            // SearchGrouPBox
            // 
            this.SearchGrouPBox.Controls.Add(this.label12);
            this.SearchGrouPBox.Controls.Add(this.textBox2);
            this.SearchGrouPBox.Controls.Add(this.label9);
            this.SearchGrouPBox.Controls.Add(this.textBox1);
            this.SearchGrouPBox.Controls.Add(this.label15);
            this.SearchGrouPBox.Controls.Add(this.TxtSearchSurname);
            this.SearchGrouPBox.Controls.Add(this.label16);
            this.SearchGrouPBox.Controls.Add(this.TxtSearchName);
            this.SearchGrouPBox.Location = new System.Drawing.Point(15, 19);
            this.SearchGrouPBox.Name = "SearchGrouPBox";
            this.SearchGrouPBox.Size = new System.Drawing.Size(269, 291);
            this.SearchGrouPBox.TabIndex = 53;
            this.SearchGrouPBox.TabStop = false;
            this.SearchGrouPBox.Text = "Search";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Search By Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Search By Phone";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 56;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Search By Surname";
            // 
            // TxtSearchSurname
            // 
            this.TxtSearchSurname.Location = new System.Drawing.Point(6, 108);
            this.TxtSearchSurname.Name = "TxtSearchSurname";
            this.TxtSearchSurname.Size = new System.Drawing.Size(254, 20);
            this.TxtSearchSurname.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Search by Name";
            // 
            // TxtSearchName
            // 
            this.TxtSearchName.Location = new System.Drawing.Point(9, 44);
            this.TxtSearchName.Name = "TxtSearchName";
            this.TxtSearchName.Size = new System.Drawing.Size(254, 20);
            this.TxtSearchName.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Person ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Person Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 563);
            this.Controls.Add(this.BookTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.BookTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerson)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SearchGrouPBox.ResumeLayout(false);
            this.SearchGrouPBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl BookTab;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView DGVBooks;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SearchPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SearchBook;
		private System.Windows.Forms.Button BTNSave;
		private System.Windows.Forms.DateTimePicker dateTimePickerBook;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxAuthor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxPublication;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxBookName;
		private System.Windows.Forms.Button BTNCancel;
		private System.Windows.Forms.Button BTNBookDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookPublicationName;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookPurchaseDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookQuantity;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVPerson;
        private System.Windows.Forms.GroupBox SearchGrouPBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtSearchSurname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtSearchName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNPersonDelete;
        private System.Windows.Forms.Button BTNPersonCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtBoxSurname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtBoxPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtBoxPersonName;
        private System.Windows.Forms.Button BTNPersonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}