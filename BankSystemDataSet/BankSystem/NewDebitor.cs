using System;
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

    public partial class NewDebitor : Form
    {

        public Guid DebID
        {
            get {return Guid.NewGuid(); }
         }
        public string DebName
        {
            get {return textBoxDebitorName.Text.Trim().ToString();}
        }

        public string DebPostIndex
        {
            get {return textBoxDebitorPostIndex.Text.Trim().ToString();}          
        }

        public string DebPhoneNumber
        {
            get { return textBoxDebitorPhoneNumber.Text.Trim().ToString(); }
        }

        public NewDebitor()
        {
            InitializeComponent();
            textBoxDebitorID.Text = DebID.ToString();

        }

        private void btn_saveNewDebitor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDebitorName.Text.ToString()) ||
                string.IsNullOrEmpty(textBoxDebitorPostIndex.ToString()))
                DialogResult = DialogResult.Cancel;
            else
                DialogResult = DialogResult.OK;
        }
    }
}
