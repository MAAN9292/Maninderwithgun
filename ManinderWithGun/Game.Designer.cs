namespace ManinderWithGun
{
    partial class Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBullectCOunt = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbTotalScore = new System.Windows.Forms.Label();
            this.btPlayAgain = new System.Windows.Forms.Button();
            this.lbWasted = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btFire = new System.Windows.Forms.Button();
            this.btSpin = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Russian Roulette With Gun";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(13, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(81, 29);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // lbBullectCOunt
            // 
            this.lbBullectCOunt.AutoSize = true;
            this.lbBullectCOunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBullectCOunt.Location = new System.Drawing.Point(1030, 187);
            this.lbBullectCOunt.Name = "lbBullectCOunt";
            this.lbBullectCOunt.Size = new System.Drawing.Size(0, 20);
            this.lbBullectCOunt.TabIndex = 2;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(51, 343);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 26);
            this.lbScore.TabIndex = 3;
            // 
            // lbTotalScore
            // 
            this.lbTotalScore.AutoSize = true;
            this.lbTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalScore.Location = new System.Drawing.Point(51, 411);
            this.lbTotalScore.Name = "lbTotalScore";
            this.lbTotalScore.Size = new System.Drawing.Size(0, 26);
            this.lbTotalScore.TabIndex = 4;
            // 
            // btPlayAgain
            // 
            this.btPlayAgain.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btPlayAgain.BackgroundImage = global::ManinderWithGun.Properties.Resources.play;
            this.btPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayAgain.Location = new System.Drawing.Point(56, 478);
            this.btPlayAgain.Name = "btPlayAgain";
            this.btPlayAgain.Size = new System.Drawing.Size(155, 55);
            this.btPlayAgain.TabIndex = 9;
            this.btPlayAgain.Text = "Play Again";
            this.btPlayAgain.UseVisualStyleBackColor = false;
            this.btPlayAgain.Click += new System.EventHandler(this.btPlayAgain_Click);
            // 
            // lbWasted
            // 
            this.lbWasted.AutoSize = true;
            this.lbWasted.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWasted.ForeColor = System.Drawing.Color.Red;
            this.lbWasted.Location = new System.Drawing.Point(493, 565);
            this.lbWasted.Name = "lbWasted";
            this.lbWasted.Size = new System.Drawing.Size(0, 39);
            this.lbWasted.TabIndex = 10;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Salmon;
            this.btExit.BackgroundImage = global::ManinderWithGun.Properties.Resources.download;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(56, 546);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(155, 55);
            this.btExit.TabIndex = 8;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btFire
            // 
            this.btFire.BackColor = System.Drawing.Color.Crimson;
            this.btFire.BackgroundImage = global::ManinderWithGun.Properties.Resources.fireGun;
            this.btFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFire.Location = new System.Drawing.Point(804, 482);
            this.btFire.Name = "btFire";
            this.btFire.Size = new System.Drawing.Size(130, 50);
            this.btFire.TabIndex = 7;
            this.btFire.Text = "Fire";
            this.btFire.UseVisualStyleBackColor = false;
            this.btFire.Click += new System.EventHandler(this.btFire_Click);
            // 
            // btSpin
            // 
            this.btSpin.BackColor = System.Drawing.Color.Tomato;
            this.btSpin.BackgroundImage = global::ManinderWithGun.Properties.Resources.wheel_Icon;
            this.btSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpin.Location = new System.Drawing.Point(614, 482);
            this.btSpin.Name = "btSpin";
            this.btSpin.Size = new System.Drawing.Size(175, 50);
            this.btSpin.TabIndex = 6;
            this.btSpin.Text = "Spin Chamber";
            this.btSpin.UseVisualStyleBackColor = false;
            this.btSpin.Click += new System.EventHandler(this.btSpin_Click);
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.MistyRose;
            this.btLoad.BackgroundImage = global::ManinderWithGun.Properties.Resources.bulleticon_;
            this.btLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.ForeColor = System.Drawing.Color.Black;
            this.btLoad.Location = new System.Drawing.Point(451, 482);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(150, 50);
            this.btLoad.TabIndex = 5;
            this.btLoad.Text = "Load Bullet";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManinderWithGun.Properties.Resources.Screenshot;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1141, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.lbWasted);
            this.Controls.Add(this.btPlayAgain);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btFire);
            this.Controls.Add(this.btSpin);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.lbTotalScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbBullectCOunt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBullectCOunt;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbTotalScore;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSpin;
        private System.Windows.Forms.Button btFire;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btPlayAgain;
        private System.Windows.Forms.Label lbWasted;
    }
}