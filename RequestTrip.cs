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
    public partial class Request : Form
    {
        string ordb = "Data Source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public static string location = "";
        public static string des = "";
        public static string VehicleName = "";
        public static string VehicleNumber = "";
        public static string DriverName = "";
        public static string DriverPhone = "";
        public static string pay = "";

        public Request()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.location1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetAllCars";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("car", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (allcars.Items.Contains(dr["cartype"].ToString()) == false) {
                    allcars.Items.Add(dr["cartype"]);
                }
            }
            dr.Close();
        }

        private void allcars_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select DRIVERNAME From driver where carType =:CarType";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("CarType" , allcars.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                allDriver.Items.Add(dr["DRIVERNAME"]);
            }
            dr.Close();
        }

        private void allcars_DropDown(object sender, EventArgs e)
        {
            allDriver.Items.Clear();
        }

        private void requestTrip_Click(object sender, EventArgs e)
        {
            string ChoosePayment = "";
            if (cash.Checked) 
            {
                ChoosePayment = cash.Text;
            } else if (wallet.Checked) 
            {
                ChoosePayment = wallet.Text;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"Insert Into RequestTrip 
                                values(SequenceTripRequest.nextval,:locationName , :destination,
                                      :vehicleType ,:CarNumber , 
                                      :driver ,:paymentMethod,:pay)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("locationName", LOCATION.Text);
            cmd.Parameters.Add("destination", destination.Text);
            cmd.Parameters.Add("vehicleType", allcars.SelectedItem.ToString());
            cmd.Parameters.Add("CarNumber", carNumber.Text);
            cmd.Parameters.Add("driver", allDriver.SelectedItem.ToString());
            cmd.Parameters.Add("paymentMethod", ChoosePayment);
            cmd.Parameters.Add("pay", Convert.ToInt32(PayOfDriver.Text));
            int dr = cmd.ExecuteNonQuery();
            if (dr != -1) {
                location = LOCATION.Text;
                des = destination.Text;
                VehicleName = allcars.SelectedItem.ToString();
                VehicleNumber = carNumber.Text;
                DriverName = allDriver.SelectedItem.ToString();
                pay = PayOfDriver.Text;
            }
            RequestDetails requestDetails1 = new RequestDetails();
            if (requestDetails1 != null)
            {
                OracleCommand cmmd = new OracleCommand();
                cmmd.Connection = conn;

                cmmd.CommandText = "RetrieveTripID";
                cmmd.CommandType = CommandType.StoredProcedure;

                cmmd.Parameters.Add("LocationName", LOCATION.Text);
                cmmd.Parameters.Add("des", destination.Text);
                cmmd.Parameters.Add("TypeVehicle", allcars.Text);
                cmmd.Parameters.Add("NumberVehicle", carNumber.Text);
                cmmd.Parameters.Add("NameDriver", allDriver.Text);
                cmmd.Parameters.Add("payMethd", ChoosePayment);
                cmmd.Parameters.Add("Payment", Convert.ToInt32(PayOfDriver.Text));

                cmmd.Parameters.Add("IdTrip", OracleDbType.Int32, ParameterDirection.Output);
                cmmd.ExecuteNonQuery();
                requestDetails1.passingvalue = Convert.ToInt32(cmmd.Parameters["IdTrip"].Value.ToString());
                this.Hide();
                requestDetails1.ShowDialog();
            }
            //select * FROM requesttrip ORDER By tripid;
        }

        private void allDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetCarAndDriver";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("data", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            string carType = allcars.SelectedItem.ToString();
            string driver = allDriver.SelectedItem.ToString();
            while (dr.Read()) 
            {
                if (dr["CARTYPE"].ToString() == carType && 
                    dr["DRIVERNAME"].ToString() == driver) {
                    carNumber.Text = dr["CARNUMBER"].ToString();
                    PayOfDriver.Text = dr["MYPAY"].ToString();
                    DriverPhone = dr["DRIVERPHONE"].ToString();
                    break;
                }
            }
            dr.Close();
        }

      
    }
}