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
    public partial class Staff : Form
    {
        BusDSTableAdapters.staffTableAdapter adapter = new BusDSTableAdapters.staffTableAdapter();

        public Staff()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close(); // Close the current form
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int SID = random.Next(); // Generates a non-negative random integer

            clsStaff clsStaff = new clsStaff();

            clsStaff.StaffID = SID.ToString();
            clsStaff.Name = name.Text;
            clsStaff.Email = email.Text;
            clsStaff.Position = position.Text;
            clsStaff.Phone = phone.Text;
            clsStaff.Address = address.Text;
            clsStaff.DateOfBirth = dob.Value;
            clsStaff.DateOfEmployment = doe.Value;

            int data = adapter.Insert(clsStaff.StaffID, clsStaff.Name, clsStaff.Email, clsStaff.Position, clsStaff.DateOfBirth, clsStaff.DateOfEmployment, clsStaff.Phone, clsStaff.Address);

            if(data > 0)
            {
                MessageBox.Show("Staff Entry Successfully", "Staff Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add staff entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
