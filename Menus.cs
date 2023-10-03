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
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void requstTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.ShowDialog();
        }

        private void bookTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookTrip bookTrip = new BookTrip();
            bookTrip.ShowDialog();
        }

        private void requestReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestReportForm crf = new RequestReportForm();
            crf.ShowDialog();
        }

        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReportForm bcr = new BookReportForm();
            bcr.ShowDialog();
        }
    }
}
