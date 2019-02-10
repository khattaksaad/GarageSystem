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
    public partial class SearchForVehicle : Form
    {
        public SearchForVehicle()
        {
            InitializeComponent();
            comboBox1.Items.Add("Car");
            comboBox1.Items.Add("MotorBike");
            comboBox1.SelectedItem = "Car";
            this.Icon = Properties.Resources.parking;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string licNum = textBoxLicNum.Text.Trim();
            if (licNum.Length > 0)
            {
                Vehicle v = new Vehicle(licNum,comboBox1.SelectedItem.ToString());
                string res = ParkingMain.findVehicle(v);
                if (res.Split('/')[1] != "-1")
                {
                    string level = res.Split('/')[0];
                    string slotNum = res.Split('/')[1];
                    MessageBox.Show(String.Format("The vehicle is parked at Level : {0} and spot number {1} ",level,slotNum));
                }
                else
                    MessageBox.Show("This vehicle is not parked here...!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
