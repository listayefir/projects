namespace BankSystemDataSet
{
    partial class NewDebitor
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
            this.groupBoxDebitorsDetails = new System.Windows.Forms.GroupBox();
            this.btn_saveNewDebitor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDebitorPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxDebitorPostIndex = new System.Windows.Forms.TextBox();
            this.textBoxDebitorName = new System.Windows.Forms.TextBox();
            this.textBoxDebitorID = new System.Windows.Forms.TextBox();
            this.groupBoxDebitorsDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDebitorsDetails
            // 
            this.groupBoxDebitorsDetails.Controls.Add(this.btn_saveNewDebitor);
            this.groupBoxDebitorsDetails.Controls.Add(this.label4);
            this.groupBoxDebitorsDetails.Controls.Add(this.label3);
            this.groupBoxDebitorsDetails.Controls.Add(this.label2);
            this.groupBoxDebitorsDetails.Controls.Add(this.label1);
            this.groupBoxDebitorsDetails.Controls.Add(this.textBoxDebitorPhoneNumber);
            this.groupBoxDebitorsDetails.Controls.Add(this.textBoxDebitorPostIndex);
            this.groupBoxDebitorsDetails.Controls.Add(this.textBoxDebitorName);
            this.groupBoxDebitorsDetails.Controls.Add(this.textBoxDebitorID);
            this.groupBoxDebitorsDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDebitorsDetails.Name = "groupBoxDebitorsDetails";
            this.groupBoxDebitorsDetails.Size = new System.Drawing.Size(554, 187);
            this.groupBoxDebitorsDetails.TabIndex = 2;
            this.groupBoxDebitorsDetails.TabStop = false;
            this.groupBoxDebitorsDetails.Text = "Debitor\'s Details";
            // 
            // btn_saveNewDebitor
            // 
            this.btn_saveNewDebitor.Location = new System.Drawing.Point(95, 133);
            this.btn_saveNewDebitor.Name = "btn_saveNewDebitor";
            this.btn_saveNewDebitor.Size = new System.Drawing.Size(453, 23);
            this.btn_saveNewDebitor.TabIndex = 3;
            this.btn_saveNewDebitor.Text = "Add";
            this.btn_saveNewDebitor.UseVisualStyleBackColor = true;
            this.btn_saveNewDebitor.Click += new System.EventHandler(this.btn_saveNewDebitor_Click);
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
            this.textBoxDebitorPhoneNumber.Size = new System.Drawing.Size(453, 20);
            this.textBoxDebitorPhoneNumber.TabIndex = 3;
            // 
            // textBoxDebitorPostIndex
            // 
            this.textBoxDebitorPostIndex.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorPostIndex.Location = new System.Drawing.Point(95, 68);
            this.textBoxDebitorPostIndex.Name = "textBoxDebitorPostIndex";
            this.textBoxDebitorPostIndex.Size = new System.Drawing.Size(453, 20);
            this.textBoxDebitorPostIndex.TabIndex = 2;
            // 
            // textBoxDebitorName
            // 
            this.textBoxDebitorName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorName.Location = new System.Drawing.Point(95, 42);
            this.textBoxDebitorName.Name = "textBoxDebitorName";
            this.textBoxDebitorName.Size = new System.Drawing.Size(453, 20);
            this.textBoxDebitorName.TabIndex = 1;
            // 
            // textBoxDebitorID
            // 
            this.textBoxDebitorID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorID.Location = new System.Drawing.Point(95, 16);
            this.textBoxDebitorID.Name = "textBoxDebitorID";
            this.textBoxDebitorID.ReadOnly = true;
            this.textBoxDebitorID.Size = new System.Drawing.Size(453, 20);
            this.textBoxDebitorID.TabIndex = 0;
            // 
            // NewDebitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 210);
            this.Controls.Add(this.groupBoxDebitorsDetails);
            this.MaximizeBox = false;
            this.Name = "NewDebitor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewDebitor";
            this.groupBoxDebitorsDetails.ResumeLayout(false);
            this.groupBoxDebitorsDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDebitorsDetails;
        private System.Windows.Forms.Button btn_saveNewDebitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDebitorPhoneNumber;
        private System.Windows.Forms.TextBox textBoxDebitorPostIndex;
        private System.Windows.Forms.TextBox textBoxDebitorName;
        private System.Windows.Forms.TextBox textBoxDebitorID;
    }
}