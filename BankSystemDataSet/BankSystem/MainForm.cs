using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemDataSet
{
    public partial class MainForm : Form
    {
        Model model = new Model();
        DataSet bankSystemDataSet;
        DataView debitorsView, creditsView, paymentsView;
        public MainForm()
        {
            InitializeComponent();           
            FillDataSet();
            debitorsView = new DataView(bankSystemDataSet.Tables["tableOfDebitors"]);
            creditsView = new DataView(bankSystemDataSet.Tables["tableOfCredits"]);
            paymentsView = new DataView(bankSystemDataSet.Tables["tableOfPayments"]);

            BindingGridData();
            SetDebitorsView();
        }

        private void FillDataSet()
        {
            bankSystemDataSet = model.GetDBData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgv_Debitors.CellEnter += Dgv_Debitors_CellEnter;
            dgv_Credits.CellEnter += Dgv_Credits_CellEnter;
        }

        private void Dgv_Credits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e == null)
            {
                dgv_Payments.DataSource = null;
                return;              
            }
            
                paymentsView.RowFilter = string.Format("CreditID='{0}'", dgv_Credits.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            dgv_Payments.DataSource = paymentsView;
        }

        private void Dgv_Debitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_DebitorID.Text = dgv_Debitors.CurrentRow.Cells["ID"].Value.ToString();
            tb_debitorName.Text = dgv_Debitors.CurrentRow.Cells["Name"].Value.ToString();
            tb_debitorPostIndex.Text = dgv_Debitors.CurrentRow.Cells["PostIndex"].Value.ToString();
            tb_debitorPhoneNumber.Text = dgv_Debitors.CurrentRow.Cells["PhoneNumber"].Value.ToString();

            creditsView.RowFilter = string.Format("DebitorID = '{0}'", dgv_Debitors.CurrentRow.Cells["ID"].Value.ToString());

            if (creditsView.Count == 0)
            {
                Dgv_Credits_CellEnter(null, null);
            }
          
        }

        private void addNewDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDebitor newDebitor = new NewDebitor();
            newDebitor.ShowDialog();


            if (newDebitor.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("New debitor has not been added", "Bank System", MessageBoxButtons.OK);
               
                return;               
            }

            bool success = true;

            try
            {
                DataRow newDebDataRow = bankSystemDataSet.Tables["tableOfDebitors"].NewRow();
                newDebDataRow["ID"] = newDebitor.DebID;
                newDebDataRow["Name"] = newDebitor.DebName;
                newDebDataRow["PostIndex"] = newDebitor.DebPostIndex;
                newDebDataRow["PhoneNumber"] = newDebitor.DebPhoneNumber;
                bankSystemDataSet.Tables["tableOfDebitors"].Rows.Add(newDebDataRow);

                if (!model.SaveChanges(bankSystemDataSet))
                {
                    success = false;
                }
                
               // MessageBox.Show("New debitor has been added successfully", "Bank System", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong fields");

                success = false;
            }

            finally
            {
                if (success)
                MessageBox.Show("New debitor has been added successfully", "Bank System", MessageBoxButtons.OK);
                else
               MessageBox.Show("New debitor has not been added", "Bank System", MessageBoxButtons.OK);

            }
        }

        private void openNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCredit credit = new NewCredit(this.bankSystemDataSet);

            credit.ShowDialog();
            if (credit.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Credit has not been added", "Bank System", MessageBoxButtons.OK);
                return;
            }

            bool success = true;

            try
            {
                DataRow newCredDataRow = bankSystemDataSet.Tables["tableOfCredits"].NewRow();
                newCredDataRow["ID"] = credit.CreditID;
                newCredDataRow["DebitorID"] = credit.DebID;
                newCredDataRow["Amount"] = credit.CreditAmount;
                newCredDataRow["Balance"] = credit.CreditBalance;
                newCredDataRow["OpenDate"] = credit.CreditOpenDate;

                bankSystemDataSet.Tables["tableOfCredits"].Rows.Add(newCredDataRow);

                if (!model.SaveChanges(bankSystemDataSet))
                {
                    success = false;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Wrong fields");
                success = false;
            }
            finally
            {
                if (success)
                    MessageBox.Show("New credit has been added successfully", "Bank System", MessageBoxButtons.OK);
                else
                    MessageBox.Show("New credit has not been added", "Bank System", MessageBoxButtons.OK);

            }
        }

        private void passNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPayment payment = new NewPayment (this.bankSystemDataSet);

            payment.ShowDialog();
            if (payment.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Payment has not been provided", "Bank System", MessageBoxButtons.OK);
                return;
            }

            bool success = true;

            try
            {
                DataRow newPaymentDataRow = bankSystemDataSet.Tables["tableOfPayments"].NewRow();
                newPaymentDataRow["ID"] = payment.PaymentID;
                newPaymentDataRow["CreditID"] = payment.CreditID;
                newPaymentDataRow["Amount"] = payment.PaymentAmount;
                newPaymentDataRow["PaymentDate"] = payment.PaymentDate;
              

                bankSystemDataSet.Tables["tableOfPayments"].Rows.Add(newPaymentDataRow);


                //DataRow creditRow = newPaymentDataRow.GetParentRow("CreditsPayments");
                //DataRow creditRow = bankSystemDataSet.Tables["tableOfCredits"].Rows.Find(payment.CreditID);
                //creditRow.BeginEdit();
                //creditRow["Balance"] = decimal.Parse(creditRow["Balance"].ToString()) - payment.PaymentAmount;
                //creditRow.EndEdit();

                if (!model.SaveChanges(bankSystemDataSet))
                {
                    success = false;
                }

                //model.paymentsDA.Fill(bankSystemDataSet, "tableOfPayments");
                //bankSystemDataSet.Clear();
                model.GetDBData();
            }

            catch (Exception)
            {
                MessageBox.Show("Wrong fields");
                success = false;
            }
            finally
            {
                if (success)
                    MessageBox.Show("New payment has been provided successfully", "Bank System", MessageBoxButtons.OK);
                else
                    MessageBox.Show("New payment has not been provided", "Bank System", MessageBoxButtons.OK);

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string filter = string.Format("Name like '%{0}%'"+
                "AND Convert ([PostIndex], 'System.String') like '%{1}%'"+
                "AND PhoneNumber like '%{2}%'",
                tb_searchName.Text.Trim(),
                tb_searchPhoneNumber.Text.Trim(),
                tb_searchPostIndex.Text.Trim()
                );

            debitorsView.RowFilter = filter;
            dgv_Debitors.DataSource = debitorsView;

            if (debitorsView.Count == 0)
            {
                tb_debitorName.Text = "";
                tb_DebitorID.Text = "";
                tb_debitorPhoneNumber.Text = "";
                tb_debitorPostIndex.Text = "";
                dgv_Payments.DataSource = null;
                dgv_Credits.DataSource = null;
            }

            else
            {
                dgv_Payments.DataSource = paymentsView;
                dgv_Credits.DataSource = creditsView;
            }
        }

        private void SetDebitorsView()
        {
            try
            {
                dgv_Debitors.Columns[0].Visible = false;
                dgv_Debitors.Columns[2].Visible = false;
                dgv_Debitors.Columns[3].Visible = false;
            }
            catch (Exception)
            {
                               throw;
            }

            dgv_Debitors.TopLeftHeaderCell.Value = "#";
        }

        public void BindingGridData()
        {
            if (bankSystemDataSet.Tables.Count > 0)
            {
                dgv_Debitors.DataSource = debitorsView;
                dgv_Credits.DataSource = creditsView;
                dgv_Payments.DataSource = paymentsView;
            }
        }
       
    }
}
