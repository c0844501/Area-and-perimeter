using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class AreaAndPerimeter : Form
    {
        public AreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closing the form
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //read the value from the textbox and store it into the variable
            double diameter = double.Parse(txtDiameter.Text);
            double area, perimeter;
            //PI method for the value of PI and Pow is used for the Square of the radius using the Math Library
            //Calculate the area
            area = Math.PI * (Math.Pow(diameter / 2, 2));
            //Roundoff the area upto 2 Digit using the Round method 
            area = Math.Round(area, 2);
            //Calculate the Perimeter 
            perimeter = Math.PI * diameter;
            perimeter = Math.Round(perimeter, 2);
            //Display the output in the textBox
            txtArea.Text = area.ToString();
            txtPerimeter.Text = perimeter.ToString();
            //Set the focus to the textbox named txtDiameter
            txtDiameter.Focus();
        }
    }
}
