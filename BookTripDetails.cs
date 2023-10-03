using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber_System
{
    public partial class BookTripDetails : Form
    {
        int BookId;
        string constr = "Data Source=orcl;User Id=hr;Password=hr;";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet dataSet;
        public int passingvalue
        {
            get { return BookId; }
            set { BookId = value; }
        }
        public BookTripDetails()
        {
            InitializeComponent();
        }

        private void BookTripDetails_Load(object sender, EventArgs e)
        {
            string cmdstr1 = "Select * From booktrip where BOOKID=:IDBookTrip";
            adapter = new OracleDataAdapter(cmdstr1, constr);
            adapter.SelectCommand.Parameters.Add("IDBookTrip", passingvalue);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Change_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(dataSet.Tables[0]);
            MessageBox.Show("Updated Successfully");
        }
    }
}
