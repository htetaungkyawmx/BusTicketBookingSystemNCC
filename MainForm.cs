using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketBookingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Close(); // Close the current form
            Application.Exit(); // Ensure the application exits completely
        }

        private void mnuRoute_Click(object sender, EventArgs e)
        {
            Route r = new Route();
            r.Show();
        }

        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
        }

        private void mnuVehicleClick_Click(object sender, EventArgs e)
        {
            Vehicle v = new Vehicle();
            v.Show();
        }

        private void vehicleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleView vehicleView = new VehicleView();
            vehicleView.Show();
        }
    }
}
