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

namespace BankSystem
{
    public partial class MainForm : Form
    {
        Model model = new Model();
        public MainForm()
        {
            InitializeComponent();

            var allDebitors = model.GetAllDebitors();

            dataGridViewDebitors.DataSource = allDebitors;
            DebitorsViewSettings();            
          
        }


        void DebitorsViewSettings()
        {
            try
            {
                dataGridViewDebitors.Columns["ID"].Visible = false;
                dataGridViewDebitors.Columns["PostIndex"].Visible = false;
                dataGridViewDebitors.Columns["PhoneNumber"].Visible = false;

                dataGridViewDebitors.TopLeftHeaderCell.Value = "#";
            }

            catch (NullReferenceException)
            {
            }
            
        }

        void CreditsViewSettings()
        {
            try
            {
                dataGridViewCredits.Columns["DebitorID"].Visible = false;
            }
            catch (NullReferenceException)
            {

                throw new NullReferenceException();
            }
        }

        void PaymentsViewSettings()
        {
            try
            {
                dataGridViewPayments.Columns["CreditID"].Visible = false;
            }
            catch (NullReferenceException)
            {

                throw new NullReferenceException();
            }
        }

        private void dataGridViewDebitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxDebitorID.Text = dataGridViewDebitors.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxDebitorName.Text = dataGridViewDebitors.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            textBoxDebitorPostIndex.Text = dataGridViewDebitors.Rows[e.RowIndex].Cells["PostIndex"].Value.ToString();

            string phone = dataGridViewDebitors.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
            textBoxDebitorPhoneNumber.Text = (phone == String.Empty) ? "No data" : phone;

            dataGridViewCredits.DataSource = model.GetAllCreditsOfDebitor(dataGridViewDebitors.CurrentRow.Cells["ID"].Value.ToString());
            //return;
            //CreditsViewSettings();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewDebitors.CellEnter += new DataGridViewCellEventHandler(dataGridViewDebitors_CellEnter);
            dataGridViewCredits.CellEnter += new DataGridViewCellEventHandler(dataGridViewCredits_CellEnter);

        }

        private void dataGridViewCredits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string creditID = dataGridViewCredits.CurrentRow.Cells[0].Value.ToString();
            try
            {
                dataGridViewPayments.DataSource=model.GetAllPaymentsForCredit(creditID);
                PaymentsViewSettings();
            }
            catch 
            {
                //throw new Exception();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you really going to exit?", "Bank Manager", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newDebitor = new NewDebitor();
           if ( newDebitor.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show("New debitor has been added successfully", "Bank Manager", MessageBoxButtons.OK);
                dataGridViewDebitors.DataSource = model.GetAllDebitors();
            }
           else
                MessageBox.Show("New debitor has not been added", "Bank Manager", MessageBoxButtons.OK);
        }

        private void openNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCredit newCredit = new NewCredit();
            newCredit.ShowDialog();
            if (newCredit.DialogResult == DialogResult.OK)
            {
                dataGridViewCredits.DataSource = model.GetAllCreditsOfDebitor(dataGridViewDebitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("New credit has been added successfully!", "Bank Manager", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("New credit has not been added", "Bank Manager", MessageBoxButtons.OK);
        }

        private void passNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPayment newPayment = new NewPayment();
            newPayment.ShowDialog();
            if (newPayment.DialogResult == DialogResult.OK)
            {
                dataGridViewCredits.DataSource = model.GetAllCreditsOfDebitor(dataGridViewDebitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("New payment has been passed successfully!", "Bank Manager", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("New payment has not been passed", "Bank Manager", MessageBoxButtons.OK);
        }

        private void saveDataToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (model.SaveDBToFile(model.SaveDBSection))
                MessageBox.Show("Data files has been created successfully", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Data files has not been created", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object rowNumber = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if (rowNumber == null || !rowNumber.Equals(((e.RowIndex + 1)).ToString()))
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }


       
        private void btn_Search_Click(object sender, EventArgs e)
        {
            var searchList = new List<DataGridViewRow>();
            //var searchList = new ArrayList();
            string debitorsName = tb_searchName.Text.Trim().ToString();
            string postIndex = tb_searchPostIndex.Text.Trim().ToString();
            string phoneNumber = tb_searchPhoneNumber.Text.Trim().ToString();

            //dataGridViewDebitors.CurrentCell = null;
            //foreach (DataGridViewRow row in dataGridViewDebitors.Rows)
            //{
            //    row.Visible = (row.Cells["Name"].Value.ToString().Contains(debitorsName) &&
            //         row.Cells["PostIndex"].Value.ToString().Contains(postIndex) &&
            //         row.Cells["PhoneNumber"].Value.ToString().Contains(phoneNumber));
            //        searchList.Add(row);
            //}

            dataGridViewDebitors.DataSource = model.SearchDebitor(debitorsName, postIndex, phoneNumber);

            textBoxDebitorID.Text = null;
            textBoxDebitorName.Text = null;
            textBoxDebitorPostIndex.Text = null;
            textBoxDebitorPhoneNumber.Text = null;

           

            //if (searchList.Count == 0)
            //{
            //    MessageBox.Show("No debitors has been found");
            //    //btn_searchNext.Enabled = false;
            //    return;
            //}

            // MessageBox.Show(searchList.Count + " users has been found");
            //foreach (DataGridViewRow row in dataGridViewDebitors.Rows)
            //{
            //    foreach (DataGridViewRow listItem in searchList)
            //        if (listItem.Index == row.Index)
            //            row.Visible = true;
            //        else row.Visible = false;
            //}
            //for (int i=0; i <= dataGridViewDebitors.Rows.Count; i++)
            //{
            //    dataGridViewDebitors.Rows[i].Visible=
            //}
           
        }

        private void tb_search_Enter(object sender, EventArgs e)
        {
            if (tb_searchName.Text == "Debitor's name" &&
                tb_searchPostIndex.Text == "Debitor's post index" &&
                tb_searchPhoneNumber.Text == "Debitor's phone number")
            {
                tb_searchName.Text = "";
                tb_searchPhoneNumber.Text = "";
                tb_searchPostIndex.Text = "";
            }
        }

        //private void btn_searchNext_Click(object sender, EventArgs e)
        //{
        //    currentRow++;
        //    dataGridViewDebitors.CurrentCell=searchList
        //}
    }
}
