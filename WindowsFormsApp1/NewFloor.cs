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
    public partial class NewFloor : Form
    {
        public NewFloor()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.parking;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adds level to the current list of levels according to the requriement
            try {
                string name = textBoxName.Text.Trim();
                int cap = Convert.ToInt32(textBoxCap.Text.Trim());
                if (cap <= 0)
                {
                    MessageBox.Show("Capacity should be greated than 0");
                }
                else
                {
                    ParkingMain.levels.Add(new Level(ParkingMain.levels.Count, name, cap));
                    this.Hide();
                    LevelInfo l = new LevelInfo();
                    l.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewFloor_Load(object sender, EventArgs e)
        {

        }
    }
}
