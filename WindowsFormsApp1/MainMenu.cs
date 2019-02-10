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
    public partial class MainMenu : Form
    {
        public static int selectedFloor = 0;
        public MainMenu()
        {
            InitializeComponent();
            ParkingMain.levels = new List<Level>();
            ParkingMain.levels.Add(new Level(0));
            this.Icon = Properties.Resources.parking;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ParkVehicle_Form pf = new ParkVehicle_Form();
            pf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReleaseVehicle pk = new ReleaseVehicle();
            pk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LevelInfo li = new LevelInfo();
            li.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MangerView mv = new MangerView();
            mv.Show();
        }
    }
}
