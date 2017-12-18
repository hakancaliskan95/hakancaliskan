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
    public partial class frm_StartGame : Form
    {
        public frm_StartGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_ManuelMod.Checked == true)
            {
                frm_ManuelGameMod form = new frm_ManuelGameMod();
                Hide();
                form.Show();
            }
            else
            {
                frm_OtomatikGameMod form = new frm_OtomatikGameMod();
                Hide();
                form.Show();
            }
        }

        private void btn_CloseProgram_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_Signature_MouseHover(object sender, EventArgs e)
        {
            lbl_Signature.Font = new Font("Times New Roman", 8, FontStyle.Underline);
        }

        private void lbl_Signature_MouseLeave(object sender, EventArgs e)
        {
            lbl_Signature.Font = new Font("Times New Roman", 8);
        }
    }
}
