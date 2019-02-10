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
    public partial class LevelInfo : Form
    {
        public LevelInfo()
        {
            InitializeComponent();
            comboBox1.DataSource = ParkingMain.levels;
            comboBox1.DisplayMember = "level_Number";
            comboBox1.ValueMember = "level_Name";
            totalCapText.Text = ParkingMain.levels[MainMenu.selectedFloor].totalCapacity.ToString();
            avlCapText.Text = ParkingMain.levels[MainMenu.selectedFloor].availableCapacity.ToString();
            this.Icon = Properties.Resources.parking;
        }

        private void LevelInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gets updated capacity from user and updates the list of levels for the specified level and its updated capacity
            string incCapacity = Interaction.InputBox("Please Enter the updated capacity ", "").Trim();
            if (incCapacity.Length > 0)
            {
                try
                {
                    int inCapacity = Convert.ToInt32(incCapacity);
                    if (inCapacity > Convert.ToInt32(totalCapText.Text))
                    {
                        ParkingMain.levels[MainMenu.selectedFloor].setAvailableCapacity(inCapacity);
                        totalCapText.Text = ParkingMain.levels[MainMenu.selectedFloor].totalCapacity.ToString();
                        avlCapText.Text = ParkingMain.levels[MainMenu.selectedFloor].availableCapacity.ToString();
                    }
                    else
                        MessageBox.Show("Entered Parking capacity is less than the current capacity of this floor");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainMenu.selectedFloor = comboBox1.SelectedIndex;
            totalCapText.Text = ParkingMain.levels[MainMenu.selectedFloor].totalCapacity.ToString();
            avlCapText.Text = ParkingMain.levels[MainMenu.selectedFloor].availableCapacity.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewFloor nf = new NewFloor();
            this.Close();
            nf.Show();
        }
    }
}
