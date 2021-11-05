using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6Lights
{
    public partial class Form1 : Form
    {
        //Initialize form
        public Form1()
        {
            InitializeComponent();
        }

        //Declare the methods
        //Turn light on method
        private void TurnLightOn()
        {
            //Makes light on picturebox status Visible, light off invisible
            lightOnPictureBox.Visible = true;
            lightOffPictureBox.Visible = false;

            //Display the light's state
            lightStateLabel.Text = "ON";
        }

        private void TurnLightOff()
        {
            //Makes light on picturebox invisible, light off visible
            lightOffPictureBox.Visible = true;
            lightOnPictureBox.Visible = false;

            //Display the light's state
            lightStateLabel.Text = " OFF ";

        }
        
        //Exit button event handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Switch button event handler
        private void switchButton_Click(object sender, EventArgs e)
        {
            //If statement to reverse the state of the light when clicked
            if(lightOnPictureBox.Visible == true)
            {
                //Call the turn light off method
                TurnLightOff();
            }

            else 
            {
                //Call the turn light on method
                TurnLightOn();
            }
        }
    }
}
