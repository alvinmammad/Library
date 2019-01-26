namespace LibraryApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedLB = new System.Windows.Forms.CheckedListBox();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.cmbUsers = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBook = new MetroFramework.Controls.MetroButton();
            this.dgvStockedBooks = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchBook = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.dgvReturned = new MetroFramework.Controls.MetroGrid();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemainingDate = new MetroFramework.Controls.MetroButton();
            this.btnSearchforWorker = new MetroFramework.Controls.MetroButton();
            this.dtpReturnBook = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWorkerforReturn = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemainingDays = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockedBooks)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturned)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.checkedLB);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.cmbUsers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.dgvStockedBooks);
            this.panel1.Controls.Add(this.txtSearchBook);
            this.panel1.Location = new System.Drawing.Point(3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 477);
            this.panel1.TabIndex = 0;
            // 
            // checkedLB
            // 
            this.checkedLB.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedLB.FormattingEnabled = true;
            this.checkedLB.Location = new System.Drawing.Point(3, 307);
            this.checkedLB.Name = "checkedLB";
            this.checkedLB.Size = new System.Drawing.Size(293, 94);
            this.checkedLB.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(302, 378);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Təsdiqlə";
            this.btnConfirm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.ItemHeight = 23;
            this.cmbUsers.Location = new System.Drawing.Point(3, 257);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(293, 29);
            this.cmbUsers.TabIndex = 5;
            this.cmbUsers.UseSelectable = true;
            this.cmbUsers.Click += new System.EventHandler(this.cmbUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(111, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Götürmək istədiyiniz kitabı axtarın";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(302, 257);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(89, 29);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Kitabı əlavə et";
            this.btnAddBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddBook.UseSelectable = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // dgvStockedBooks
            // 
            this.dgvStockedBooks.AllowUserToResizeRows = false;
            this.dgvStockedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockedBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStockedBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockedBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStockedBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockedBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvStockedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockedBooks.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvStockedBooks.EnableHeadersVisualStyles = false;
            this.dgvStockedBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvStockedBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStockedBooks.Location = new System.Drawing.Point(3, 101);
            this.dgvStockedBooks.Name = "dgvStockedBooks";
            this.dgvStockedBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockedBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvStockedBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStockedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockedBooks.Size = new System.Drawing.Size(443, 150);
            this.dgvStockedBooks.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitab adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kateqoriyası";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Yazarı";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Statusu";
            this.Column5.Name = "Column5";
            // 
            // txtSearchBook
            // 
            // 
            // 
            // 
            this.txtSearchBook.CustomButton.Image = null;
            this.txtSearchBook.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtSearchBook.CustomButton.Name = "";
            this.txtSearchBook.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchBook.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchBook.CustomButton.TabIndex = 1;
            this.txtSearchBook.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchBook.CustomButton.UseSelectable = true;
            this.txtSearchBook.CustomButton.Visible = false;
            this.txtSearchBook.Lines = new string[0];
            this.txtSearchBook.Location = new System.Drawing.Point(161, 56);
            this.txtSearchBook.MaxLength = 32767;
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.PasswordChar = '\0';
            this.txtSearchBook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchBook.SelectedText = "";
            this.txtSearchBook.SelectionLength = 0;
            this.txtSearchBook.SelectionStart = 0;
            this.txtSearchBook.ShortcutsEnabled = true;
            this.txtSearchBook.Size = new System.Drawing.Size(138, 23);
            this.txtSearchBook.TabIndex = 1;
            this.txtSearchBook.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchBook.UseSelectable = true;
            this.txtSearchBook.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchBook.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchBook.TextChanged += new System.EventHandler(this.txtSearchBook_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.txtRemainingDays);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.dgvReturned);
            this.panel2.Controls.Add(this.btnRemainingDate);
            this.panel2.Controls.Add(this.btnSearchforWorker);
            this.panel2.Controls.Add(this.dtpReturnBook);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbWorkerforReturn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(455, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 477);
            this.panel2.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(160, 370);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(236, 53);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Qaytar";
            this.btnReturn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReturn.UseSelectable = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvReturned
            // 
            this.dgvReturned.AllowUserToResizeRows = false;
            this.dgvReturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturned.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReturned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturned.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReturned.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturned.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvReturned.EnableHeadersVisualStyles = false;
            this.dgvReturned.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvReturned.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReturned.Location = new System.Drawing.Point(7, 201);
            this.dgvReturned.Name = "dgvReturned";
            this.dgvReturned.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturned.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvReturned.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturned.Size = new System.Drawing.Size(537, 150);
            this.dgvReturned.TabIndex = 6;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "İşçi adı";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "İşçi soyadı";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "İşçi telefonu";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Kitabın adı";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Qaytarılma tarixi";
            this.Column11.Name = "Column11";
            // 
            // btnRemainingDate
            // 
            this.btnRemainingDate.Location = new System.Drawing.Point(322, 124);
            this.btnRemainingDate.Name = "btnRemainingDate";
            this.btnRemainingDate.Size = new System.Drawing.Size(120, 23);
            this.btnRemainingDate.TabIndex = 5;
            this.btnRemainingDate.Text = "Axtar";
            this.btnRemainingDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemainingDate.UseSelectable = true;
            this.btnRemainingDate.Click += new System.EventHandler(this.btnRemainingDate_Click);
            // 
            // btnSearchforWorker
            // 
            this.btnSearchforWorker.Location = new System.Drawing.Point(65, 124);
            this.btnSearchforWorker.Name = "btnSearchforWorker";
            this.btnSearchforWorker.Size = new System.Drawing.Size(120, 23);
            this.btnSearchforWorker.TabIndex = 5;
            this.btnSearchforWorker.Text = "Axtar";
            this.btnSearchforWorker.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSearchforWorker.UseSelectable = true;
            this.btnSearchforWorker.Click += new System.EventHandler(this.btnSearchforWorker_Click);
            // 
            // dtpReturnBook
            // 
            this.dtpReturnBook.Location = new System.Drawing.Point(273, 78);
            this.dtpReturnBook.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpReturnBook.Name = "dtpReturnBook";
            this.dtpReturnBook.Size = new System.Drawing.Size(199, 29);
            this.dtpReturnBook.TabIndex = 3;
            this.dtpReturnBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(270, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = " Götürülmə tarixinə görə axtarın";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İstifadəçiyə görə axtarın";
            // 
            // cmbWorkerforReturn
            // 
            this.cmbWorkerforReturn.FormattingEnabled = true;
            this.cmbWorkerforReturn.ItemHeight = 23;
            this.cmbWorkerforReturn.Location = new System.Drawing.Point(18, 78);
            this.cmbWorkerforReturn.Name = "cmbWorkerforReturn";
            this.cmbWorkerforReturn.Size = new System.Drawing.Size(211, 29);
            this.cmbWorkerforReturn.TabIndex = 1;
            this.cmbWorkerforReturn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbWorkerforReturn.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Götürdüyünüz kitabları axtarın";
            // 
            // txtRemainingDays
            // 
            // 
            // 
            // 
            this.txtRemainingDays.CustomButton.Image = null;
            this.txtRemainingDays.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.txtRemainingDays.CustomButton.Name = "";
            this.txtRemainingDays.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRemainingDays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemainingDays.CustomButton.TabIndex = 1;
            this.txtRemainingDays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemainingDays.CustomButton.UseSelectable = true;
            this.txtRemainingDays.CustomButton.Visible = false;
            this.txtRemainingDays.Lines = new string[] {
        "0"};
            this.txtRemainingDays.Location = new System.Drawing.Point(478, 84);
            this.txtRemainingDays.MaxLength = 32767;
            this.txtRemainingDays.Name = "txtRemainingDays";
            this.txtRemainingDays.PasswordChar = '\0';
            this.txtRemainingDays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemainingDays.SelectedText = "";
            this.txtRemainingDays.SelectionLength = 0;
            this.txtRemainingDays.SelectionStart = 0;
            this.txtRemainingDays.ShortcutsEnabled = true;
            this.txtRemainingDays.Size = new System.Drawing.Size(63, 23);
            this.txtRemainingDays.TabIndex = 8;
            this.txtRemainingDays.Text = "0";
            this.txtRemainingDays.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRemainingDays.UseSelectable = true;
            this.txtRemainingDays.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemainingDays.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockedBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid dgvStockedBooks;
        private MetroFramework.Controls.MetroTextBox txtSearchBook;
        private MetroFramework.Controls.MetroButton btnAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroComboBox cmbUsers;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private System.Windows.Forms.CheckedListBox checkedLB;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid dgvReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private MetroFramework.Controls.MetroButton btnRemainingDate;
        private MetroFramework.Controls.MetroButton btnSearchforWorker;
        private MetroFramework.Controls.MetroDateTime dtpReturnBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cmbWorkerforReturn;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Controls.MetroTextBox txtRemainingDays;
    }
}