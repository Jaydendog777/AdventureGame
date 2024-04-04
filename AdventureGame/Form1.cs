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
using System.Runtime.ExceptionServices;

// I don't have time to add images I'm sorry, I've had no free time outside of school.


namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int userPower = 0;
        int opponentPower = 0;
        int pageNumber = 1;
        string username;
        int clicked = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void optionOne_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1)
            {
                pageNumber = 2;
            }
            else if (pageNumber == 2)
            {
                pageNumber = 3;
            }
            else if (pageNumber == 3)
            {
                pageNumber = 7;
            }
            else if (pageNumber == 4)
            {
                pageNumber = 6;
            }
            else if (pageNumber == 10)
            {
                pageNumber = 11;
            }
            else if (pageNumber == 11)
            {
                pageNumber = 13;
            }
            else if (pageNumber == 14)
            {
                pageNumber = 11;
            }
            else if (pageNumber == 20)
            {
                pageNumber = 26;
            }
            else if (pageNumber == 77)
            {
                pageNumber = 1;
            }

            displayPage();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                username = usernameInput.Text;

                usernameInput.Visible = false;
                startButton.Visible = false;
                optionOne.Visible = true;
                optionTwo.Visible = true;
                optionThree.Visible = true;
                pictureBox1.Visible = true;
                pageNumber = 1;

            }
            catch
            {
                mainLabel.Text = "Use letters.";
            }
            displayPage();
        }

        private void optionTwo_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1)
            {
                pageNumber = 4;
            }
            else if (pageNumber == 2)
            {
                pageNumber = 5;
            }
            else if (pageNumber == 4)
            {
                pageNumber = 29;
            }
            else if (pageNumber == 3)
            {
                pageNumber = 8;
            }
            else if (pageNumber == 10)
            {
                pageNumber = 28;
            }
            else if (pageNumber == 11)
            {
                pageNumber = 12;
            }
            else if (pageNumber == 14)
            {
                pageNumber = 3;
            }
            else if (pageNumber == 20)
            {
                pageNumber = 25;
            }
            else if (pageNumber == 77)
            {
                pageNumber = 6;
            }

            displayPage();
        }

        private void optionThree_Click(object sender, EventArgs e)
        {
            if (pageNumber == 3)
            {
                pageNumber = 9;
            }
            else if (pageNumber == 10) 
            {
                pageNumber = 28;
            }
           else if (pageNumber == 14)
            {
                int whoOpponent = random.Next(1, 6);

                if (whoOpponent == 1)
                {
                    pageNumber = 15;
                }
                if (whoOpponent == 2)
                {
                    pageNumber = 16;
                }
                if (whoOpponent == 3)
                {
                    pageNumber = 17;
                }
                if (whoOpponent == 4)
                {
                    pageNumber = 18;
                }
                if (whoOpponent == 5)
                {
                    pageNumber = 19;
                }
            }
            displayPage();
        }

        private void displayPage()
        {
            switch (pageNumber)
            {
                case 1:
                    mainLabel.Text = $"Welcome {username}! Are you ready to play rugby?";
                    optionOne.Text = "Yes!";
                    optionTwo.Text = "No!";
                    optionThree.Text = "";
                    userPower = 0;
                    scoreLabel.Text = $"Score:\n{userPower}";
                    
                    break;
                case 2:
                    mainLabel.Text = "Awesome! Would you like to start training?";
                    break;
                case 3:
                    mainLabel.Text = "Good choice! Which training would you like to do?";
                    optionOne.Text = "Strength";
                    optionTwo.Text = "Cardio";
                    optionThree.Text = "Rugby Practice";
                    pictureBox1.Image = Properties.Resources.th1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.cf1c5a4da6e528636bce5c4812ea9ed2;
                    mainLabel.Text = "Why are you here then?";
                    optionOne.Text = "I have to be";
                    optionTwo.Text = "Not sure";
                    optionThree.Text = "";
                    break;
                case 5:
                    mainLabel.Text = "Fine then lets see how well you do in a game. \n\n\n\nYou played the game and your body broke. Play again?";
                    pageNumber = 77;
                    break;
                case 6:
                    mainLabel.Text = "That sucks bye then.";
                    optionOne.Text = "";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    pictureBox1.Image = Properties.Resources.bb31dc4429937cd772539f560af352ff;
                    this.Refresh();
                    pictureBox1.Refresh();
                    Thread.Sleep(2000);
                    this.Close();

                    pageNumber = 1;
                    mainLabel.Text = $"Welcome {username}! Are you ready to play rugby?";
                    optionOne.Text = "Yes!";
                    optionTwo.Text = "No!";
                    break;
                case 7:
                    mainLabel.Text = "Click the dumbbell 10 times!";
                    pictureBox1.Visible = false;
                    button1.Visible = true;
                    button1.Enabled = true;
                    break;
                case 8:
                    mainLabel.Text = "Click the tredmill 10 times!";
                    pictureBox1.Visible = false;
                    button1.Enabled = true;
                    button1.Visible = true;
                    break;
                case 9:
                    mainLabel.Text = "Click the rugby ball 10 times!";
                    pictureBox1.Visible = false;
                    button1.Enabled = true;
                    button1.Visible = true;
                    break;
                case 10:
                    mainLabel.Text = "What do you do now?";
                    optionOne.Text = "Rest";
                    optionTwo.Text = "Train";
                    optionThree.Text = "Play a rugby game";
                    break;
                case 11:
                    mainLabel.Text = "Thats smart! Have a good nap.";
                    optionThree.Text = "";
                    mainLabel.Refresh();
                    Thread.Sleep(3000);
                    mainLabel.Text = "How was your sleep?";
                    optionOne.Text = "good";
                    optionTwo.Text = "bad";
                    optionThree.Text = "";
                    mainLabel.Refresh();
                    Thread.Sleep(200);
                    break;
                case 12:
                    mainLabel.Text = "That must suck.";
                    mainLabel.Refresh();
                    Thread.Sleep(1000);
                    pageNumber = 10;
                    displayPage();
                    break;
                case 13:
                    mainLabel.Text = "That's great!";
                    mainLabel.Refresh();
                    Thread.Sleep(1000);
                    pageNumber = 14;
                    displayPage();
                    break;
                case 14:
                    mainLabel.Text = "What do you do now?";
                    optionOne.Text = "Rest";
                    optionTwo.Text = "Train";
                    optionThree.Text = "Play a rugby game";
                    break;
                case 15:
                    mainLabel.Text = "You will face off against Antoine Dupont";
                    opponentPower = 60;
                    pageNumber = 20;
                    mainLabel.Refresh();
                    Thread.Sleep(2000);
                    displayPage();
                    break;
                case 16:
                    mainLabel.Text = "You will face off against Bundee Aki ";
                    opponentPower = 70;
                    pageNumber = 20;
                    mainLabel.Refresh();
                    Thread.Sleep(2000);
                    displayPage();
                    break;
                case 17:
                    mainLabel.Text = "You will face off against Mr. T ";
                    opponentPower = 10;
                    if (userPower >= opponentPower)
                    {
                        mainLabel.Text = "Good job, you won!\nHowever, Mr. T got mad and failed you so really you lost.\nPlay again?";
                        optionOne.Text = "Yes!";
                        optionTwo.Text = "No!";
                        pageNumber = 77;
                    }
                    else
                    {
                        mainLabel.Text = "How did you get here without training? Go train.";
                        pageNumber = 3;
                        Thread.Sleep(200);
                        displayPage();
                    }
                    displayPage();
                    break;
                case 18:
                    mainLabel.Text = "You will face off against Mr. Bradshaw ";
                    Thread.Sleep(200);
                    mainLabel.Text = "You play against Mr.Bradshaw.\nHowever, he created a robot and destroyed you.";
                    mainLabel.Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                    break;
                case 19:
                    mainLabel.Text = "You will face off against Liam ";
                    opponentPower = 10;
                    pageNumber = 20;
                    mainLabel.Refresh();
                    Thread.Sleep(2000);
                    displayPage();
                    break;
                case 20:
                    mainLabel.Text = "Would you like to start with the ball?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    break;
                case 21:
                    if (userPower >= opponentPower)
                    {
                        int winChance = random.Next(1, 101);
                        int didWin = (opponentPower / 10) + userPower + winChance;

                        if (didWin >= 100)
                        {
                            mainLabel.Text = "Congrats you won! Would you like to keep training or play again?";
                            pageNumber = 21;
                        }
                        else
                        {
                            mainLabel.Text = "Welp you lost. Go train.";
                            pageNumber = 3;
                            mainLabel.Refresh();
                            Thread.Sleep(2500);
                            displayPage();
                        }
                    }
                    else
                    {
                        int winChance = random.Next(1, 101);
                        int didWin = winChance + userPower;

                        if (didWin >= 100) 
                        {
                            mainLabel.Text = "Congrats you won! Would you like to keep training or play again?";
                            pageNumber = 21;
                        }
                        else
                        {
                            mainLabel.Text = "Welp you lost. Go train.";
                            pageNumber = 3;
                            mainLabel.Refresh();
                            Thread.Sleep(2500);
                            displayPage();
                        }
                    }
                    break;
                case 25:
                    mainLabel.Text = "The ball was kicked and you run to pick it up and the game has began! Goodluck!";
                    pageNumber = 21;
                    mainLabel.Refresh();
                    Thread.Sleep(2500);  
                    displayPage();
                    break;
                case 26:
                    mainLabel.Text = "You kicked the ball to your\nopponent and the game\nbegan! Goodluck!";
                    pageNumber = 21;
                    mainLabel.Refresh();
                    Thread.Sleep(2500);
                    displayPage();
                    break;
                case 28:
                    mainLabel.Text = "You're too tired for this.. Your body broke. Play again?";
                    pageNumber = 77;
                    optionOne.Text = "Yes!";
                    optionTwo.Text = "No!";
                    optionThree.Text = "";
                    break; 
                case 29:
                    mainLabel.Text = "Alright then... Want to play again?";
                    optionOne.Text = "Yes!";
                    optionTwo.Text = "No!";
                    optionThree.Text = "";
                    this.Refresh();
                    Thread.Sleep(2000);

                    pageNumber = 77;
                    break;

                default:
                    break;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            button1.Visible = true;
            if (clicked <= 8)
            {
                clicked++;
                button1.Text = $"{clicked}";
            }
            else
            {
                pageNumber = 10;
                userPower += 10;
                scoreLabel.Text = $"Score:\n{userPower}";
                clicked = 0;
                button1.Enabled = false;
                button1.Visible = false;
               
            }
            displayPage();
        }
    }
}
