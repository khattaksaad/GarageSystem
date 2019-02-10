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
    public partial class ParkVehicle_Form : Form
    {
        public ParkVehicle_Form()
        {
            InitializeComponent();
            comboBox1.Items.Add("Car");
            comboBox1.Items.Add("MotorBike");
            comboBox1.SelectedItem = "Car";
            this.Icon = Properties.Resources.parking;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vehicleNumber = textBox1.Text.Trim();
            string type = comboBox1.SelectedItem.ToString();

            if (vehicleNumber.Length > 0 && type != "")
            {
                Vehicle v = new Vehicle(vehicleNumber, type);
                int k = ParkingMain.parkVehicle(v);
                switch (k)
                {
                    case 0:
                        MessageBox.Show("Vehicle already parked in the Garage...!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        break;
                    case 1:
                        MessageBox.Show("Vehicle parked successfully in the Garage...!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        break;
                    case -1:
                        MessageBox.Show("WARNING : Not enough space in the garage, vehicle cannot be parked!","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        break;

                }
            }
            
        }

        private void ParkVehicle_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
