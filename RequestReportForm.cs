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
    public partial class RequestReportForm : Form
    {
        RequestCrystalReport CR = new RequestCrystalReport();
        public RequestReportForm()
        {
            InitializeComponent();
        }

        private void RequestReportForm_Load(object sender, EventArgs e)
        {
           
            crystalReportViewer1.ReportSource = CR;
            crystalReportViewer1.RefreshReport();
        }
    }
}
