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
    public partial class frm_ManuelGameMod : Form
    {
        public frm_ManuelGameMod()
        {
            InitializeComponent();
            
        }
        private void frm_ManuelGameMod_Load(object sender, EventArgs e)
        {
            Random rnd_x = new Random();
            Random rnd_y = new Random();
            pb_Pacman.Location = new Point(rnd_x.Next(0, 860), rnd_y.Next(40, 650));
            pb_target1.Location = new Point(rnd_x.Next(0, 200), rnd_y.Next(40, 650));
            pb_target2.Location = new Point(rnd_x.Next(200, 400), rnd_y.Next(40, 650));
            pb_target3.Location = new Point(rnd_x.Next(400, 600), rnd_y.Next(40, 650));
            pb_target4.Location = new Point(rnd_x.Next(600, 800), rnd_y.Next(40, 650));
            pb_target5.Location = new Point(rnd_x.Next(800, 860), rnd_y.Next(40, 650));
        }

        private void frm_ManuelGameMod_KeyDown(object sender, KeyEventArgs e)
        {
            if (pb_Pacman.Left < 0 && e.KeyCode == Keys.Left)
                return;
            else if (pb_Pacman.Top < 40 && e.KeyCode == Keys.Up)
                return;
            else if (pb_Pacman.Right > Size.Width - pb_Pacman.Width && e.KeyCode == Keys.Right)
                return;
            else if (pb_Pacman.Bottom > Size.Height - pb_Pacman.Height && e.KeyCode == Keys.Down)
                return;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    pb_Pacman.Top -= 20;
                    break;
                case Keys.Right:
                    pb_Pacman.Left += 20;
                    break;
                case Keys.Down:
                    pb_Pacman.Top += 20;
                    break;
                case Keys.Left:
                    pb_Pacman.Left -= 20;
                    break;
                default:
                    break;
            }

            CatchControl(); // my catch control function.
            
            if (pb_target1.Visible == false && pb_target2.Visible == false && pb_target3.Visible == false && pb_target4.Visible == false && pb_target5.Visible == false)
            {
                DialogResult result = MessageBox.Show("You collected all targets. Do you want to play again?",
                    "Well done!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frm_ManuelGameMod form = new frm_ManuelGameMod();
                    Hide();
                    form.Show();
                }
                else
                {
                    frm_StartGame form = new frm_StartGame();
                    Hide();
                    form.Show();
                }
            }
        }

        private void lbl_BackToMainForm_Click(object sender, EventArgs e) // Go back StartForm
        {
            frm_StartGame form = new frm_StartGame();
            Hide();
            form.Show();
        }

        private void pb_refresh_Click(object sender, EventArgs e) // Every click loads Form again
        {
            frm_ManuelGameMod form = new frm_ManuelGameMod();
            Hide();
            form.Show();
        }

        public void CatchControl()
        {
            if (pb_Pacman.Top <= pb_target1.Bottom && pb_Pacman.Bottom >= pb_target1.Top && pb_Pacman.Left < pb_target1.Right && pb_Pacman.Right > pb_target1.Left)
                pb_target1.Visible = false;
            else if (pb_Pacman.Top <= pb_target2.Bottom && pb_Pacman.Bottom >= pb_target2.Top && pb_Pacman.Left < pb_target2.Right && pb_Pacman.Right > pb_target2.Left)
                pb_target2.Visible = false;
            else if (pb_Pacman.Top <= pb_target3.Bottom && pb_Pacman.Bottom >= pb_target3.Top && pb_Pacman.Left < pb_target3.Right && pb_Pacman.Right > pb_target3.Left)
                pb_target3.Visible = false;
            else if (pb_Pacman.Top <= pb_target4.Bottom && pb_Pacman.Bottom >= pb_target4.Top && pb_Pacman.Left < pb_target4.Right && pb_Pacman.Right > pb_target4.Left)
                pb_target4.Visible = false;
            else if (pb_Pacman.Top <= pb_target5.Bottom && pb_Pacman.Bottom >= pb_target5.Top && pb_Pacman.Left < pb_target5.Right && pb_Pacman.Right > pb_target5.Left)
                pb_target5.Visible = false;
        }
        


        private void lbl_BackToMainForm_MouseHover(object sender, EventArgs e)
        {
            lbl_BackToMainForm.ForeColor = Color.Black;
        }

        private void lbl_BackToMainForm_MouseLeave(object sender, EventArgs e)
        {
            lbl_BackToMainForm.ForeColor = Color.Ivory;
        }

        private void pb_Pacman_Click(object sender, EventArgs e)
        {
            
        }
    }
}
