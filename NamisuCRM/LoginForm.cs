using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamisuCRM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.CheckState == CheckState.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "RamOut" && textBoxPassword.Text == "2244")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("טעות בפרטים, אין לך גישה כאדמין למערכת");
            }
        }
    }
}
