using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BankSystemDataSet
{
    public partial class NewPayment : Form
    {
        DataView creditsDV;
        DataSet bankSystemDataSet;
        public Guid CreditID { get; private set; }
        public Guid PaymentID { get { return Guid.NewGuid(); } }
        public decimal PaymentAmount { get { return decimal.Parse(tb_paymentAmount.Text.Trim().ToString()); } }
        public DateTime PaymentDate { get { return dateTimePayment.Value; } }

        public NewPayment(DataSet bankSystemDataSet)
        {
            InitializeComponent();
            creditsDV = new DataView(bankSystemDataSet.Tables["tableOfCredits"]);
            this.bankSystemDataSet = bankSystemDataSet;
            tb_paymentID.Text = PaymentID.ToString();
            lb_debName.DataSource = bankSystemDataSet.Tables["tableOfDebitors"];
            lb_debID.DataSource=bankSystemDataSet.Tables["tableOfDebitors"];

            lb_CreditID.DataSource = creditsDV;
            lb_creditAmount.DataSource = creditsDV;
            lb_creditBalance.DataSource = creditsDV;
        }

        private void tb_paymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                if (tb_paymentAmount.Text.Trim().Contains(',') || tb_paymentAmount.Text == string.Empty)
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                    return;
                }
            }

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;

            if (tb_paymentAmount.Text.Contains(','))
            {
                if (tb_paymentAmount.Text.Length > tb_paymentAmount.Text.IndexOf(',') + 2 && e.KeyChar != 8)
                    e.Handled = true;

            }
        }

        private void tb_paymentAmount_Leave(object sender, EventArgs e)
        {
            if (tb_paymentAmount.Text.Trim() == string.Empty)
            {
                lbl_amountControl.Text = "Enter payment amount";
                lbl_amountControl.ForeColor = Color.Red;
                btn_saveNewPayment.Enabled = false;
                return;
            }

            var payValue = decimal.Parse(tb_paymentAmount.Text.Trim());

            if (payValue < 100 || payValue > decimal.Parse(lb_creditBalance.SelectedValue.ToString()))
            {
                lbl_amountControl.Text = "Invalid payment amount";
                lbl_amountControl.ForeColor = Color.Red;
                btn_saveNewPayment.Enabled = false;

            }

            else
            {
                lbl_amountControl.Text = "Payment amount is valid";
                lbl_amountControl.ForeColor = Color.Green;
                btn_saveNewPayment.Enabled = true;
                // return;
            }
        }

        private void lb_debitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_debName.SelectedIndex == -1)
            {              
                return;
            }
            DataRow selectedDebitor = this.bankSystemDataSet.Tables["tableOfDebitors"].Rows[lb_debName.SelectedIndex];
            creditsDV.RowFilter = string.Format("DebitorID = '{0}'", selectedDebitor["ID"].ToString());

        }

      

        private void btn_saveNewPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_paymentAmount.Text.ToString()))
                DialogResult = DialogResult.Cancel;
            else
            {
                CreditID = new Guid(lb_CreditID.SelectedValue.ToString());
                DialogResult = DialogResult.OK;
            }
                
        }
    }
}
