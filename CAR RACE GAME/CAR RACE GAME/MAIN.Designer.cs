namespace CAR_RACE_GAME
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.enemey1 = new System.Windows.Forms.PictureBox();
            this.enemey2 = new System.Windows.Forms.PictureBox();
            this.enemey3 = new System.Windows.Forms.PictureBox();
            this.lblgame = new System.Windows.Forms.Label();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.lblcoin = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnretry = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemey1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemey3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox2.Location = new System.Drawing.Point(183, -75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 107);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Location = new System.Drawing.Point(183, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 107);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox3.Location = new System.Drawing.Point(183, 296);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 107);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox4.Location = new System.Drawing.Point(183, 419);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 107);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox5.Location = new System.Drawing.Point(372, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 458);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 458);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(65, 378);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(48, 63);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 7;
            this.car.TabStop = false;
            // 
            // enemey1
            // 
            this.enemey1.BackColor = System.Drawing.Color.Transparent;
            this.enemey1.Image = ((System.Drawing.Image)(resources.GetObject("enemey1.Image")));
            this.enemey1.Location = new System.Drawing.Point(16, 44);
            this.enemey1.Name = "enemey1";
            this.enemey1.Size = new System.Drawing.Size(48, 63);
            this.enemey1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemey1.TabIndex = 8;
            this.enemey1.TabStop = false;
            // 
            // enemey2
            // 
            this.enemey2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enemey2.BackColor = System.Drawing.Color.Transparent;
            this.enemey2.Image = ((System.Drawing.Image)(resources.GetObject("enemey2.Image")));
            this.enemey2.Location = new System.Drawing.Point(217, 133);
            this.enemey2.Name = "enemey2";
            this.enemey2.Size = new System.Drawing.Size(48, 63);
            this.enemey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemey2.TabIndex = 9;
            this.enemey2.TabStop = false;
            // 
            // enemey3
            // 
            this.enemey3.BackColor = System.Drawing.Color.Transparent;
            this.enemey3.Image = ((System.Drawing.Image)(resources.GetObject("enemey3.Image")));
            this.enemey3.Location = new System.Drawing.Point(272, 369);
            this.enemey3.Name = "enemey3";
            this.enemey3.Size = new System.Drawing.Size(48, 63);
            this.enemey3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemey3.TabIndex = 10;
            this.enemey3.TabStop = false;
            // 
            // lblgame
            // 
            this.lblgame.AutoSize = true;
            this.lblgame.BackColor = System.Drawing.Color.Red;
            this.lblgame.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgame.ForeColor = System.Drawing.Color.White;
            this.lblgame.Location = new System.Drawing.Point(60, 164);
            this.lblgame.Name = "lblgame";
            this.lblgame.Size = new System.Drawing.Size(254, 36);
            this.lblgame.TabIndex = 11;
            this.lblgame.Text = "GAME OVER-!!!";
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Transparent;
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(31, 205);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(30, 30);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 12;
            this.coin3.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(83, 60);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(30, 30);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 13;
            this.coin1.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(304, 60);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(30, 30);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 14;
            this.coin2.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.Transparent;
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(256, 296);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(30, 30);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 15;
            this.coin4.TabStop = false;
            // 
            // lblcoin
            // 
            this.lblcoin.AutoSize = true;
            this.lblcoin.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoin.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblcoin.Location = new System.Drawing.Point(11, 0);
            this.lblcoin.Name = "lblcoin";
            this.lblcoin.Size = new System.Drawing.Size(112, 22);
            this.lblcoin.TabIndex = 16;
            this.lblcoin.Text = "POINTS : 0";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox7.Location = new System.Drawing.Point(183, 44);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 107);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // btnretry
            // 
            this.btnretry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnretry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnretry.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretry.ForeColor = System.Drawing.Color.White;
            this.btnretry.Location = new System.Drawing.Point(77, 208);
            this.btnretry.Name = "btnretry";
            this.btnretry.Size = new System.Drawing.Size(100, 30);
            this.btnretry.TabIndex = 18;
            this.btnretry.Text = "RETRY";
            this.btnretry.UseVisualStyleBackColor = false;
            this.btnretry.Click += new System.EventHandler(this.btnretry_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(199, 208);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 30);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblscore.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Black;
            this.lblscore.Location = new System.Drawing.Point(59, 109);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(171, 42);
            this.lblscore.TabIndex = 20;
            this.lblscore.Text = "SCORE : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnretry);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblcoin);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.lblgame);
            this.Controls.Add(this.enemey3);
            this.Controls.Add(this.enemey2);
            this.Controls.Add(this.enemey1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAR RACE GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemey1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemey3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemey1;
        private System.Windows.Forms.PictureBox enemey2;
        private System.Windows.Forms.PictureBox enemey3;
        private System.Windows.Forms.Label lblgame;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.Label lblcoin;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnretry;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblscore;
    }
}

