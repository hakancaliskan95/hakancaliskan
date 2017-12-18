namespace PacmanFormProject
{
    partial class frm_OtomatikGameMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OtomatikGameMod));
            this.pb_Pacman = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_target5 = new System.Windows.Forms.PictureBox();
            this.pb_target4 = new System.Windows.Forms.PictureBox();
            this.pb_target3 = new System.Windows.Forms.PictureBox();
            this.pb_target2 = new System.Windows.Forms.PictureBox();
            this.pb_target1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Pacman
            // 
            this.pb_Pacman.Image = ((System.Drawing.Image)(resources.GetObject("pb_Pacman.Image")));
            this.pb_Pacman.Location = new System.Drawing.Point(24, 24);
            this.pb_Pacman.Name = "pb_Pacman";
            this.pb_Pacman.Size = new System.Drawing.Size(50, 45);
            this.pb_Pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Pacman.TabIndex = 6;
            this.pb_Pacman.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_target5
            // 
            this.pb_target5.Image = ((System.Drawing.Image)(resources.GetObject("pb_target5.Image")));
            this.pb_target5.Location = new System.Drawing.Point(805, 237);
            this.pb_target5.Name = "pb_target5";
            this.pb_target5.Size = new System.Drawing.Size(20, 20);
            this.pb_target5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_target5.TabIndex = 11;
            this.pb_target5.TabStop = false;
            // 
            // pb_target4
            // 
            this.pb_target4.Image = ((System.Drawing.Image)(resources.GetObject("pb_target4.Image")));
            this.pb_target4.Location = new System.Drawing.Point(805, 211);
            this.pb_target4.Name = "pb_target4";
            this.pb_target4.Size = new System.Drawing.Size(20, 20);
            this.pb_target4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_target4.TabIndex = 10;
            this.pb_target4.TabStop = false;
            // 
            // pb_target3
            // 
            this.pb_target3.Image = ((System.Drawing.Image)(resources.GetObject("pb_target3.Image")));
            this.pb_target3.Location = new System.Drawing.Point(805, 185);
            this.pb_target3.Name = "pb_target3";
            this.pb_target3.Size = new System.Drawing.Size(20, 20);
            this.pb_target3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_target3.TabIndex = 9;
            this.pb_target3.TabStop = false;
            // 
            // pb_target2
            // 
            this.pb_target2.Image = ((System.Drawing.Image)(resources.GetObject("pb_target2.Image")));
            this.pb_target2.Location = new System.Drawing.Point(805, 159);
            this.pb_target2.Name = "pb_target2";
            this.pb_target2.Size = new System.Drawing.Size(20, 20);
            this.pb_target2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_target2.TabIndex = 8;
            this.pb_target2.TabStop = false;
            // 
            // pb_target1
            // 
            this.pb_target1.Image = ((System.Drawing.Image)(resources.GetObject("pb_target1.Image")));
            this.pb_target1.Location = new System.Drawing.Point(805, 133);
            this.pb_target1.Name = "pb_target1";
            this.pb_target1.Size = new System.Drawing.Size(20, 20);
            this.pb_target1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_target1.TabIndex = 7;
            this.pb_target1.TabStop = false;
            // 
            // frm_OtomatikGameMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(904, 451);
            this.Controls.Add(this.pb_target5);
            this.Controls.Add(this.pb_target4);
            this.Controls.Add(this.pb_target3);
            this.Controls.Add(this.pb_target2);
            this.Controls.Add(this.pb_target1);
            this.Controls.Add(this.pb_Pacman);
            this.Name = "frm_OtomatikGameMod";
            this.Text = "PacMan Game - Otomatik Mod";
            this.Load += new System.EventHandler(this.frm_OtomatikGameMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_target1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Pacman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_target5;
        private System.Windows.Forms.PictureBox pb_target4;
        private System.Windows.Forms.PictureBox pb_target3;
        private System.Windows.Forms.PictureBox pb_target2;
        private System.Windows.Forms.PictureBox pb_target1;
    }
}