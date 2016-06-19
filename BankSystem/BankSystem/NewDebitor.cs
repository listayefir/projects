using System;
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
    public partial class NewDebitor : Form
    {
        Model model = new Model();
        public NewDebitor()
        {
            InitializeComponent();
            textBoxDebitorID.Text = Guid.NewGuid().ToString();
        }

        private void btn_saveNewDebitor_Click(object sender, EventArgs e)
        {
           if ( model.SaveNewDebitor(textBoxDebitorID.Text.Trim(), textBoxDebitorName.Text.Trim(), textBoxDebitorPostIndex.Text.Trim(), textBoxDebitorPhoneNumber.Text.Trim())== true)
                this.DialogResult = DialogResult.OK;
           else 
            this.DialogResult = DialogResult.Cancel;
          
        }
    }
}
