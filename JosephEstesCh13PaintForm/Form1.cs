using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * 
 * This program estimates and displays a room's wall area, ceiling area, 
 * and both areas combined,
 * as well as the cost of painting a room's walls, ceiling, 
 * and both costs combined based on length inputs within a windows form.
 * 
 * User enters room length and width and can press enter to calculate,
 * or click the calculate, reset, or exit buttons.
 * 
 * Program checks for proper input 
 * 
 * Program does not loop
 */

namespace JosephEstesCh13PaintForm
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double PRICE_PER_SQUARE = 6;
            const double ROOM_HEIGHT = 9;
            double roomLength;
            double roomWidth;
            double wallArea;
            double ceilingArea;
            double wallCost;
            double ceilingCost;

            if (double.TryParse(widthTextBox.Text, out roomWidth) && roomWidth >= 0)
                invalidWidthLabel.Visible = false;
            else
            {
                invalidWidthLabel.Visible = true;
            }

            if (double.TryParse(lengthTextBox.Text, out roomLength) && roomLength >= 0)
                invalidLengthLabel.Visible = false;
            else
            {
                invalidLengthLabel.Visible = true;
            }

            if (invalidLengthLabel.Visible || invalidWidthLabel.Visible)
            {
                roomWidth = 0;
                roomLength = 0;
            }

            wallArea = (2 * roomLength * ROOM_HEIGHT) + (2 * roomWidth * ROOM_HEIGHT);
            wallCost = wallArea * PRICE_PER_SQUARE;

            ceilingArea = roomLength * roomWidth;
            ceilingCost = ceilingArea * PRICE_PER_SQUARE;

            wallAreaLabel.Text = "Wall Area: " + wallArea;
            ceilingAreaLabel.Text = "Ceiling Area: " + ceilingArea;
            totalAreaLabel.Text = "Total Area: " + (wallArea + ceilingArea);
            wallCostLabel.Text = "Wall Cost: $" + wallCost;
            ceilingCostLabel.Text = "Ceiling Cost: $" + ceilingCost;
            totalCostLabel.Text = "Total Cost: $" + (wallCost + ceilingCost);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            widthTextBox.Clear();
            lengthTextBox.Clear();

            invalidWidthLabel.Visible = false;
            invalidLengthLabel.Visible = false;

            wallAreaLabel.Text = "Wall Area:";
            ceilingAreaLabel.Text = "Ceiling Area:";
            totalAreaLabel.Text = "Total Area:";
            wallCostLabel.Text = "Wall Cost:";
            ceilingCostLabel.Text = "Ceiling Cost:";
            totalCostLabel.Text = "Total Cost:";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void widthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculateButton_Click(this, new EventArgs());
            }
        }

        private void lengthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculateButton_Click(this, new EventArgs());
            }
        }
    }
}
