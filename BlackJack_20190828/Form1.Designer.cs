namespace BlackJack_20190828
{
    partial class BlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            this.btnDeal = new System.Windows.Forms.Button();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.lblLosses = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblWinsCounter = new System.Windows.Forms.Label();
            this.lblLossesCounter = new System.Windows.Forms.Label();
            this.lblTiesCounter = new System.Windows.Forms.Label();
            this.lblPlayerText = new System.Windows.Forms.Label();
            this.lblDealerText = new System.Windows.Forms.Label();
            this.lblStartGame = new System.Windows.Forms.Button();
            this.lblQuit = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.Honeydew;
            this.btnDeal.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(395, 126);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(86, 35);
            this.btnDeal.TabIndex = 0;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.BtnDeal_Click);
            // 
            // picBox4
            // 
            this.picBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox4.BackgroundImage")));
            this.picBox4.Location = new System.Drawing.Point(727, 126);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(79, 125);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox4.TabIndex = 3;
            this.picBox4.TabStop = false;
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(621, 126);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(79, 125);
            this.picBox3.TabIndex = 4;
            this.picBox3.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(59, 126);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(79, 125);
            this.picBox1.TabIndex = 5;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(168, 126);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(79, 125);
            this.picBox2.TabIndex = 6;
            this.picBox2.TabStop = false;
            // 
            // lblLosses
            // 
            this.lblLosses.BackColor = System.Drawing.Color.Tomato;
            this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(411, 26);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(65, 15);
            this.lblLosses.TabIndex = 7;
            this.lblLosses.Text = "Losses";
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Honeydew;
            this.btnHit.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(341, 179);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(86, 35);
            this.btnHit.TabIndex = 8;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.BackColor = System.Drawing.Color.Honeydew;
            this.btnStay.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(450, 179);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(86, 35);
            this.btnStay.TabIndex = 9;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = false;
            this.btnStay.Click += new System.EventHandler(this.BtnStay_Click);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerScore.Location = new System.Drawing.Point(110, 57);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(88, 66);
            this.lblPlayerScore.TabIndex = 10;
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerScore.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.ForeColor = System.Drawing.Color.Red;
            this.lblDealerScore.Location = new System.Drawing.Point(674, 57);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(88, 65);
            this.lblDealerScore.TabIndex = 11;
            // 
            // lblWins
            // 
            this.lblWins.BackColor = System.Drawing.Color.Tomato;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(299, 26);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(40, 15);
            this.lblWins.TabIndex = 12;
            this.lblWins.Text = "Wins";
            // 
            // lblTies
            // 
            this.lblTies.BackColor = System.Drawing.Color.Tomato;
            this.lblTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(532, 26);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(40, 15);
            this.lblTies.TabIndex = 13;
            this.lblTies.Text = "Ties";
            // 
            // lblWinsCounter
            // 
            this.lblWinsCounter.AutoSize = true;
            this.lblWinsCounter.BackColor = System.Drawing.Color.Tomato;
            this.lblWinsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinsCounter.Location = new System.Drawing.Point(299, 54);
            this.lblWinsCounter.Name = "lblWinsCounter";
            this.lblWinsCounter.Size = new System.Drawing.Size(51, 16);
            this.lblWinsCounter.TabIndex = 14;
            this.lblWinsCounter.Text = "label1";
            // 
            // lblLossesCounter
            // 
            this.lblLossesCounter.AutoSize = true;
            this.lblLossesCounter.BackColor = System.Drawing.Color.Tomato;
            this.lblLossesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossesCounter.Location = new System.Drawing.Point(411, 54);
            this.lblLossesCounter.Name = "lblLossesCounter";
            this.lblLossesCounter.Size = new System.Drawing.Size(51, 16);
            this.lblLossesCounter.TabIndex = 15;
            this.lblLossesCounter.Text = "label1";
            // 
            // lblTiesCounter
            // 
            this.lblTiesCounter.AutoSize = true;
            this.lblTiesCounter.BackColor = System.Drawing.Color.Tomato;
            this.lblTiesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiesCounter.Location = new System.Drawing.Point(532, 54);
            this.lblTiesCounter.Name = "lblTiesCounter";
            this.lblTiesCounter.Size = new System.Drawing.Size(51, 16);
            this.lblTiesCounter.TabIndex = 16;
            this.lblTiesCounter.Text = "label1";
            // 
            // lblPlayerText
            // 
            this.lblPlayerText.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerText.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerText.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerText.Location = new System.Drawing.Point(54, 275);
            this.lblPlayerText.Name = "lblPlayerText";
            this.lblPlayerText.Size = new System.Drawing.Size(261, 262);
            this.lblPlayerText.TabIndex = 17;
            // 
            // lblDealerText
            // 
            this.lblDealerText.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerText.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerText.ForeColor = System.Drawing.Color.Red;
            this.lblDealerText.Location = new System.Drawing.Point(598, 275);
            this.lblDealerText.Name = "lblDealerText";
            this.lblDealerText.Size = new System.Drawing.Size(271, 262);
            this.lblDealerText.TabIndex = 18;
            // 
            // lblStartGame
            // 
            this.lblStartGame.BackColor = System.Drawing.Color.PaleGreen;
            this.lblStartGame.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.Location = new System.Drawing.Point(352, 207);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(135, 67);
            this.lblStartGame.TabIndex = 19;
            this.lblStartGame.Text = "Start";
            this.lblStartGame.UseVisualStyleBackColor = false;
            this.lblStartGame.Click += new System.EventHandler(this.LblStartGame_Click);
            // 
            // lblQuit
            // 
            this.lblQuit.BackColor = System.Drawing.Color.Honeydew;
            this.lblQuit.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuit.Location = new System.Drawing.Point(395, 415);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(86, 35);
            this.lblQuit.TabIndex = 20;
            this.lblQuit.Text = "Quit";
            this.lblQuit.UseVisualStyleBackColor = false;
            this.lblQuit.Click += new System.EventHandler(this.LblQuit_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.lblStartGame);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(841, 521);
            this.pnlMain.TabIndex = 21;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 546);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblQuit);
            this.Controls.Add(this.lblDealerText);
            this.Controls.Add(this.lblPlayerText);
            this.Controls.Add(this.lblTiesCounter);
            this.Controls.Add(this.lblLossesCounter);
            this.Controls.Add(this.lblWinsCounter);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.btnDeal);
            this.MaximumSize = new System.Drawing.Size(882, 585);
            this.MinimumSize = new System.Drawing.Size(882, 585);
            this.Name = "BlackJack";
            this.Text = "Black Jack Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.PictureBox picBox4;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblWinsCounter;
        private System.Windows.Forms.Label lblLossesCounter;
        private System.Windows.Forms.Label lblTiesCounter;
        private System.Windows.Forms.Label lblPlayerText;
        private System.Windows.Forms.Label lblDealerText;
        private System.Windows.Forms.Button lblStartGame;
        private System.Windows.Forms.Button lblQuit;
        private System.Windows.Forms.Panel pnlMain;
    }
}

