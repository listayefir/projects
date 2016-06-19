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

namespace BankSystem
{
    public partial class NewPayment : Form
    {
        Model model = new Model();
        ArrayList allDebitors = new ArrayList();
        ArrayList allCreditsOfDebitor = new ArrayList();

        public NewPayment()
        {
            InitializeComponent();
            tb_paymentID.Text = Guid.NewGuid().ToString();

            allDebitors = model.GetAllDebitors();
            if (allDebitors == null || allDebitors.Count == 0)
            {
                btn_saveNewPayment.Enabled = false;
                tb_paymentAmount.Enabled = false;
            }


            lb_debID.DataSource = allDebitors;
            lb_debName.DataSource = allDebitors;

        }

        private void lb_debitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            allCreditsOfDebitor = model.GetAllCreditsOfDebitor(lb_debID.SelectedValue.ToString());

            if (allCreditsOfDebitor == null || allCreditsOfDebitor.Count == 0)
            {
                btn_saveNewPayment.Enabled = false;
                tb_paymentAmount.Enabled = false;
            }
            else
            {
                btn_saveNewPayment.Enabled = true;
                tb_paymentAmount.Enabled = true;
            }

            lb_CreditID.DataSource = allCreditsOfDebitor;
            lb_creditAmount.DataSource = allCreditsOfDebitor;
            lb_creditBalance.DataSource = allCreditsOfDebitor;

            lb_CreditID.DisplayMember = "ID";
            lb_CreditID.ValueMember = "ID";
            lb_creditAmount.DisplayMember = "Amount";
            lb_creditAmount.ValueMember = "ID";
            lb_creditBalance.DisplayMember = "Balance";
            lb_creditBalance.ValueMember = "Balance";

            
            
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
                if (tb_paymentAmount.Text.Length > tb_paymentAmount.Text.IndexOf(',') + 2 && e.KeyChar!=8)
                    e.Handled=true;
                
            }
        }

        private void tb_paymentAmount_Leave(object sender, EventArgs e)
        {
            if (tb_paymentAmount.Text.Trim()==string.Empty)
            {
                lbl_amountControl.Text = "Enter payment amount";
                lbl_amountControl.ForeColor = Color.Red;
                btn_saveNewPayment.Enabled = false;
               return;
            }

            var payValue = decimal.Parse(tb_paymentAmount.Text.Trim());

            if (payValue<100 || payValue > decimal.Parse(lb_creditBalance.SelectedValue.ToString()))
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

        private void btn_saveNewPayment_Click(object sender, EventArgs e)
        {
            decimal paymentAmount;
            if (!decimal.TryParse(tb_paymentAmount.Text.Trim(), out paymentAmount))
            {
                MessageBox.Show("Invalid payment amount", "Bank Messenger", MessageBoxButtons.OK);
                return;
            }

            if (model.SaveNewPayment(new Guid(tb_paymentID.Text.Trim()), new Guid(lb_CreditID.SelectedValue.ToString()), paymentAmount, dateTimePayment.Value))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
                                                 
        }
    }
}
