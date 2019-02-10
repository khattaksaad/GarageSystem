using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReleaseVehicle : Form
    {
        public ReleaseVehicle()
        {
            InitializeComponent();
            comboBox1.Items.Add("Car");
            comboBox1.Items.Add("MotorBike");
            comboBox1.SelectedItem = "Car";
            this.Icon = Properties.Resources.parking;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string vehicleNumber = textBox1.Text.Trim();
            string type = comboBox1.SelectedItem.ToString();
            if (vehicleNumber.Length > 0 && type!="")
            {
                Vehicle v = new Vehicle(vehicleNumber, type);
                bool k = ParkingMain.ReleaseVehicle(v);
                if (k)
                    MessageBox.Show("Vehicle succeffuly Released...!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("WARNING : Vehicle not in the Garage...!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReleaseVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
