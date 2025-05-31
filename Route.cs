using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BusTicketBookingSystem
{
    public partial class Route : Form
    {
        BusDSTableAdapters.routeTableAdapter adapter = new BusDSTableAdapters.routeTableAdapter();

        public Route()
        {
            InitializeComponent();
        }

        private void Route_Load(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = adapter.GetData(); // Load data into the DataGridView
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;  
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); // Close the current form
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            string RouteFrom, RouteTo, RouteType;
            Decimal Price;

            RouteFrom = routeFrom.Text;
            RouteTo = routeTo.Text;
            Price = Convert.ToDecimal(price.Text);
            RouteType = cboRouteType.Text;

            if (RouteFrom == "")
            {
                MessageBox.Show("Please Enter Route From", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                routeFrom.Focus();
            }
            else if (RouteTo == "")
            {
                MessageBox.Show("Please Enter Route To", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                routeTo.Focus();
            }
            else if (price.Text == "")
            {
                MessageBox.Show("Please Enter Price", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                price.Focus();
            }
            else if (cboRouteType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Route Type", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRouteType.Focus();
            }
            else {
                int data = adapter.Insert(RouteFrom, RouteTo, RouteFrom, Price, RouteType);
                if (data > 0) {
                    dgvDisplay.DataSource = adapter.GetData();
                    MessageBox.Show("Route Save Successful", "ROute ENtry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    routeFrom.Text = "";
                    routeTo.Text = "";
                    price.Text = "";
                    cboRouteType.SelectedIndex = -1;
                    routeFrom.Focus();
                }
            }

            //int data = adapter.Insert(, SName, SEmail, SPosition, DOB, DOE, SPhone, SAddress);



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(DDATA);
            int data = adapter.DeleteQuery(Route_ID);
            if (data > 0)
            {
                MessageBox.Show("Delete Route Successful", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDisplay.DataSource = dt;
            }
        }

        int DDATA;
        DataTable dt = new DataTable();
        string Route_ID;
        string dtRoute;
        string rID;

        private void dgvGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtRoute = new DataTable();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;

            dt = adapter.GetData();
            DDATA = dgvDisplay.CurrentRow.Index;
            Route_ID = dt.Rows[DDATA][0].ToString();
            dtRoute = adapter.SelectRoute(Route_ID);
            if (dtRoute.Rows.Count > 0)
            {
                routeFrom.Text = dtRoute.Rows[0][1].ToString();
                routeTo.Text = dtRoute.Rows[0][2].ToString();
                price.Text = dtRoute.Rows[0][3].ToString();
                cboRouteType.Text = dtRoute.Rows[0][4].ToString();
            }
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           

            if (routeFrom.Text == "")
            {
                MessageBox.Show("Please Enter Route From", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                routeFrom.Focus();
            }

            else if (routeTo.Text == "")
            {
                MessageBox.Show("Please Enter Route To", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                routeTo.Focus();
            }

            else if (price.Text == "")
            {
                MessageBox.Show("Please Enter Price", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                price.Focus();
            }

            else if (cboRouteType.Text == "")
            {
                MessageBox.Show("Please Enter Route Type", "Route Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRouteType.Focus();
            }

            else
            {
                string rFrom, rTo, rType;
                decimal Price;

                rFrom = routeFrom.Text;
                rTo = routeTo.Text;
                Price = Convert.ToDecimal(price.Text);
                rType = cboRouteType.Text;
                int data = adapter.UpdateQuery(rFrom, rTo, Price, rType, Route_ID);
                if (data > 0)
                {
                    MessageBox.Show("Update Route Successdful!!!");
                    dgvDisplay.DataSource = adapter.GetData();
                }

            }
        }
    }
}
