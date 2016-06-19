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
    public partial class NewCredit : Form
    {
        Model model = new Model();
        ArrayList debitors = new ArrayList();


        public NewCredit()
        {
            InitializeComponent();
            tb_CreditID.Text = Guid.NewGuid().ToString();

            
            var allDebitors = model.GetAllDebitors();
            lb_debID.DataSource = allDebitors;
            lb_debName.DataSource = allDebitors;

            btn_saveNewCredit.Enabled = false;
          
        }

        private void tb_creditAmount_TextChanged(object sender, EventArgs e)
        {            
            tb_creditBalance.Text = tb_creditAmount.Text;
        }

        private void btn_saveNewCredit_Click(object sender, EventArgs e)
        {
            if (model.SaveNewCredit(new Guid(tb_CreditID.Text), new Guid(lb_debID.SelectedValue.ToString()), Int32.Parse(tb_creditAmount.Text), decimal.Parse(tb_creditBalance.Text), dateTimeCredit.Value))
                           
                this.DialogResult = DialogResult.OK;
            
            else
                this.DialogResult = DialogResult.Cancel;
        }

        private void tb_creditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar!=8)
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
    }
}
