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
    public partial class BookTrip : Form
    {
        string constr = "Data Source=orcl;User Id=hr;Password=hr;";

        OracleConnection conn;
        public BookTrip()
        {
            InitializeComponent();
        }

        private void BookTripClick_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"Insert Into booktrip 
                                values(SequenceBookTrip.nextval,:LocationName,:Destination,
                                      :VehicleType ,:BusNumber,
                                      :Driver ,:Phone,:PaymentMethod,:Pay,:DateTrip)";

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("LocationName", Loc.Text);
            cmd.Parameters.Add("Destination", AllDestination.Text);
            cmd.Parameters.Add("VehicleType", BusVehicle.Text);
            cmd.Parameters.Add("BusNumber", CarNumber.Text);
            cmd.Parameters.Add("Driver", allDriverName.SelectedItem.ToString());
            cmd.Parameters.Add("Phone", DriverPhoneNumber.Text);
            cmd.Parameters.Add("PaymentMethod", WalletPaying.Text);
            cmd.Parameters.Add("Pay", Convert.ToInt32(PayDriver.Text));
            cmd.Parameters.Add("DateTrip",dateTimePicker1.Text);
            int r = cmd.ExecuteNonQuery();
            BookTripDetails bookTripDetails = new BookTripDetails();
            if (r != -1) 
            {
                string cmdstr1 = @"Select * From booktrip 
                                      WHERE LOCATIONNAME =:LocationName
                                      AND DESTINATION=:des
                                      AND VEHICLETYPE=:TypeVehicle
                                      AND VEHICLENUMBER=:NumberVehicle
                                      AND DRIVERNAME=:NameDriver
                                      AND PHONE=:phone";

                OracleDataAdapter adapter1 = new OracleDataAdapter(cmdstr1, constr);
                adapter1.SelectCommand.Parameters.Add("LocationName", Loc.Text);
                adapter1.SelectCommand.Parameters.Add("des", AllDestination.Text);
                adapter1.SelectCommand.Parameters.Add("TypeVehicle", BusVehicle.Text);
                adapter1.SelectCommand.Parameters.Add("NumberVehicle", CarNumber.Text);
                adapter1.SelectCommand.Parameters.Add("NameDriver", allDriverName.Text);
                adapter1.SelectCommand.Parameters.Add("phone", DriverPhoneNumber.Text);


                DataSet dataSet1 = new DataSet();
                adapter1.Fill(dataSet1);
                DataTable table1 = dataSet1.Tables[0];


                foreach (DataRow row in table1.Rows)
                {
                    bookTripDetails.passingvalue = Convert.ToInt32(row["BOOKID"].ToString());
                    break;
                }
                this.Hide();
                bookTripDetails.ShowDialog();
            }
        }

     private void BookTrip_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(constr);
            conn.Open();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            WalletPaying.Text = "Wallet";
            BusVehicle.Text = "Bus";
            string cmdstr1 = "Select DESTINATION From requesttrip";
            string cmdstr2 = "Select DRIVERNAME From busdrivers";
            OracleDataAdapter adapter1 = new OracleDataAdapter(cmdstr1 , constr);
            OracleDataAdapter adapter2 = new OracleDataAdapter(cmdstr2, constr);

            DataSet dataSet1 = new DataSet();
            DataSet dataSet2 = new DataSet();

            adapter1.Fill(dataSet1);
            adapter2.Fill(dataSet2);

            DataTable table1 = dataSet1.Tables[0];
            DataTable table2 = dataSet2.Tables[0];

            foreach (DataRow row in table1.Rows) {
                if (!AllDestination.Items.Contains(row["DESTINATION"])) {
                    AllDestination.Items.Add(row["DESTINATION"]);
                }
            }
            if (BusVehicle.Text != "") {
                foreach (DataRow row in table2.Rows)
                {
                    allDriverName.Items.Add(row["DRIVERNAME"].ToString());
                }
            }

        }

        private void allDriverName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = allDriverName.SelectedItem.ToString();
            string cmdstr1 = @"Select DRIVERPHONE , MYPAY ,  CARNUMBER
                                From busdrivers d , car b 
                                WHERE b.carID = d.BUSID and d.DRIVERNAME=:SelectedItem";
            OracleDataAdapter adapter1 = new OracleDataAdapter(cmdstr1, constr);
            adapter1.SelectCommand.Parameters.Add("SelectedItem", SelectedItem);
            DataSet dataSet1 = new DataSet();
            adapter1.Fill(dataSet1);
            DataTable table1 = dataSet1.Tables[0];
            foreach (DataRow row in table1.Rows)
            {
                CarNumber.Text = row["CARNUMBER"].ToString();
                DriverPhoneNumber.Text = row["DRIVERPHONE"].ToString();
                PayDriver.Text = row["MYPAY"].ToString();
                break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
