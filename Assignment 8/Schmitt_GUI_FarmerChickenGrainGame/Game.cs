using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schmitt_GUI_FarmerChickenGrainGame
{
    public partial class Game : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        public Game()
        {
            InitializeComponent();
            Farmer.Click += Farmer_Click;
            Fox.Click += Fox_Click;
            Chicken.Click += Chicken_Click;
            Grain.Click += Grain_Click;

        }

        private void Farmer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Farmer Clicked");
        }

        private void Fox_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Fox Clicked");
        }

        private void Chicken_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Chicken Clicked");
        }

        private void Grain_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Grain Clicked");
        }

        private void Water_Click(object sender, EventArgs e) { }
    }
}
