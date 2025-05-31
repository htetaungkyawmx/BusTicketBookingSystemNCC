using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BusTicketBookingSystem
{
    public partial class Vehicle : Form
    {
        BusDSTableAdapters.vehicleTableAdapter adapter = new BusDSTableAdapters.vehicleTableAdapter();
        public Vehicle()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = adapter.GetData();
            delete.Enabled = false;
            update.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsVehicle cv = new clsVehicle();

            cv.cVehicle_ID = textBox1.Text;
            cv.cVehicle_Name = VehicleName.Text;
            cv.cVehicle_Type = VehicleType.Text;
            cv.cTotal_Seat = Convert.ToInt32(totalSeat.Value);
           



            int data = adapter.Insert(cv.cVehicle_ID,cv.cVehicle_Name,cv.cVehicle_Type,cv.cTotal_Seat);

            if (data > 0)
            {
                MessageBox.Show("Vehicle Entry Successfully", "Vehicle Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        int DDATA;
        DataTable dt = new DataTable();
        string Vehicle_ID;

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            DataTable dtVehicle = new DataTable();

            update.Enabled = true;
            delete.Enabled = true;
            btnSave.Enabled = false;

            dt = adapter.GetData();
            DDATA = dgvDisplay.CurrentRow.Index;
            Vehicle_ID = dt.Rows[DDATA][0].ToString();
            dtVehicle = adapter.GetDataBy(Vehicle_ID);
            if (dtVehicle.Rows.Count > 0)
            {
                textBox1.Text = dtVehicle.Rows[0][0].ToString();
                VehicleName.Text = dtVehicle.Rows[0][1].ToString();
                totalSeat.Text = dtVehicle.Rows[0][2].ToString();
                VehicleType.Text = dtVehicle.Rows[0][3].ToString();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Route ID", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }

            else if (VehicleName.Text == "")
            {
                MessageBox.Show("Please Enter Route From", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VehicleName.Focus();
            }

            else if (totalSeat.Text == "")
            {
                MessageBox.Show("Please Enter Route To", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalSeat.Focus();
            }

            else if (VehicleType.Text == "")
            {
                MessageBox.Show("Please Enter Price", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VehicleType.Focus();
            }

            else
            {
                string vID, vName, vType;
                int tSeat;

                vID = textBox1.Text;
                vName = VehicleName.Text;
                tSeat = Convert.ToInt32(totalSeat.Text);
                vType = VehicleType.Text;
                int data = adapter.UpdateQuery( vName, tSeat, vType, vID);
                if (data > 0)
                {
                    MessageBox.Show("Update Route Successdful!!!");
                    dgvDisplay.DataSource = adapter.GetData();
                }
            }
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtVehicle = new DataTable();

            update.Enabled = true;
            delete.Enabled = true;
            btnSave.Enabled = false;

            dt = adapter.GetData();
            DDATA = dgvDisplay.CurrentRow.Index;
            Vehicle_ID = dt.Rows[DDATA][0].ToString();
            dtVehicle = adapter.GetDataBy(Vehicle_ID);
            if (dtVehicle.Rows.Count > 0)
            {
                textBox1.Text = dtVehicle.Rows[0][0].ToString();
                VehicleName.Text = dtVehicle.Rows[0][1].ToString();
                totalSeat.Text = dtVehicle.Rows[0][2].ToString();
                VehicleType.Text = dtVehicle.Rows[0][3].ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(DDATA);
            int data = adapter.DeleteQuery(Vehicle_ID);
            if (data > 0)
            {
                MessageBox.Show("Delete Route Successful", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDisplay.DataSource = dt;
            }
        }
    }
}
