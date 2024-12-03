using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamisuCRM
{
    class Operation
    {
        protected OleDbConnection getCon()
        {
            OleDbConnection Con = new OleDbConnection();
            Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\doutm\OneDrive\Documents\NamisuDB.accdb";

            return Con;
        }

        public void insertData(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("המוצר נוסף בהצלחה");
            Con.Close();
        }

        //Methodto display data in datagidview

        public DataSet populate (String query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Con;
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public void deleteProd(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("המוצר נמחק בהצלחה");
            Con.Close();
        }
    }

}
