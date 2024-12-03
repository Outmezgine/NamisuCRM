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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        Operation Op = new Operation();
        String query;
        
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into ProductTBL values('"+IdTB.Text+"','" + productNameTB.Text + "','" + productPriceTB.Text + "','" +productCategoryCB.SelectedItem.ToString() + "')";
                Op.insertData(query);
                
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
    
        }

        private void AdminMenuDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = AdminMenuDGV.SelectedRows[0].Cells[0].Value.ToString();
            productNameTB.Text = AdminMenuDGV.SelectedRows[0].Cells[1].Value.ToString();
            productPriceTB.Text = AdminMenuDGV.SelectedRows[0].Cells[2].Value.ToString();
            productCategoryCB.SelectedItem = AdminMenuDGV.SelectedRows[0].Cells[3].Value.ToString();
        }
        Operation Opp = new Operation();
        String myQuery;
        private void AdminForm_Load(object sender, EventArgs e)
        {
            myQuery = "select * from ProductTBL";
            var ds = Opp.populate(myQuery);
            AdminMenuDGV.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from ProductTBL where ID = "+IdTB.Text+"";
                Op.deleteProd(query);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void AdminMenuDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = AdminMenuDGV.SelectedRows[0].Cells[0].Value.ToString();
            productNameTB.Text = AdminMenuDGV.SelectedRows[0].Cells[1].Value.ToString();
            productPriceTB.Text = AdminMenuDGV.SelectedRows[0].Cells[2].Value.ToString();
            productCategoryCB.SelectedItem = AdminMenuDGV.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
