using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Uber_System
{
    public partial class RequestDetails : Form
    {
        int TripId;
        int RetriveId;
        string ordb = "Data Source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public RequestDetails()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.location1;
        }
        public int passingvalue
        {

            get { return TripId; }
            set { TripId = value; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string TRIPID = "" + TripId.ToString();
            RetriveId = Convert.ToInt32(TRIPID);
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * FROM requesttrip where tripid=:IdTRIP";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("IdTRIP", RetriveId);
            OracleDataReader dr = cmd.ExecuteReader();

            OracleCommand cmdd = new OracleCommand();
            cmdd.Connection = conn;
            if (dr.Read()) {
                location.Text = dr["locationName"].ToString();
                destination.Text = dr["destination"].ToString();
                vehicle.Text = dr["vehicleType"].ToString();
                driver.Text = dr["driverName"].ToString();
                car_number.Text = dr["vehicleNumber"].ToString();
                paymethod.Text = dr["payementMethod"].ToString();
                pay.Text = dr["pay"].ToString();
                cmdd.CommandText = "Select driverPhone FROM driver where driverName=:name";
                cmdd.Parameters.Add("name", driver.Text);
                OracleDataReader r = cmdd.ExecuteReader();
                if (r.Read()) {
                    phone.Text = r["driverPhone"].ToString();
                }
                r.Close();

            }
            dr.Close();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete FROM requesttrip where tripid=:TRIPID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("TRIPID", RetriveId);
            int r = cmd.ExecuteNonQuery();
            if (r != -1) {
                location.Text = "";
                destination.Text = "";
                vehicle.Text = "";
                driver.Text = "";
                phone.Text = "";
                car_number.Text = "";
                paymethod.Text = "";
                pay.Text = "";
                MessageBox.Show("Cancelling Trip Successfully.");
                this.Hide();
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"Update requesttrip set 
                                      LOCATIONNAME=:LocName,
                                      DESTINATION=:Des,
                                      PAYEMENTMETHOD=:PAYMethod
                                      Where tripid=:NewTRIPID";

            //cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("LocName", location.Text);
            cmd.Parameters.Add("Des", destination.Text);
            cmd.Parameters.Add("PAYMethod", paymethod.SelectedItem.ToString());
            cmd.Parameters.Add("NewTRIPID", RetriveId);
            int r = cmd.ExecuteNonQuery();
            if (r != -1) 
            {
                MessageBox.Show("Update Trip Successfully.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
