using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace WindowsFormsApp1
{
    public partial class MangerView : Form
    {
        public MangerView()
        {
            InitializeComponent();
            comboBox1.DataSource = ParkingMain.levels;
            comboBox1.DisplayMember = "level_Number";
            comboBox1.ValueMember = "level_Name";
            textBoxCap.Text = ParkingMain.levels[MainMenu.selectedFloor].totalCapacity.ToString();
            textBoxACap.Text = ParkingMain.levels[MainMenu.selectedFloor].availableCapacity.ToString();
            this.Icon = Properties.Resources.parking;
            int totalSpots = 0;
            for (int i = 0; i < ParkingMain.levels.Count; i++)
            {
                totalSpots += ParkingMain.levels[i].availableCapacity;
            }
            textBoxTotalSpots.Text = totalSpots.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForVehicle sv = new SearchForVehicle();
            sv.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainMenu.selectedFloor = comboBox1.SelectedIndex;
            textBoxCap.Text = ParkingMain.levels[MainMenu.selectedFloor].totalCapacity.ToString();
            textBoxACap.Text = ParkingMain.levels[MainMenu.selectedFloor].availableCapacity.ToString();
        }

        private void MangerView_Load(object sender, EventArgs e)
        {

        }
    }
}
