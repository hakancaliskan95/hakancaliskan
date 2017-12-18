using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanFormProject
{
    public partial class frm_OtomatikGameMod : Form
    {
        public frm_OtomatikGameMod()
        {
            InitializeComponent();
        }

        private void frm_OtomatikGameMod_Load(object sender, EventArgs e)
        {
            Random rnd_x = new Random();
            Random rnd_y = new Random();
            pb_Pacman.Location = new Point(rnd_x.Next(0, 860), rnd_y.Next(40, 650));
            pb_target1.Location = new Point(rnd_x.Next(0, 200), rnd_y.Next(40, 650));
            pb_target2.Location = new Point(rnd_x.Next(200, 400), rnd_y.Next(40, 650));
            pb_target3.Location = new Point(rnd_x.Next(400, 600), rnd_y.Next(40, 650));
            pb_target4.Location = new Point(rnd_x.Next(600, 800), rnd_y.Next(40, 650));
            pb_target5.Location = new Point(rnd_x.Next(800, 860), rnd_y.Next(40, 650));
            timer1.Start();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_target1.Visible == true)
            {
                if (pb_Pacman.Left < pb_target1.Left)
                {
                    pb_Pacman.Left += 1;
                }
                else if (pb_Pacman.Left > pb_target1.Left)
                {
                    pb_Pacman.Left -= 1;
                }
                else if (pb_Pacman.Top < pb_target1.Top)
                {
                    pb_Pacman.Top += 1;
                }
                else if (pb_Pacman.Top > pb_target1.Top)
                {
                    pb_Pacman.Top -= 1;

                }
                else
                {
                    pb_target1.Visible = false;
                }
            }




            if (pb_target1.Visible == false && pb_target2.Visible == true)
            {

                if (pb_Pacman.Left < pb_target2.Left)
                {
                    pb_Pacman.Left += 1;
                }
                else if (pb_Pacman.Left > pb_target2.Left)
                {
                    pb_Pacman.Left -= 1;
                }
                else if (pb_Pacman.Top < pb_target2.Top)
                {
                    pb_Pacman.Top += 1;
                }
                else if (pb_Pacman.Top > pb_target2.Top)
                {
                    pb_Pacman.Top -= 1;

                }
                else
                {
                    pb_target2.Visible = false;
                }
            }
           
            if (pb_target1.Visible == false && pb_target2.Visible == false && pb_target3.Visible == true)
            {
                if (pb_Pacman.Left < pb_target3.Left)
                {
                    pb_Pacman.Left += 1;
                }
                else if (pb_Pacman.Left > pb_target3.Left)
                {
                    pb_Pacman.Left -= 1;
                }
                else if (pb_Pacman.Top < pb_target3.Top)
                {
                    pb_Pacman.Top += 1;
                }
                else if (pb_Pacman.Top > pb_target3.Top)
                {
                    pb_Pacman.Top -= 1;

                }
                else
                {
                    pb_target3.Visible = false;
                }
                
            }
            
            if (pb_target1.Visible == false && pb_target2.Visible == false && pb_target3.Visible == false && pb_target4.Visible == true)
            {
                if (pb_Pacman.Left < pb_target4.Left)
                {
                    pb_Pacman.Left += 1;
                }
                else if (pb_Pacman.Left > pb_target4.Left)
                {
                    pb_Pacman.Left -= 1;
                }
                else if (pb_Pacman.Top < pb_target4.Top)
                {
                    pb_Pacman.Top += 1;
                }
                else if (pb_Pacman.Top > pb_target4.Top)
                {
                    pb_Pacman.Top -= 1;

                }
                else
                {
                    pb_target4.Visible = false;
                }
            }
            if (pb_target1.Visible == false && pb_target2.Visible == false && pb_target3.Visible == false && pb_target4.Visible == false && pb_target5.Visible == true)
            {
                if (pb_Pacman.Left < pb_target5.Left)
                {
                    pb_Pacman.Left += 1;
                }
                else if (pb_Pacman.Left > pb_target5.Left)
                {
                    pb_Pacman.Left -= 1;
                }
                else if (pb_Pacman.Top < pb_target5.Top)
                {
                    pb_Pacman.Top += 1;
                }
                else if (pb_Pacman.Top > pb_target5.Top)
                {
                    pb_Pacman.Top -= 1;

                }
                else
                {
                    pb_target5.Visible = false;
                }
                
            }
            
        }
        
    }
}
