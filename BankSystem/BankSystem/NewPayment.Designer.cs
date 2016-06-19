namespace BankSystem
{
    partial class NewPayment
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
            this.lb_creditBalance = new System.Windows.Forms.ListBox();
            this.lb_creditAmount = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_CreditID = new System.Windows.Forms.ListBox();
            this.lbl_verifyAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePayment = new System.Windows.Forms.DateTimePicker();
            this.lb_debID = new System.Windows.Forms.ListBox();
            this.lb_debName = new System.Windows.Forms.ListBox();
            this.btn_saveNewPayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_paymentAmount = new System.Windows.Forms.TextBox();
            this.tb_paymentID = new System.Windows.Forms.TextBox();
            this.lbl_amountControl = new System.Windows.Forms.Label();
            this.groupBoxCreditDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreditDetails
            // 
            this.groupBoxCreditDetails.Controls.Add(this.lbl_amountControl);
            this.groupBoxCreditDetails.Controls.Add(this.lb_creditBalance);
            this.groupBoxCreditDetails.Controls.Add(this.lb_creditAmount);
            this.groupBoxCreditDetails.Controls.Add(this.label7);
            this.groupBoxCreditDetails.Controls.Add(this.lb_CreditID);
            this.groupBoxCreditDetails.Controls.Add(this.lbl_verifyAmount);
            this.groupBoxCreditDetails.Controls.Add(this.label6);
            this.groupBoxCreditDetails.Controls.Add(this.label5);
            this.groupBoxCreditDetails.Controls.Add(this.dateTimePayment);
            this.groupBoxCreditDetails.Controls.Add(this.lb_debID);
            this.groupBoxCreditDetails.Controls.Add(this.lb_debName);
            this.groupBoxCreditDetails.Controls.Add(this.btn_saveNewPayment);
            this.groupBoxCreditDetails.Controls.Add(this.label3);
            this.groupBoxCreditDetails.Controls.Add(this.label2);
            this.groupBoxCreditDetails.Controls.Add(this.label1);
            this.groupBoxCreditDetails.Controls.Add(this.tb_paymentAmount);
            this.groupBoxCreditDetails.Controls.Add(this.tb_paymentID);
            this.groupBoxCreditDetails.Location = new System.Drawing.Point(33, 12);
            this.groupBoxCreditDetails.Name = "groupBoxCreditDetails";
            this.groupBoxCreditDetails.Size = new System.Drawing.Size(554, 311);
            this.groupBoxCreditDetails.TabIndex = 4;
            this.groupBoxCreditDetails.TabStop = false;
            this.groupBoxCreditDetails.Text = "Payment Details";
            // 
            // lb_creditBalance
            // 
            this.lb_creditBalance.DisplayMember = "Balance";
            this.lb_creditBalance.FormattingEnabled = true;
            this.lb_creditBalance.Location = new System.Drawing.Point(409, 123);
            this.lb_creditBalance.Name = "lb_creditBalance";
            this.lb_creditBalance.Size = new System.Drawing.Size(139, 56);
            this.lb_creditBalance.TabIndex = 17;
            this.lb_creditBalance.ValueMember = "Balance";
            // 
            // lb_creditAmount
            // 
            this.lb_creditAmount.DisplayMember = "Amount";
            this.lb_creditAmount.FormattingEnabled = true;
            this.lb_creditAmount.Location = new System.Drawing.Point(252, 123);
            this.lb_creditAmount.Name = "lb_creditAmount";
            this.lb_creditAmount.Size = new System.Drawing.Size(139, 56);
            this.lb_creditAmount.TabIndex = 16;
            this.lb_creditAmount.ValueMember = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Credit";
            // 
            // lb_CreditID
            // 
            this.lb_CreditID.DisplayMember = "ID";
            this.lb_CreditID.FormattingEnabled = true;
            this.lb_CreditID.Location = new System.Drawing.Point(95, 123);
            this.lb_CreditID.Name = "lb_CreditID";
            this.lb_CreditID.Size = new System.Drawing.Size(139, 56);
            this.lb_CreditID.TabIndex = 14;
            this.lb_CreditID.ValueMember = "ID";
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
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // dateTimePayment
            // 
            this.dateTimePayment.Location = new System.Drawing.Point(95, 225);
            this.dateTimePayment.Name = "dateTimePayment";
            this.dateTimePayment.Size = new System.Drawing.Size(453, 20);
            this.dateTimePayment.TabIndex = 10;
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
            this.lb_debID.SelectedIndexChanged += new System.EventHandler(this.lb_debitor_SelectedIndexChanged);
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
            this.lb_debName.SelectedIndexChanged += new System.EventHandler(this.lb_debitor_SelectedIndexChanged);
            // 
            // btn_saveNewPayment
            // 
            this.btn_saveNewPayment.Location = new System.Drawing.Point(95, 273);
            this.btn_saveNewPayment.Name = "btn_saveNewPayment";
            this.btn_saveNewPayment.Size = new System.Drawing.Size(453, 23);
            this.btn_saveNewPayment.TabIndex = 3;
            this.btn_saveNewPayment.Text = "Pass new Payment";
            this.btn_saveNewPayment.UseVisualStyleBackColor = true;
            this.btn_saveNewPayment.Click += new System.EventHandler(this.btn_saveNewPayment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 201);
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
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payment ID";
            // 
            // tb_paymentAmount
            // 
            this.tb_paymentAmount.BackColor = System.Drawing.SystemColors.Info;
            this.tb_paymentAmount.Location = new System.Drawing.Point(95, 194);
            this.tb_paymentAmount.Name = "tb_paymentAmount";
            this.tb_paymentAmount.Size = new System.Drawing.Size(217, 20);
            this.tb_paymentAmount.TabIndex = 2;
            this.tb_paymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_paymentAmount_KeyPress);
            this.tb_paymentAmount.Leave += new System.EventHandler(this.tb_paymentAmount_Leave);
            // 
            // tb_paymentID
            // 
            this.tb_paymentID.BackColor = System.Drawing.SystemColors.Info;
            this.tb_paymentID.Location = new System.Drawing.Point(95, 16);
            this.tb_paymentID.Name = "tb_paymentID";
            this.tb_paymentID.ReadOnly = true;
            this.tb_paymentID.Size = new System.Drawing.Size(453, 20);
            this.tb_paymentID.TabIndex = 0;
            // 
            // lbl_amountControl
            // 
            this.lbl_amountControl.AutoSize = true;
            this.lbl_amountControl.Location = new System.Drawing.Point(319, 194);
            this.lbl_amountControl.Name = "lbl_amountControl";
            this.lbl_amountControl.Size = new System.Drawing.Size(0, 13);
            this.lbl_amountControl.TabIndex = 18;
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 333);
            this.Controls.Add(this.groupBoxCreditDetails);
            this.Name = "NewPayment";
            this.Text = "NewPayment";
            this.groupBoxCreditDetails.ResumeLayout(false);
            this.groupBoxCreditDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreditDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_CreditID;
        private System.Windows.Forms.Label lbl_verifyAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePayment;
        private System.Windows.Forms.ListBox lb_debID;
        private System.Windows.Forms.ListBox lb_debName;
        private System.Windows.Forms.Button btn_saveNewPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_paymentAmount;
        private System.Windows.Forms.TextBox tb_paymentID;
        private System.Windows.Forms.ListBox lb_creditBalance;
        private System.Windows.Forms.ListBox lb_creditAmount;
        private System.Windows.Forms.Label lbl_amountControl;
    }
}