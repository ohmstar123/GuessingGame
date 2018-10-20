using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGame
{
    public partial class Form1 : Form
    {

        int randomValue;

        public Form1()
        {
            InitializeComponent();
            Random randgen = new Random();
            randomValue = randgen.Next(1, 101);

        }


        private void guessButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                //variables and conversions 
                int userGuess;
                userGuess = Convert.ToInt32(Input.Text);

                //If statements 
                if (userGuess == randomValue)
                {
                    outputLabel.Text = "You got it";

                    Refresh();
                    Thread.Sleep(3000);

                    this.Close();
                }
                else if (userGuess < randomValue)
                {
                    outputLabel.Text = "Too low";
                }
                else if (userGuess > randomValue)
                {
                    outputLabel.Text = "Too high";
                }
            }

            catch
            {
                outputLabel.Text = "Please enter a digit from 1 to 100";
            }

        }
    }
}
