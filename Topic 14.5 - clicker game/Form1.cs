using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_14._5___clicker_game
{
    public partial class FormClicker : Form
    {
        int points;
        int multiplyer = 1;
        int resetPoints;
        int clicks;
        string pointtext = "bread: ";
        public FormClicker()
        {
            InitializeComponent();
        }

       

       
       

        private void button1_Click(object sender, EventArgs e)
        {
            multiplyer = multiplyer * 2;
            points = points - 100;
            btnUpgrade1.Enabled=false;
        }

        private void upgrade2_Click(object sender, EventArgs e)
        {
            multiplyer = multiplyer * 4;
            points = points - 1000;
            btnUpgrade2.Enabled=false;
        }

        private void imgBread_MouseDown(object sender, MouseEventArgs e)
        {
            clicks = clicks + 1;
            points += 1 * multiplyer;
            lblRP.Text = "RP: " + resetPoints;
            lblPoints.Text = pointtext + " " + points.ToString();
            if (points >= 100)
            {
                btnUpgrade1.Enabled = true;
                
            }
            if (points >= 1000)
            {
                btnUpgrade2.Enabled = true;
            }
            if (points < 0)
            {
                btnReset.Enabled = true;
            }
            if (resetPoints >= 2)
            {
                btnChickenLay.Enabled = true;
                btnCoinLay.Enabled = true;
            }
        }

        private void imgBread_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            points = 0;
            resetPoints = resetPoints + 1;
            multiplyer = 1;
            btnReset.Enabled=false;
        }

        private void btnBreadLay_Click(object sender, EventArgs e)
        {

        }

        private void btnChickenLay_Click(object sender, EventArgs e)
        {
            btnChickenLay.Enabled=false;
            
            resetPoints = resetPoints - 2;
            btnChickenLay.Visible=false;
            radChicken.Visible=true;
        }

        private void btnCoinLay_Click(object sender, EventArgs e)
        {
            btnCoinLay.Enabled=false;
            
            resetPoints = resetPoints - 2;
            btnCoinLay.Visible=false;
            radCoin.Visible=true;

        }

        private void radBread_CheckedChanged(object sender, EventArgs e)
        {
            imgBread.Image = Properties.Resources.WhiteBread;
            pointtext = "bread: ";
            btnUpgrade1.Text = "2x bread";
            btnUpgrade2.Text = "4x bread";
            upgrades.Text = "Bread Multiplyers";
        }

        private void radChicken_CheckedChanged(object sender, EventArgs e)
        {
            imgBread.Image = Properties.Resources.Fried_Chicken_Pieces_1;
            pointtext = "chicken: ";
            btnUpgrade1.Text = "2x chicken";
            btnUpgrade2.Text = "4x chicken";
            upgrades.Text = "Chicken Multiplyers";
        }

        private void radCoin_CheckedChanged(object sender, EventArgs e)
        {
            imgBread.Image = Properties.Resources.heads;
            pointtext = "coins: ";
            btnUpgrade1.Text = "2x coins";
            btnUpgrade2.Text = "4x coins";
            upgrades.Text = "Coin Multiplyers";
        }
    }
}
