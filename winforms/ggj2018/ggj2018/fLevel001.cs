using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ggj2018
{
    public partial class fLevel001 : Form
    {
        bool heroIsInfected = false;
        string heroFacingDirection = "S";
        Point startPoint = new Point(138, 252);
        Point endPoint = new Point(522, 316);
        Timer tm = new Timer();
        List<Point> validCoors = new List<Point>();

        public fLevel001()
        {
            InitializeComponent();
            KeyPreview = true;
            FillValidCoors();
        }

        private void FillValidCoors()
        {
            validCoors.Add(new Point(138, 252));
            validCoors.Add(new Point(202, 252));
            validCoors.Add(new Point(266, 252));
            validCoors.Add(new Point(330, 252));
            validCoors.Add(new Point(330, 316));
            validCoors.Add(new Point(330, 380));
            validCoors.Add(new Point(394, 380));
            validCoors.Add(new Point(458, 380));
            validCoors.Add(new Point(522, 380));
            validCoors.Add(new Point(522, 316));
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (heroIsInfected)
            {
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
                {
                    var oldCoors = picHero.Location;
                    var newCoors = new Point(0, 0);

                    switch (e.KeyCode)
                    {
                        case Keys.W:
                            newCoors = new Point(picHero.Location.X, picHero.Location.Y - 64);
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Up_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Up;
                            break;

                        case Keys.S:
                            newCoors = new Point(picHero.Location.X, picHero.Location.Y + 64);
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Down_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Down;

                            break;

                        case Keys.A:
                            newCoors = new Point(picHero.Location.X - 64, picHero.Location.Y);
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Left_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Left;
                            break;

                        case Keys.D:
                            newCoors = new Point(picHero.Location.X + 64, picHero.Location.Y);
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Right_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Right;
                            break;
                    }

                    if (validCoors.Contains(newCoors))
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.W:
                                heroFacingDirection = "W";
                                picHero.Location = newCoors;
                                break;
                            case Keys.S:
                                heroFacingDirection = "S";
                                picHero.Location = newCoors;
                                break;
                            case Keys.A:
                                heroFacingDirection = "A";
                                picHero.Location = newCoors;
                                break;
                            case Keys.D:
                                heroFacingDirection = "D";
                                picHero.Location = newCoors;
                                break;
                        }
                    }
                }

                if (picHero.Location == endPoint)
                {
                    this.Hide();
                    var fLevel002 = new fLevel002();
                    fLevel002.Closed += (s, args) => this.Close();
                    fLevel002.Show();
                }
            }
        }

        private void btnReturn_Click(object sender, System.EventArgs e)
        {
            heroIsInfected = false;
            heroFacingDirection = "S";
            picHero.Location = startPoint;
            picHero.Image = Properties.Resources.Player_Scientist_01_Down;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnInfect_Click(object sender, System.EventArgs e)
        {
            if (!heroIsInfected)
            {
                picHero.Image = Properties.Resources.Player_Scientist_Infection;

                tm.Enabled = true;
                tm.Interval = 2000;
                tm.Tick += new EventHandler(tm_Tick);
            }
            else
            {
                if (heroFacingDirection == "D")
                    picHero.Image = Properties.Resources.Player_Scientist_01_Right_Infected_Attak;

                if (heroFacingDirection == "A")
                    picHero.Image = Properties.Resources.Player_Scientist_01_Left_Infected_Attak;

                tm.Enabled = true;
                tm.Interval = 666;
                tm.Tick += new EventHandler(tm_Tick_Attak);
            }
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            heroIsInfected = true;
            picHero.Image = Properties.Resources.Player_Scientist_01_Down_Infected;
            tm.Stop();
        }

        private void tm_Tick_Attak(object sender, EventArgs e)
        {
            if (heroFacingDirection == "A")
                picHero.Image = Properties.Resources.Player_Scientist_01_Left_Infected;
            if (heroFacingDirection == "D")
                picHero.Image = Properties.Resources.Player_Scientist_01_Right_Infected;

            tm.Stop();
        }

        private void btnHeader_Click(object sender, EventArgs e)
        {

        }
    }
}