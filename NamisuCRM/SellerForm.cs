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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void TitleMenu_Click(object sender, EventArgs e)
        {

        }
        Operation Op = new Operation();
        String myquery;
        private void SellerForm_Load(object sender, EventArgs e)
        {
  
            myquery = "select * from ProductTBL";
            var ds = Op.populate(myquery);
            PlaceOrderDGV.DataSource = ds.Tables[0];
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void PlaceOrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }
    }
}
