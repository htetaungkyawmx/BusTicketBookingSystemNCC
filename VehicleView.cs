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
    public partial class VehicleView : Form
    {
        BusDSTableAdapters.vehicleTableAdapter adapter = new BusDSTableAdapters.vehicleTableAdapter();

        public VehicleView()
        {
            InitializeComponent();
        }

        private void VehicleView_Load(object sender, EventArgs e)
        {
            vehiclegrid.DataSource = adapter.GetData(); // Load data into the DataGridView
        }
    }
}
