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
    public partial class NewCredit : Form
    {
        public Guid CreditID {get { return Guid.NewGuid(); } }
        public Guid DebID { get { return new Guid (lb_debID.SelectedValue.ToString()); } }
        public Int64 CreditAmount { get {return Int64.Parse(tb_creditAmount.Text.Trim().ToString()); } }
        public decimal CreditBalance { get { return decimal.Parse(tb_creditBalance.Text.Trim().ToString()); } }
        public DateTime CreditOpenDate { get {return DateTime.Parse(dateTimeCredit.Value.ToString()); } }



        public NewCredit(DataSet bankSystemDataSet)
        {
            InitializeComponent();
            tb_CreditID.Text = CreditID.ToString();

            lb_debID.DataSource = bankSystemDataSet.Tables["tableOfDebitors"];
            lb_debName.DataSource = bankSystemDataSet.Tables["tableOfDebitors"];
        }

        private void btn_saveNewCredit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_creditAmount.Text))
                this.DialogResult = DialogResult.OK;

            else
                this.DialogResult = DialogResult.Cancel;
        }

        private void tb_creditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tb_creditAmount_Leave(object sender, EventArgs e)
        {
            if (Int64.Parse(tb_creditAmount.Text) < 100 ||
                Int64.Parse(tb_creditAmount.Text) > 1000000 || string.IsNullOrEmpty(tb_creditAmount.Text))
            {
                lbl_verifyAmount.Text = "Forbidden amount of credit";
                lbl_verifyAmount.ForeColor = Color.Red;
            }
            else
            {
                lbl_verifyAmount.Text = "Credit amount is valid";
                lbl_verifyAmount.ForeColor = Color.Green;
                btn_saveNewCredit.Enabled = true;
            }
        }

        private void tb_creditAmount_TextChanged(object sender, EventArgs e)
        {
            tb_creditBalance.Text = tb_creditAmount.Text;
        }
    }
}
