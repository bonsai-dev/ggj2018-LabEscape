using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ggj2018
{
    public partial class fLevel002 : Form
    {
        bool heroIsInfected = false;
        bool npcIsInfected = false;
        string timerIsRunning = string.Empty;
        string heroFacingDirection = "S";
        string npcFacingDirection = "S";
        bool doorIsOpen = false;
        Point startPoint = new Point(138, 252);
        Point npcStartPoint = new Point(74, 444);
        Point endPoint = new Point(650, 124);
        Point doorPoint = new Point(650, 252);
        Point leaverPoint = new Point(138, 380);
        Timer tm = new Timer();
        List<Point> validCoors = new List<Point>();

        public fLevel002()
        {
            InitializeComponent();
            KeyPreview = true;
            picHero.BringToFront();
            FillValidCoors();
        }

        private void FillValidCoors()
        {
            validCoors.Add(new Point(138, 252));
            validCoors.Add(new Point(138, 188));
            validCoors.Add(new Point(138, 124));
            validCoors.Add(new Point(202, 124));
            validCoors.Add(new Point(266, 124));
            validCoors.Add(new Point(266, 188));
            validCoors.Add(new Point(266, 252));
            validCoors.Add(new Point(266, 316));
            validCoors.Add(new Point(266, 380));
            validCoors.Add(new Point(266, 444));
            validCoors.Add(new Point(330, 444));
            validCoors.Add(new Point(394, 444));
            validCoors.Add(new Point(458, 444));
            validCoors.Add(new Point(522, 444));
            validCoors.Add(new Point(586, 444));
            validCoors.Add(new Point(650, 444));
            validCoors.Add(new Point(202, 444));
            validCoors.Add(new Point(138, 444));
            //validCoors.Add(new Point(74, 444)); //npc
            validCoors.Add(new Point(138, 380));
            validCoors.Add(new Point(650, 380));
            validCoors.Add(new Point(650, 316));
            //validCoors.Add(new Point(650, 252)); //door
            validCoors.Add(new Point(650, 188));
            validCoors.Add(new Point(650, 124));
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (heroIsInfected && timerIsRunning == string.Empty)
            {
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
                {
                    var oldCoorsHero = picHero.Location;
                    var newCoorsHero = new Point(0, 0);

                    var oldCoorsNPC = picNPC.Location;
                    var newCoorsNPC = new Point(0, 0);

                    switch (e.KeyCode)
                    {
                        case Keys.W:
                            newCoorsHero = new Point(picHero.Location.X, picHero.Location.Y - 64);
                            heroFacingDirection = "W";
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Up_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Up;

                            if (npcIsInfected)
                            {
                                newCoorsNPC = new Point(picNPC.Location.X, picNPC.Location.Y - 64);
                                npcFacingDirection = "W";
                                picNPC.Image = Properties.Resources.Player_Scientist_01_Up_Infected;
                            }
                            break;

                        case Keys.S:
                            newCoorsHero = new Point(picHero.Location.X, picHero.Location.Y + 64);
                            heroFacingDirection = "S";
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Down_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Down;

                            if (npcIsInfected)
                            {
                                newCoorsNPC = new Point(picNPC.Location.X, picNPC.Location.Y + 64);
                                npcFacingDirection = "S";
                                picNPC.Image = Properties.Resources.Player_Scientist_01_Down_Infected;
                            }
                            break;

                        case Keys.A:
                            newCoorsHero = new Point(picHero.Location.X - 64, picHero.Location.Y);
                            heroFacingDirection = "A";
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Left_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Left;

                            if (npcIsInfected)
                            {
                                newCoorsNPC = new Point(picNPC.Location.X - 64, picNPC.Location.Y);
                                npcFacingDirection = "A";
                                picNPC.Image = Properties.Resources.Player_Scientist_01_Left_Infected;
                            }
                            break;

                        case Keys.D:
                            newCoorsHero = new Point(picHero.Location.X + 64, picHero.Location.Y);
                            heroFacingDirection = "D";
                            if (heroIsInfected)
                                picHero.Image = Properties.Resources.Player_Scientist_01_Right_Infected;
                            else
                                picHero.Image = Properties.Resources.Player_Scientist_01_Right;

                            if (npcIsInfected)
                            {
                                newCoorsNPC = new Point(picNPC.Location.X + 64, picNPC.Location.Y);
                                npcFacingDirection = "D";
                                picNPC.Image = Properties.Resources.Player_Scientist_01_Right_Infected;
                            }
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

                    if (validCoors.Contains(newCoorsNPC))
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.W:
                                picNPC.Location = newCoorsNPC;
                                break;
                            case Keys.S:
                                picNPC.Location = newCoorsNPC;
                                break;
                            case Keys.A:
                                picNPC.Location = newCoorsNPC;
                                break;
                            case Keys.D:
                                picNPC.Location = newCoorsNPC;
                                break;
                        }
                    }
                }
            }

            if (picHero.Location == endPoint)
            {
                this.Hide();
                var fLevel003 = new fLevel003();
                fLevel003.Closed += (s, args) => this.Close();
                fLevel003.Show();
            }

            if (picHero.Location == leaverPoint || picNPC.Location == leaverPoint)
            {
                if (doorIsOpen == false)
                {
                    picDoor.Image = Properties.Resources.lvl_lab_door_01_opening;

                    tm.Enabled = true;
                    timerIsRunning = "openDoor";
                    tm.Interval = 666;
                    tm.Tick += new EventHandler(tm_openDoor);
                }
            }
            else
            {
                if (doorIsOpen)
                {
                    picDoor.Image = Properties.Resources.lvl_lab_door_01_closing;

                    tm.Enabled = true;
                    timerIsRunning = "closeDoor";
                    tm.Interval = 666;
                    tm.Tick += new EventHandler(tm_closeDoor);
                }
            }
        }

        private void tm_openDoor(object sender, EventArgs e)
        {
            if (timerIsRunning != "openDoor")
            {
                tm.Stop();
                return;
            }

            doorIsOpen = true;
            validCoors.Clear();
            FillValidCoors();
            validCoors.Add(new Point(650, 252));
            picDoor.Image = Properties.Resources.lvl_lab_door_01_open;
            tm.Stop();
            timerIsRunning = string.Empty;
        }

        private void tm_closeDoor(object sender, EventArgs e)
        {
            if (timerIsRunning != "closeDoor")
            {
                tm.Stop();
                return;
            }

            doorIsOpen = false;
            validCoors.Clear();
            FillValidCoors();
            picDoor.Image = Properties.Resources.lvl_lab_door_01_closed;
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

        private void infectNPC_Tick(object sender, EventArgs e)
        {
            if (timerIsRunning != "infectNPC")
            {
                tm.Stop();
                return;
            }

            npcIsInfected = true;
            picNPC.Image = Properties.Resources.Player_Scientist_01_Down_Infected;
            tm.Stop();
            timerIsRunning = string.Empty;
        }

        private void tm_Tick_Attak(object sender, EventArgs e)
        {
            if (timerIsRunning != "attak")
            {
                tm.Stop();
                return;
            }

            if (heroFacingDirection == "A")
                picHero.Image = Properties.Resources.Player_Scientist_01_Left_Infected;
            if (heroFacingDirection == "D")
                picHero.Image = Properties.Resources.Player_Scientist_01_Right_Infected;

            tm.Stop();
            timerIsRunning = string.Empty;

            if (picHero.Location == new Point(138, 444))
            {
                picNPC.Image = Properties.Resources.Player_Scientist_Infection;

                tm.Enabled = true;
                timerIsRunning = "infectNPC";
                tm.Interval = 2000;
                tm.Tick += new EventHandler(infectNPC_Tick);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            timerIsRunning = string.Empty;
            heroIsInfected = false;
            npcIsInfected = false;
            doorIsOpen = false;
            heroFacingDirection = "S";
            npcFacingDirection = "S";
            picHero.Location = startPoint;
            picNPC.Location = npcStartPoint;
            picHero.Image = Properties.Resources.Player_Scientist_01_Down;
            picNPC.Image = Properties.Resources.Player_Scientist_01_Down;
            picDoor.Image = Properties.Resources.lvl_lab_door_01_closed;

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
            else
            {
                if (heroFacingDirection == "D")
                    picHero.Image = Properties.Resources.Player_Scientist_01_Right_Infected_Attak;

                if (heroFacingDirection == "A")
                    picHero.Image = Properties.Resources.Player_Scientist_01_Left_Infected_Attak;

                tm.Enabled = true;
                timerIsRunning = "attak";
                tm.Interval = 666;
                tm.Tick += new EventHandler(tm_Tick_Attak);
            }
        }
    }
}