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
            NewGame.Click += NewGame_Click;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            //Reset game data
            FarmerUI.Reset();

            //Reset game board
            UpdateFarmerPosition(FarmerUI.GetFarmerPosition());
            MoveFox(FarmerUI.GetFoxPosition());
            MoveChicken(FarmerUI.GetChickenPosition());
            MoveGrain(FarmerUI.GetGrainPosition());

            //Reset disabled items
            DisableUnreachableItems();

            //Hide win loss text
            WinLoss.Enabled = false;
            WinLoss.Visible = false;

            //Hide new game button
            NewGame.Enabled = false;
            NewGame.Visible = false;
        }

        /// <summary>
        /// Updates the farmer's position
        /// </summary>
        private void UpdateFarmerPosition(bool farmerPos)
        {
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
            Farmer.Enabled = true;
            Fox.Enabled = farmerPos == FarmerUI.GetFoxPosition();
            Chicken.Enabled = farmerPos == FarmerUI.GetChickenPosition();
            Grain.Enabled = farmerPos == FarmerUI.GetGrainPosition();
        }

        private void DisableAll()
        {
            Farmer.Enabled = false;
            Fox.Enabled = false;
            Chicken.Enabled = false;
            Grain.Enabled = false;
        }

        private void DetermineWin()
        {
            bool farmerPos = FarmerUI.GetFarmerPosition();
            bool foxPos = FarmerUI.GetFoxPosition();
            bool chickenPos = FarmerUI.GetChickenPosition();
            bool grainPos = FarmerUI.GetGrainPosition();

            if (foxPos && chickenPos && grainPos) 
            {
                WinLoss.Enabled = true;
                WinLoss.Text = "You Win! Press new game to play again!";
                WinLoss.Visible = true;

                NewGame.Enabled = true;
                NewGame.Visible = true;

                DisableAll();
                return;
            }
            

            if (foxPos != farmerPos && chickenPos != farmerPos)
            {
                WinLoss.Enabled = true;
                WinLoss.Text = "The fox ate the chicken and you lost!";
                WinLoss.Visible = true;

                NewGame.Enabled = true;
                NewGame.Visible = true;

                DisableAll();
                return;
            }
            

            if(chickenPos != farmerPos && grainPos != farmerPos)
            {
                WinLoss.Enabled = true;
                WinLoss.Text = "The chicken ate the grain and you lost!";
                WinLoss.Visible = true;

                NewGame.Enabled = true;
                NewGame.Visible = true;

                DisableAll();
                return;
            }

            WinLoss.Enabled = false;
            WinLoss.Text = string.Empty;
            WinLoss.Visible = false;

            NewGame.Enabled = false;
            NewGame.Visible = false;
        }
        
        private void MoveFox(bool pos)
        {
            if (pos)
            {
                Fox.Location = new Point(Fox.Location.X, Height - (IMAGE_OFFSET + Fox.Height + IMAGE_OFFSET));
            }
            else
            {
                Fox.Location = new Point(Fox.Location.X, IMAGE_OFFSET);
            }
        }

        private void MoveChicken(bool pos)
        {
            if (pos)
            {
                Chicken.Location = new Point(Chicken.Location.X, Height - (IMAGE_OFFSET + Chicken.Height + IMAGE_OFFSET));
            }
            else
            {
                Chicken.Location = new Point(Chicken.Location.X, IMAGE_OFFSET);
            }
        }

        private void MoveGrain(bool pos)
        {
            if (pos)
            {
                Grain.Location = new Point(Grain.Location.X, Height - (IMAGE_OFFSET + Grain.Height + IMAGE_OFFSET));
            }
            else
            {
                Grain.Location = new Point(Grain.Location.X, IMAGE_OFFSET);
            }
        }

        //If clicked only update the farmer's position
        private void Farmer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Farmer Clicked");

            UpdateFarmerPosition(FarmerUI.GetAndUpdateFarmerPosition());
            DisableUnreachableItems();

            DetermineWin();
        }

        //If clicked update the farmer and fox position
        private void Fox_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Fox Clicked");

            UpdateFarmerPosition(FarmerUI.GetAndUpdateFarmerPosition());
            MoveFox(FarmerUI.GetAndUpdateFoxPosition());
            DisableUnreachableItems();
            DetermineWin();
        }


        //If clicked update the farmer and chicken position
        private void Chicken_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Chicken Clicked");

            UpdateFarmerPosition(FarmerUI.GetAndUpdateFarmerPosition());
            MoveChicken(FarmerUI.GetAndUpdateChickenPosition());
            DisableUnreachableItems();
            DetermineWin();
        }


        //If clicked update the farmer and grain position
        private void Grain_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Grain Clicked");

            UpdateFarmerPosition(FarmerUI.GetAndUpdateFarmerPosition());
            MoveGrain(FarmerUI.GetAndUpdateGrainPosition());
            DisableUnreachableItems();
            DetermineWin();
        }

        private void Water_Click(object sender, EventArgs e) { }
    }
}
