using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        Random randgen = new Random();
        int randomValue;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int userGuess;
            userGuess = Convert.ToInt32(Input.Text);
            randomValue = randgen.Next(1, 101);

            if (userGuess == randomValue)
            {
                outputLabel.Text = "You got it";
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
    }
}
