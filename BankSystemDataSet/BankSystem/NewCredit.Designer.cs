namespace BankSystemDataSet
{
    partial class NewCredit
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
            this.groupBoxCreditDetails = new System.Windows.Forms.GroupBox();
            this.lbl_verifyAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeCredit = new System.Windows.Forms.DateTimePicker();
            this.lb_debID = new System.Windows.Forms.ListBox();
            this.lb_debName = new System.Windows.Forms.ListBox();
            this.btn_saveNewCredit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_creditBalance = new System.Windows.Forms.TextBox();
            this.tb_creditAmount = new System.Windows.Forms.TextBox();
            this.tb_CreditID = new System.Windows.Forms.TextBox();
            this.groupBoxCreditDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreditDetails
            // 
            this.groupBoxCreditDetails.Controls.Add(this.lbl_verifyAmount);
            this.groupBoxCreditDetails.Controls.Add(this.label6);
            this.groupBoxCreditDetails.Controls.Add(this.label5);
            this.groupBoxCreditDetails.Controls.Add(this.dateTimeCredit);
            this.groupBoxCreditDetails.Controls.Add(this.lb_debID);
            this.groupBoxCreditDetails.Controls.Add(this.lb_debName);
            this.groupBoxCreditDetails.Controls.Add(this.btn_saveNewCredit);
            this.groupBoxCreditDetails.Controls.Add(this.label4);
            this.groupBoxCreditDetails.Controls.Add(this.label3);
            this.groupBoxCreditDetails.Controls.Add(this.label2);
            this.groupBoxCreditDetails.Controls.Add(this.label1);
            this.groupBoxCreditDetails.Controls.Add(this.tb_creditBalance);
            this.groupBoxCreditDetails.Controls.Add(this.tb_creditAmount);
            this.groupBoxCreditDetails.Controls.Add(this.tb_CreditID);
            this.groupBoxCreditDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCreditDetails.Name = "groupBoxCreditDetails";
            this.groupBoxCreditDetails.Size = new System.Drawing.Size(554, 266);
            this.groupBoxCreditDetails.TabIndex = 3;
            this.groupBoxCreditDetails.TabStop = false;
            this.groupBoxCreditDetails.Text = "Credit Details";
            // 
            // lbl_verifyAmount
            // 
            this.lbl_verifyAmount.AutoSize = true;
            this.lbl_verifyAmount.Location = new System.Drawing.Point(333, 123);
            this.lbl_verifyAmount.Name = "lbl_verifyAmount";
            this.lbl_verifyAmount.Size = new System.Drawing.Size(0, 13);
            this.lbl_verifyAmount.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // dateTimeCredit
            // 
            this.dateTimeCredit.Location = new System.Drawing.Point(95, 157);
            this.dateTimeCredit.Name = "dateTimeCredit";
            this.dateTimeCredit.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCredit.TabIndex = 10;
            // 
            // lb_debID
            // 
            this.lb_debID.DisplayMember = "ID";
            this.lb_debID.FormattingEnabled = true;
            this.lb_debID.Location = new System.Drawing.Point(333, 51);
            this.lb_debID.Name = "lb_debID";
            this.lb_debID.Size = new System.Drawing.Size(215, 56);
            this.lb_debID.TabIndex = 9;
            this.lb_debID.ValueMember = "ID";
            // 
            // lb_debName
            // 
            this.lb_debName.DisplayMember = "Name";
            this.lb_debName.FormattingEnabled = true;
            this.lb_debName.Location = new System.Drawing.Point(95, 51);
            this.lb_debName.Name = "lb_debName";
            this.lb_debName.Size = new System.Drawing.Size(217, 56);
            this.lb_debName.TabIndex = 8;
            this.lb_debName.ValueMember = "ID";
            // 
            // btn_saveNewCredit
            // 
            this.btn_saveNewCredit.Location = new System.Drawing.Point(95, 230);
            this.btn_saveNewCredit.Name = "btn_saveNewCredit";
            this.btn_saveNewCredit.Size = new System.Drawing.Size(453, 23);
            this.btn_saveNewCredit.TabIndex = 3;
            this.btn_saveNewCredit.Text = "Add new Credit";
            this.btn_saveNewCredit.UseVisualStyleBackColor = true;
            this.btn_saveNewCredit.Click += new System.EventHandler(this.btn_saveNewCredit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credit ID";
            // 
            // tb_creditBalance
            // 
            this.tb_creditBalance.BackColor = System.Drawing.SystemColors.Info;
            this.tb_creditBalance.Location = new System.Drawing.Point(95, 192);
            this.tb_creditBalance.Name = "tb_creditBalance";
            this.tb_creditBalance.Size = new System.Drawing.Size(453, 20);
            this.tb_creditBalance.TabIndex = 3;
            // 
            // tb_creditAmount
            // 
            this.tb_creditAmount.BackColor = System.Drawing.SystemColors.Info;
            this.tb_creditAmount.Location = new System.Drawing.Point(95, 120);
            this.tb_creditAmount.Name = "tb_creditAmount";
            this.tb_creditAmount.Size = new System.Drawing.Size(217, 20);
            this.tb_creditAmount.TabIndex = 2;
            this.tb_creditAmount.TextChanged += new System.EventHandler(this.tb_creditAmount_TextChanged);
            this.tb_creditAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_creditAmount_KeyPress);
            this.tb_creditAmount.Leave += new System.EventHandler(this.tb_creditAmount_Leave);
            // 
            // tb_CreditID
            // 
            this.tb_CreditID.BackColor = System.Drawing.SystemColors.Info;
            this.tb_CreditID.Location = new System.Drawing.Point(95, 16);
            this.tb_CreditID.Name = "tb_CreditID";
            this.tb_CreditID.ReadOnly = true;
            this.tb_CreditID.Size = new System.Drawing.Size(453, 20);
            this.tb_CreditID.TabIndex = 0;
            // 
            // NewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 294);
            this.Controls.Add(this.groupBoxCreditDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewCredit";
            this.groupBoxCreditDetails.ResumeLayout(false);
            this.groupBoxCreditDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreditDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeCredit;
        private System.Windows.Forms.ListBox lb_debID;
        private System.Windows.Forms.ListBox lb_debName;
        private System.Windows.Forms.Button btn_saveNewCredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_creditBalance;
        private System.Windows.Forms.TextBox tb_creditAmount;
        private System.Windows.Forms.TextBox tb_CreditID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_verifyAmount;
    }
}