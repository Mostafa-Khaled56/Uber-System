using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Uber_System
{
    public partial class BookReportForm : Form
    {
        BookCrystalReport bcr;


        public BookReportForm()
        {
            InitializeComponent();
        }

        private void BookReportForm_Load(object sender, EventArgs e)
        {
            bcr = new BookCrystalReport();
            foreach (ParameterDiscreteValue v in bcr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            bcr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource =bcr;
          
        }



       }
    }
