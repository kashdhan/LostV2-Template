/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 7;
                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 0;
                }
                else if (scene == 6)
                {
                    scene = 0;
                }
                else if (scene == 7)
                {
                    scene = 0;
                }
            }

            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 7;
                }
                else if (scene == 3)
                {
                    scene = 7;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 6)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 7;
                }
                /// Display text and game options to screen based on the current scene

            }
            switch (scene)
            {
                case 0:
                    outputLabel.Text = "You are lost in a forest."; //start scene 
                    redLabel.Text = "Go North";
                    blueLabel.Text = "Go South";
                    break;
                case 1:
                    outputLabel.Text = "You come to a lake. Do you want to take a drink?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    imageBox.BackgroundImage = Properties.Resources.forestLake;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.brook);
                    player.Play();

                    break;
                case 2:
                    outputLabel.Text = "You fall in a pit and die.\n\n Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 3:
                    outputLabel.Text = "The water is stagnent. You die of Cholera.\n\n Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "A horse swims by. Do you try and ride it?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You tame the horse and ride to saftey. Yayy\n\n Play again?!!";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "The horse walks past. You die of loneliness.\n\n Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "Thank you for playing.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                default:
                    break;      
            }
        }
    }
}
