using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ggj2018
{
    public partial class fLevel003 : Form
    {
        bool heroIsInfected = false;
        bool heroIsDead = false;
        int countdown = 5;
        string timerIsRunning = string.Empty;
        string heroFacingDirection = "S";
        Point startPoint = new Point(138, 252);
        Point endPoint = new Point(586, 252);
        Timer tm = new Timer();
        List<Point> validCoors = new List<Point>();

        public fLevel003()
        {
            InitializeComponent();
            KeyPreview = true;
            picHero.BringToFront();
            FillValidCoors();
        }

        private void FillValidCoors()
        {
            validCoors.Add(new Point(138, 252));
            validCoors.Add(new Point(202, 252));
            validCoors.Add(new Point(266, 252));
            validCoors.Add(new Point(330, 252));
            validCoors.Add(new Point(394, 252));
            validCoors.Add(new Point(458, 252));
            validCoors.Add(new Point(522, 252));
            validCoors.Add(new Point(586, 252));
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (heroIsInfected && timerIsRunning == string.Empty && heroIsDead == false)
            {
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
                {
                    var oldCoorsHero = picHero.Location;
                    var newCoorsHero = new Point(0, 0);

                    switch (e.KeyCode)
                    {
                        case Keys.W:
                            newCoorsHero = new Point(picHero.Location.X, picHero.Location.Y - 64);
                            heroFacingDirection = "W";
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Up_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Up;
                            break;

                        case Keys.S:
                            newCoorsHero = new Point(picHero.Location.X, picHero.Location.Y + 64);
                            heroFacingDirection = "S";
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Down_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Down;
                            break;

                        case Keys.A:
                            newCoorsHero = new Point(picHero.Location.X - 64, picHero.Location.Y);
                            heroFacingDirection = "A";
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Left_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Left;
                            break;

                        case Keys.D:
                            newCoorsHero = new Point(picHero.Location.X + 64, picHero.Location.Y);
                            heroFacingDirection = "D";
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Right_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Right;
                            break;
                    }

                    if (validCoors.Contains(newCoorsHero))
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.W:
                                picHero.Location = newCoorsHero;
                                break;
                            case Keys.S:
                                picHero.Location = newCoorsHero;
                                break;
                            case Keys.A:
                                picHero.Location = newCoorsHero;
                                break;
                            case Keys.D:
                                picHero.Location = newCoorsHero;
                                break;
                        }
                    }
                }

                countdown--;

                btnCountdown.Text = Convert.ToString(countdown);

                if (countdown == 0)
                {
                    picHero.Image = Properties.Resources.Player_Scientist_01_Down_Dying;

                    tm.Enabled = true;
                    timerIsRunning = "dyingHero";
                    tm.Interval = 2;
                    tm.Tick += new EventHandler(dying_Tick);

                    heroIsDead = true;
                }
            }

            if (picHero.Location == endPoint)
            {
                MessageBox.Show("Du hast gewonnen!");
            }
        }

        private void dying_Tick(object sender, EventArgs e)
        {
            if (timerIsRunning != "dyingHero")
            {
                tm.Stop();
                return;
            }

            tm.Stop();
            timerIsRunning = string.Empty;
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            if (timerIsRunning != "infectHero")
            {
                tm.Stop();
                return;
            }

            heroIsInfected = true;
            picHero.Image = Properties.Resources.Player_Scientist_01_Down_Infected;
            tm.Stop();
            timerIsRunning = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            timerIsRunning = string.Empty;
            heroIsInfected = false;
            heroIsDead = false;
            heroFacingDirection = "S";
            picHero.Location = startPoint;
            countdown = 5;
            btnCountdown.Text = Convert.ToString(countdown);
            picHero.Image = Properties.Resources.Player_Scientist_01_Down;

            validCoors.Clear();
            FillValidCoors();
        }

        private void btnInfect_Click_1(object sender, EventArgs e)
        {
            if (!heroIsInfected)
            {
                picHero.Image = Properties.Resources.Player_Scientist_Infection;

                tm.Enabled = true;
                timerIsRunning = "infectHero";
                tm.Interval = 2000;
                tm.Tick += new EventHandler(tm_Tick);
            }
        }
    }
}