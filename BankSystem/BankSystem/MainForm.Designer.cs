namespace BankSystem
{
    partial class MainForm
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
            this.groupBoxDebitors = new System.Windows.Forms.GroupBox();
            this.dataGridViewDebitors = new System.Windows.Forms.DataGridView();
            this.groupBoxDebitorsDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDebitorPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxDebitorPostIndex = new System.Windows.Forms.TextBox();
            this.textBoxDebitorName = new System.Windows.Forms.TextBox();
            this.textBoxDebitorID = new System.Windows.Forms.TextBox();
            this.groupBoxCredits = new System.Windows.Forms.GroupBox();
            this.dataGridViewCredits = new System.Windows.Forms.DataGridView();
            this.groupBoxPayments = new System.Windows.Forms.GroupBox();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_searchPhoneNumber = new System.Windows.Forms.TextBox();
            this.tb_searchPostIndex = new System.Windows.Forms.TextBox();
            this.tb_searchName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDebitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxDebitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebitors)).BeginInit();
            this.groupBoxDebitorsDetails.SuspendLayout();
            this.groupBoxCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredits)).BeginInit();
            this.groupBoxPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDebitors
            // 
            this.groupBoxDebitors.AutoSize = true;
            this.groupBoxDebitors.Controls.Add(this.dataGridViewDebitors);
            this.groupBoxDebitors.Location = new System.Drawing.Point(28, 114);
            this.groupBoxDebitors.Name = "groupBoxDebitors";
            this.groupBoxDebitors.Size = new System.Drawing.Size(314, 121);
            this.groupBoxDebitors.TabIndex = 0;
            this.groupBoxDebitors.TabStop = false;
            this.groupBoxDebitors.Text = "Debitors";
            // 
            // dataGridViewDebitors
            // 
            this.dataGridViewDebitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDebitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDebitors.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDebitors.Name = "dataGridViewDebitors";
            this.dataGridViewDebitors.Size = new System.Drawing.Size(308, 102);
            this.dataGridViewDebitors.TabIndex = 0;
            this.dataGridViewDebitors.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_RowPrePaint);
            // 
            // groupBoxDebitorsDetails
            // 
            this.groupBoxDebitorsDetails.Controls.Add(this.label4);
            this.groupBoxDebitorsDetails.Controls.Add(this.label3);
            this.groupBoxDebitorsDetails.Controls.Add(this.label2);
            this.groupBoxDebitorsDetails.Controls.Add(this.label1);
            this.groupBoxDebitorsDetails.Controls.Add(this.textBoxDebitorPhoneNumber);
            this.groupBoxDebitorsDetails.Controls.Add(this.textBoxDebitorPostIndex);
            this.groupBoxDebitorsDetails.Controls.Add(this.textBoxDebitorName);
            this.groupBoxDebitorsDetails.Controls.Add(this.textBoxDebitorID);
            this.groupBoxDebitorsDetails.Location = new System.Drawing.Point(383, 111);
            this.groupBoxDebitorsDetails.Name = "groupBoxDebitorsDetails";
            this.groupBoxDebitorsDetails.Size = new System.Drawing.Size(314, 121);
            this.groupBoxDebitorsDetails.TabIndex = 1;
            this.groupBoxDebitorsDetails.TabStop = false;
            this.groupBoxDebitorsDetails.Text = "Debitor\'s Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Post index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // textBoxDebitorPhoneNumber
            // 
            this.textBoxDebitorPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorPhoneNumber.Location = new System.Drawing.Point(95, 94);
            this.textBoxDebitorPhoneNumber.Name = "textBoxDebitorPhoneNumber";
            this.textBoxDebitorPhoneNumber.ReadOnly = true;
            this.textBoxDebitorPhoneNumber.Size = new System.Drawing.Size(219, 20);
            this.textBoxDebitorPhoneNumber.TabIndex = 3;
            // 
            // textBoxDebitorPostIndex
            // 
            this.textBoxDebitorPostIndex.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorPostIndex.Location = new System.Drawing.Point(95, 68);
            this.textBoxDebitorPostIndex.Name = "textBoxDebitorPostIndex";
            this.textBoxDebitorPostIndex.ReadOnly = true;
            this.textBoxDebitorPostIndex.Size = new System.Drawing.Size(219, 20);
            this.textBoxDebitorPostIndex.TabIndex = 2;
            // 
            // textBoxDebitorName
            // 
            this.textBoxDebitorName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorName.Location = new System.Drawing.Point(95, 42);
            this.textBoxDebitorName.Name = "textBoxDebitorName";
            this.textBoxDebitorName.ReadOnly = true;
            this.textBoxDebitorName.Size = new System.Drawing.Size(219, 20);
            this.textBoxDebitorName.TabIndex = 1;
            // 
            // textBoxDebitorID
            // 
            this.textBoxDebitorID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorID.Location = new System.Drawing.Point(95, 16);
            this.textBoxDebitorID.Name = "textBoxDebitorID";
            this.textBoxDebitorID.ReadOnly = true;
            this.textBoxDebitorID.Size = new System.Drawing.Size(219, 20);
            this.textBoxDebitorID.TabIndex = 0;
            // 
            // groupBoxCredits
            // 
            this.groupBoxCredits.Controls.Add(this.dataGridViewCredits);
            this.groupBoxCredits.Location = new System.Drawing.Point(31, 260);
            this.groupBoxCredits.Name = "groupBoxCredits";
            this.groupBoxCredits.Size = new System.Drawing.Size(669, 100);
            this.groupBoxCredits.TabIndex = 1;
            this.groupBoxCredits.TabStop = false;
            this.groupBoxCredits.Text = "Credits";
            // 
            // dataGridViewCredits
            // 
            this.dataGridViewCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCredits.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCredits.Name = "dataGridViewCredits";
            this.dataGridViewCredits.Size = new System.Drawing.Size(663, 81);
            this.dataGridViewCredits.TabIndex = 0;
            this.dataGridViewCredits.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_RowPrePaint);
            // 
            // groupBoxPayments
            // 
            this.groupBoxPayments.Controls.Add(this.dataGridViewPayments);
            this.groupBoxPayments.Location = new System.Drawing.Point(31, 375);
            this.groupBoxPayments.Name = "groupBoxPayments";
            this.groupBoxPayments.Size = new System.Drawing.Size(669, 103);
            this.groupBoxPayments.TabIndex = 1;
            this.groupBoxPayments.TabStop = false;
            this.groupBoxPayments.Text = "Payments";
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPayments.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.Size = new System.Drawing.Size(663, 84);
            this.dataGridViewPayments.TabIndex = 0;
            this.dataGridViewPayments.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_RowPrePaint);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.label7);
            this.groupBoxSearch.Controls.Add(this.label6);
            this.groupBoxSearch.Controls.Add(this.label5);
            this.groupBoxSearch.Controls.Add(this.btn_Search);
            this.groupBoxSearch.Controls.Add(this.tb_searchPhoneNumber);
            this.groupBoxSearch.Controls.Add(this.tb_searchPostIndex);
            this.groupBoxSearch.Controls.Add(this.tb_searchName);
            this.groupBoxSearch.Location = new System.Drawing.Point(28, 39);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(669, 66);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(554, 20);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(92, 34);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_searchPhoneNumber
            // 
            this.tb_searchPhoneNumber.Location = new System.Drawing.Point(365, 34);
            this.tb_searchPhoneNumber.Name = "tb_searchPhoneNumber";
            this.tb_searchPhoneNumber.Size = new System.Drawing.Size(151, 20);
            this.tb_searchPhoneNumber.TabIndex = 2;
            this.tb_searchPhoneNumber.Enter += new System.EventHandler(this.tb_search_Enter);
            // 
            // tb_searchPostIndex
            // 
            this.tb_searchPostIndex.Location = new System.Drawing.Point(189, 34);
            this.tb_searchPostIndex.Name = "tb_searchPostIndex";
            this.tb_searchPostIndex.Size = new System.Drawing.Size(151, 20);
            this.tb_searchPostIndex.TabIndex = 1;
            this.tb_searchPostIndex.Enter += new System.EventHandler(this.tb_search_Enter);
            // 
            // tb_searchName
            // 
            this.tb_searchName.Location = new System.Drawing.Point(6, 34);
            this.tb_searchName.Name = "tb_searchName";
            this.tb_searchName.Size = new System.Drawing.Size(151, 20);
            this.tb_searchName.TabIndex = 0;
            this.tb_searchName.Enter += new System.EventHandler(this.tb_search_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debitorToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDataToCSVToolStripMenuItem
            // 
            this.saveDataToCSVToolStripMenuItem.Name = "saveDataToCSVToolStripMenuItem";
            this.saveDataToCSVToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveDataToCSVToolStripMenuItem.Text = "Save data to CSV";
            this.saveDataToCSVToolStripMenuItem.Click += new System.EventHandler(this.saveDataToCSVToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debitorToolStripMenuItem
            // 
            this.debitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDebitorToolStripMenuItem});
            this.debitorToolStripMenuItem.Name = "debitorToolStripMenuItem";
            this.debitorToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.debitorToolStripMenuItem.Text = "Debitor";
            // 
            // addNewDebitorToolStripMenuItem
            // 
            this.addNewDebitorToolStripMenuItem.Name = "addNewDebitorToolStripMenuItem";
            this.addNewDebitorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewDebitorToolStripMenuItem.Text = "Add new debitor";
            this.addNewDebitorToolStripMenuItem.Click += new System.EventHandler(this.addNewDebitorToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewCreditToolStripMenuItem});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // openNewCreditToolStripMenuItem
            // 
            this.openNewCreditToolStripMenuItem.Name = "openNewCreditToolStripMenuItem";
            this.openNewCreditToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openNewCreditToolStripMenuItem.Text = "Open new Credit";
            this.openNewCreditToolStripMenuItem.Click += new System.EventHandler(this.openNewCreditToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passNewPaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // passNewPaymentToolStripMenuItem
            // 
            this.passNewPaymentToolStripMenuItem.Name = "passNewPaymentToolStripMenuItem";
            this.passNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.passNewPaymentToolStripMenuItem.Text = "Pass new payment";
            this.passNewPaymentToolStripMenuItem.Click += new System.EventHandler(this.passNewPaymentToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Post Index";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone Number";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 490);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxPayments);
            this.Controls.Add(this.groupBoxCredits);
            this.Controls.Add(this.groupBoxDebitorsDetails);
            this.Controls.Add(this.groupBoxDebitors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDebitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebitors)).EndInit();
            this.groupBoxDebitorsDetails.ResumeLayout(false);
            this.groupBoxDebitorsDetails.PerformLayout();
            this.groupBoxCredits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredits)).EndInit();
            this.groupBoxPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDebitors;
        private System.Windows.Forms.DataGridView dataGridViewDebitors;
        private System.Windows.Forms.GroupBox groupBoxDebitorsDetails;
        private System.Windows.Forms.GroupBox groupBoxCredits;
        private System.Windows.Forms.DataGridView dataGridViewCredits;
        private System.Windows.Forms.GroupBox groupBoxPayments;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDebitorPhoneNumber;
        private System.Windows.Forms.TextBox textBoxDebitorPostIndex;
        private System.Windows.Forms.TextBox textBoxDebitorName;
        private System.Windows.Forms.TextBox textBoxDebitorID;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDebitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passNewPaymentToolStripMenuItem;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_searchPhoneNumber;
        private System.Windows.Forms.TextBox tb_searchPostIndex;
        private System.Windows.Forms.TextBox tb_searchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

