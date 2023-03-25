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
        const int IMAGE_OFFSET = 32;

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

        /// <summary>
        /// Updates the farmer's position
        /// </summary>
        private void UpdateFarmerPosition()
        {
            bool farmerPos = FarmerUI.GetAndUpdateFarmerPosition();

            if (farmerPos)
            {
                //Move farmer
                Farmer.Location = new Point(Farmer.Location.X, Height - (IMAGE_OFFSET + Farmer.Height + IMAGE_OFFSET));
            }
            else
            {
                //Move Farmer
                Farmer.Location = new Point(Farmer.Location.X, IMAGE_OFFSET);
            }
        }

        /// <summary>
        /// Disables the clickability of images that are unreachable to the farmer
        /// </summary>
        private void DisableUnreachableItems()
        {
            bool farmerPos = FarmerUI.GetFarmerPosition();

            //Enable/Disable items
            Fox.Enabled = farmerPos == FarmerUI.GetFoxPosition();
            Chicken.Enabled = farmerPos == FarmerUI.GetChickenPosition();
            Grain.Enabled = farmerPos == FarmerUI.GetGrainPosition();
        }

        //If clicked only update the farmer's position
        private void Farmer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Farmer Clicked");

            UpdateFarmerPosition();
            DisableUnreachableItems();
        }

        //If clicked update the farmer and fox position
        private void Fox_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Fox Clicked");

            UpdateFarmerPosition();

            if (FarmerUI.GetAndUpdateFoxPosition())
            {
                Fox.Location = new Point(Fox.Location.X, Height - (IMAGE_OFFSET + Fox.Height + IMAGE_OFFSET));
            }
            else
            {
                Fox.Location = new Point(Fox.Location.X, IMAGE_OFFSET);
            }

            DisableUnreachableItems();
        }


        //If clicked update the farmer and chicken position
        private void Chicken_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Chicken Clicked");

            UpdateFarmerPosition();

            if (FarmerUI.GetAndUpdateChickenPosition())
            {
                Chicken.Location = new Point(Chicken.Location.X, Height - (IMAGE_OFFSET + Chicken.Height + IMAGE_OFFSET));
            }
            else
            {
                Chicken.Location = new Point(Chicken.Location.X, IMAGE_OFFSET);
            }

            DisableUnreachableItems();
        }


        //If clicked update the farmer and grain position
        private void Grain_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Grain Clicked");

            UpdateFarmerPosition();

            if (FarmerUI.GetAndUpdateGrainPosition())
            {
                Grain.Location = new Point(Grain.Location.X, Height - (IMAGE_OFFSET + Grain.Height + IMAGE_OFFSET));
            }
            else
            {
                Grain.Location = new Point(Grain.Location.X, IMAGE_OFFSET);
            }

            DisableUnreachableItems();
        }

        private void Water_Click(object sender, EventArgs e) { }
    }
}
