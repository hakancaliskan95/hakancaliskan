namespace PacmanFormProject
{
    partial class frm_StartGame
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StartGame));
            this.pb_PacmanGif = new System.Windows.Forms.PictureBox();
            this.gb_chooseMod = new System.Windows.Forms.GroupBox();
            this.rb_OtomatikMod = new System.Windows.Forms.RadioButton();
            this.rb_ManuelMod = new System.Windows.Forms.RadioButton();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.lbl_Signature = new System.Windows.Forms.Label();
            this.btn_CloseProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PacmanGif)).BeginInit();
            this.gb_chooseMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_PacmanGif
            // 
            this.pb_PacmanGif.Image = ((System.Drawing.Image)(resources.GetObject("pb_PacmanGif.Image")));
            this.pb_PacmanGif.Location = new System.Drawing.Point(31, 12);
            this.pb_PacmanGif.Name = "pb_PacmanGif";
            this.pb_PacmanGif.Size = new System.Drawing.Size(327, 171);
            this.pb_PacmanGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PacmanGif.TabIndex = 0;
            this.pb_PacmanGif.TabStop = false;
            // 
            // gb_chooseMod
            // 
            this.gb_chooseMod.Controls.Add(this.rb_OtomatikMod);
            this.gb_chooseMod.Controls.Add(this.rb_ManuelMod);
            this.gb_chooseMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_chooseMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_chooseMod.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_chooseMod.Location = new System.Drawing.Point(27, 141);
            this.gb_chooseMod.Name = "gb_chooseMod";
            this.gb_chooseMod.Size = new System.Drawing.Size(323, 105);
            this.gb_chooseMod.TabIndex = 2;
            this.gb_chooseMod.TabStop = false;
            this.gb_chooseMod.Text = "Please Choose a Game Mod";
            // 
            // rb_OtomatikMod
            // 
            this.rb_OtomatikMod.AutoSize = true;
            this.rb_OtomatikMod.Location = new System.Drawing.Point(35, 62);
            this.rb_OtomatikMod.Name = "rb_OtomatikMod";
            this.rb_OtomatikMod.Size = new System.Drawing.Size(119, 21);
            this.rb_OtomatikMod.TabIndex = 1;
            this.rb_OtomatikMod.Text = "Automatic Mod";
            this.rb_OtomatikMod.UseVisualStyleBackColor = true;
            // 
            // rb_ManuelMod
            // 
            this.rb_ManuelMod.AutoSize = true;
            this.rb_ManuelMod.Checked = true;
            this.rb_ManuelMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.rb_ManuelMod.Location = new System.Drawing.Point(35, 35);
            this.rb_ManuelMod.Name = "rb_ManuelMod";
            this.rb_ManuelMod.Size = new System.Drawing.Size(103, 21);
            this.rb_ManuelMod.TabIndex = 0;
            this.rb_ManuelMod.TabStop = true;
            this.rb_ManuelMod.Text = "Manuel Mod";
            this.rb_ManuelMod.UseVisualStyleBackColor = true;
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.BackColor = System.Drawing.Color.Green;
            this.btn_StartGame.FlatAppearance.BorderSize = 0;
            this.btn_StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_StartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_StartGame.Location = new System.Drawing.Point(27, 267);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(323, 42);
            this.btn_StartGame.TabIndex = 0;
            this.btn_StartGame.Text = "LET\'S START";
            this.btn_StartGame.UseVisualStyleBackColor = false;
            this.btn_StartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Signature
            // 
            this.lbl_Signature.AutoSize = true;
            this.lbl_Signature.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Signature.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Signature.Location = new System.Drawing.Point(216, 379);
            this.lbl_Signature.Name = "lbl_Signature";
            this.lbl_Signature.Size = new System.Drawing.Size(95, 14);
            this.lbl_Signature.TabIndex = 3;
            this.lbl_Signature.Text = "Designed by Hakan";
            this.lbl_Signature.MouseLeave += new System.EventHandler(this.lbl_Signature_MouseLeave);
            this.lbl_Signature.MouseHover += new System.EventHandler(this.lbl_Signature_MouseHover);
            // 
            // btn_CloseProgram
            // 
            this.btn_CloseProgram.BackColor = System.Drawing.Color.Crimson;
            this.btn_CloseProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_CloseProgram.FlatAppearance.BorderSize = 0;
            this.btn_CloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CloseProgram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CloseProgram.Location = new System.Drawing.Point(27, 315);
            this.btn_CloseProgram.Name = "btn_CloseProgram";
            this.btn_CloseProgram.Size = new System.Drawing.Size(323, 41);
            this.btn_CloseProgram.TabIndex = 4;
            this.btn_CloseProgram.Text = "CLOSE THE GAME";
            this.btn_CloseProgram.UseVisualStyleBackColor = false;
            this.btn_CloseProgram.Click += new System.EventHandler(this.btn_CloseProgram_Click);
            // 
            // frm_StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(378, 402);
            this.Controls.Add(this.btn_CloseProgram);
            this.Controls.Add(this.lbl_Signature);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.gb_chooseMod);
            this.Controls.Add(this.pb_PacmanGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_StartGame";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacMan Game";
            ((System.ComponentModel.ISupportInitialize)(this.pb_PacmanGif)).EndInit();
            this.gb_chooseMod.ResumeLayout(false);
            this.gb_chooseMod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_PacmanGif;
        private System.Windows.Forms.GroupBox gb_chooseMod;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.RadioButton rb_OtomatikMod;
        private System.Windows.Forms.RadioButton rb_ManuelMod;
        private System.Windows.Forms.Label lbl_Signature;
        private System.Windows.Forms.Button btn_CloseProgram;
    }
}

