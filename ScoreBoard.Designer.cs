namespace BookWorm
{
    partial class ScoreBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreBoard));
            this.topPlayerLabel = new System.Windows.Forms.Label();
            this.topPlayerPanel = new System.Windows.Forms.Panel();
            this.nomTopPlayer5 = new System.Windows.Forms.Label();
            this.nomTopPlayer4 = new System.Windows.Forms.Label();
            this.nomTopPlayer3 = new System.Windows.Forms.Label();
            this.nomTopPlayer2 = new System.Windows.Forms.Label();
            this.nomTopPlayer1 = new System.Windows.Forms.Label();
            this.rang5Label = new System.Windows.Forms.Label();
            this.rang4Label = new System.Windows.Forms.Label();
            this.rang3Label = new System.Windows.Forms.Label();
            this.rang2Label = new System.Windows.Forms.Label();
            this.rang1Label = new System.Windows.Forms.Label();
            this.scoreTopPlayer5Label = new System.Windows.Forms.Label();
            this.scoreTopPlayer4Label = new System.Windows.Forms.Label();
            this.scoreTopPlayer3Label = new System.Windows.Forms.Label();
            this.scoreTopPlayer2Label = new System.Windows.Forms.Label();
            this.scoreTopPlayer1Label = new System.Windows.Forms.Label();
            this.topPlayerNamePanel = new System.Windows.Forms.Panel();
            this.topPlayerScorePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.topPlayerPanel.SuspendLayout();
            this.topPlayerNamePanel.SuspendLayout();
            this.topPlayerScorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPlayerLabel
            // 
            this.topPlayerLabel.AutoSize = true;
            this.topPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.topPlayerLabel.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPlayerLabel.ForeColor = System.Drawing.Color.White;
            this.topPlayerLabel.Location = new System.Drawing.Point(256, 170);
            this.topPlayerLabel.Name = "topPlayerLabel";
            this.topPlayerLabel.Size = new System.Drawing.Size(394, 77);
            this.topPlayerLabel.TabIndex = 0;
            this.topPlayerLabel.Text = "Top 5 joueurs";
            // 
            // topPlayerPanel
            // 
            this.topPlayerPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.topPlayerPanel.Controls.Add(this.topPlayerScorePanel);
            this.topPlayerPanel.Controls.Add(this.topPlayerNamePanel);
            this.topPlayerPanel.Controls.Add(this.rang5Label);
            this.topPlayerPanel.Controls.Add(this.rang4Label);
            this.topPlayerPanel.Controls.Add(this.rang3Label);
            this.topPlayerPanel.Controls.Add(this.rang2Label);
            this.topPlayerPanel.Controls.Add(this.rang1Label);
            this.topPlayerPanel.Location = new System.Drawing.Point(269, 263);
            this.topPlayerPanel.Name = "topPlayerPanel";
            this.topPlayerPanel.Size = new System.Drawing.Size(734, 373);
            this.topPlayerPanel.TabIndex = 1;
            // 
            // nomTopPlayer5
            // 
            this.nomTopPlayer5.AutoSize = true;
            this.nomTopPlayer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTopPlayer5.Location = new System.Drawing.Point(3, 286);
            this.nomTopPlayer5.Name = "nomTopPlayer5";
            this.nomTopPlayer5.Size = new System.Drawing.Size(118, 61);
            this.nomTopPlayer5.TabIndex = 14;
            this.nomTopPlayer5.Tag = "joueur5";
            this.nomTopPlayer5.Text = "N/A";
            // 
            // nomTopPlayer4
            // 
            this.nomTopPlayer4.AutoSize = true;
            this.nomTopPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTopPlayer4.Location = new System.Drawing.Point(3, 216);
            this.nomTopPlayer4.Name = "nomTopPlayer4";
            this.nomTopPlayer4.Size = new System.Drawing.Size(118, 61);
            this.nomTopPlayer4.TabIndex = 13;
            this.nomTopPlayer4.Tag = "joueur4";
            this.nomTopPlayer4.Text = "N/A";
            // 
            // nomTopPlayer3
            // 
            this.nomTopPlayer3.AutoSize = true;
            this.nomTopPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTopPlayer3.Location = new System.Drawing.Point(3, 144);
            this.nomTopPlayer3.Name = "nomTopPlayer3";
            this.nomTopPlayer3.Size = new System.Drawing.Size(118, 61);
            this.nomTopPlayer3.TabIndex = 12;
            this.nomTopPlayer3.Tag = "joueur3";
            this.nomTopPlayer3.Text = "N/A";
            // 
            // nomTopPlayer2
            // 
            this.nomTopPlayer2.AutoSize = true;
            this.nomTopPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTopPlayer2.Location = new System.Drawing.Point(3, 70);
            this.nomTopPlayer2.Name = "nomTopPlayer2";
            this.nomTopPlayer2.Size = new System.Drawing.Size(118, 61);
            this.nomTopPlayer2.TabIndex = 11;
            this.nomTopPlayer2.Tag = "joueur2";
            this.nomTopPlayer2.Text = "N/A";
            // 
            // nomTopPlayer1
            // 
            this.nomTopPlayer1.AutoSize = true;
            this.nomTopPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTopPlayer1.Location = new System.Drawing.Point(3, 0);
            this.nomTopPlayer1.Name = "nomTopPlayer1";
            this.nomTopPlayer1.Size = new System.Drawing.Size(118, 61);
            this.nomTopPlayer1.TabIndex = 10;
            this.nomTopPlayer1.Tag = "joueur1";
            this.nomTopPlayer1.Text = "N/A";
            // 
            // rang5Label
            // 
            this.rang5Label.AutoSize = true;
            this.rang5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rang5Label.Location = new System.Drawing.Point(3, 293);
            this.rang5Label.Name = "rang5Label";
            this.rang5Label.Size = new System.Drawing.Size(57, 61);
            this.rang5Label.TabIndex = 9;
            this.rang5Label.Text = "5";
            // 
            // rang4Label
            // 
            this.rang4Label.AutoSize = true;
            this.rang4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rang4Label.Location = new System.Drawing.Point(3, 223);
            this.rang4Label.Name = "rang4Label";
            this.rang4Label.Size = new System.Drawing.Size(57, 61);
            this.rang4Label.TabIndex = 8;
            this.rang4Label.Text = "4";
            // 
            // rang3Label
            // 
            this.rang3Label.AutoSize = true;
            this.rang3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rang3Label.Location = new System.Drawing.Point(3, 151);
            this.rang3Label.Name = "rang3Label";
            this.rang3Label.Size = new System.Drawing.Size(57, 61);
            this.rang3Label.TabIndex = 7;
            this.rang3Label.Text = "3";
            // 
            // rang2Label
            // 
            this.rang2Label.AutoSize = true;
            this.rang2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rang2Label.Location = new System.Drawing.Point(3, 77);
            this.rang2Label.Name = "rang2Label";
            this.rang2Label.Size = new System.Drawing.Size(57, 61);
            this.rang2Label.TabIndex = 6;
            this.rang2Label.Text = "2";
            // 
            // rang1Label
            // 
            this.rang1Label.AutoSize = true;
            this.rang1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rang1Label.Location = new System.Drawing.Point(3, 7);
            this.rang1Label.Name = "rang1Label";
            this.rang1Label.Size = new System.Drawing.Size(57, 61);
            this.rang1Label.TabIndex = 5;
            this.rang1Label.Text = "1";
            // 
            // scoreTopPlayer5Label
            // 
            this.scoreTopPlayer5Label.AutoSize = true;
            this.scoreTopPlayer5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTopPlayer5Label.Location = new System.Drawing.Point(3, 286);
            this.scoreTopPlayer5Label.Name = "scoreTopPlayer5Label";
            this.scoreTopPlayer5Label.Size = new System.Drawing.Size(118, 61);
            this.scoreTopPlayer5Label.TabIndex = 4;
            this.scoreTopPlayer5Label.Tag = "joueur5";
            this.scoreTopPlayer5Label.Text = "N/A";
            // 
            // scoreTopPlayer4Label
            // 
            this.scoreTopPlayer4Label.AutoSize = true;
            this.scoreTopPlayer4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTopPlayer4Label.Location = new System.Drawing.Point(3, 216);
            this.scoreTopPlayer4Label.Name = "scoreTopPlayer4Label";
            this.scoreTopPlayer4Label.Size = new System.Drawing.Size(118, 61);
            this.scoreTopPlayer4Label.TabIndex = 3;
            this.scoreTopPlayer4Label.Tag = "joueur4";
            this.scoreTopPlayer4Label.Text = "N/A";
            // 
            // scoreTopPlayer3Label
            // 
            this.scoreTopPlayer3Label.AutoSize = true;
            this.scoreTopPlayer3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTopPlayer3Label.Location = new System.Drawing.Point(3, 144);
            this.scoreTopPlayer3Label.Name = "scoreTopPlayer3Label";
            this.scoreTopPlayer3Label.Size = new System.Drawing.Size(118, 61);
            this.scoreTopPlayer3Label.TabIndex = 2;
            this.scoreTopPlayer3Label.Tag = "joueur3";
            this.scoreTopPlayer3Label.Text = "N/A";
            // 
            // scoreTopPlayer2Label
            // 
            this.scoreTopPlayer2Label.AutoSize = true;
            this.scoreTopPlayer2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTopPlayer2Label.Location = new System.Drawing.Point(3, 70);
            this.scoreTopPlayer2Label.Name = "scoreTopPlayer2Label";
            this.scoreTopPlayer2Label.Size = new System.Drawing.Size(118, 61);
            this.scoreTopPlayer2Label.TabIndex = 1;
            this.scoreTopPlayer2Label.Tag = "joueur2";
            this.scoreTopPlayer2Label.Text = "N/A";
            // 
            // scoreTopPlayer1Label
            // 
            this.scoreTopPlayer1Label.AutoSize = true;
            this.scoreTopPlayer1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTopPlayer1Label.Location = new System.Drawing.Point(3, 0);
            this.scoreTopPlayer1Label.Name = "scoreTopPlayer1Label";
            this.scoreTopPlayer1Label.Size = new System.Drawing.Size(118, 61);
            this.scoreTopPlayer1Label.TabIndex = 0;
            this.scoreTopPlayer1Label.Tag = "joueur1";
            this.scoreTopPlayer1Label.Text = "N/A";
            // 
            // topPlayerNamePanel
            // 
            this.topPlayerNamePanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.topPlayerNamePanel.Controls.Add(this.scoreTopPlayer5Label);
            this.topPlayerNamePanel.Controls.Add(this.scoreTopPlayer1Label);
            this.topPlayerNamePanel.Controls.Add(this.scoreTopPlayer2Label);
            this.topPlayerNamePanel.Controls.Add(this.scoreTopPlayer3Label);
            this.topPlayerNamePanel.Controls.Add(this.scoreTopPlayer4Label);
            this.topPlayerNamePanel.Location = new System.Drawing.Point(66, 8);
            this.topPlayerNamePanel.Name = "topPlayerNamePanel";
            this.topPlayerNamePanel.Size = new System.Drawing.Size(380, 365);
            this.topPlayerNamePanel.TabIndex = 15;
            // 
            // topPlayerScorePanel
            // 
            this.topPlayerScorePanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.topPlayerScorePanel.Controls.Add(this.nomTopPlayer5);
            this.topPlayerScorePanel.Controls.Add(this.nomTopPlayer1);
            this.topPlayerScorePanel.Controls.Add(this.nomTopPlayer2);
            this.topPlayerScorePanel.Controls.Add(this.nomTopPlayer4);
            this.topPlayerScorePanel.Controls.Add(this.nomTopPlayer3);
            this.topPlayerScorePanel.Location = new System.Drawing.Point(464, 8);
            this.topPlayerScorePanel.Name = "topPlayerScorePanel";
            this.topPlayerScorePanel.Size = new System.Drawing.Size(179, 365);
            this.topPlayerScorePanel.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(660, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retour au menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RetourAuMenuButton);
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topPlayerPanel);
            this.Controls.Add(this.topPlayerLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreBoard";
            this.Text = "BookWorm ScoreBoard";
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            this.topPlayerPanel.ResumeLayout(false);
            this.topPlayerPanel.PerformLayout();
            this.topPlayerNamePanel.ResumeLayout(false);
            this.topPlayerNamePanel.PerformLayout();
            this.topPlayerScorePanel.ResumeLayout(false);
            this.topPlayerScorePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topPlayerLabel;
        private System.Windows.Forms.Panel topPlayerPanel;
        private System.Windows.Forms.Label scoreTopPlayer5Label;
        private System.Windows.Forms.Label scoreTopPlayer4Label;
        private System.Windows.Forms.Label scoreTopPlayer3Label;
        private System.Windows.Forms.Label scoreTopPlayer2Label;
        private System.Windows.Forms.Label scoreTopPlayer1Label;
        private System.Windows.Forms.Label rang5Label;
        private System.Windows.Forms.Label rang4Label;
        private System.Windows.Forms.Label rang3Label;
        private System.Windows.Forms.Label rang2Label;
        private System.Windows.Forms.Label rang1Label;
        private System.Windows.Forms.Label nomTopPlayer5;
        private System.Windows.Forms.Label nomTopPlayer4;
        private System.Windows.Forms.Label nomTopPlayer3;
        private System.Windows.Forms.Label nomTopPlayer2;
        private System.Windows.Forms.Label nomTopPlayer1;
        private System.Windows.Forms.Panel topPlayerScorePanel;
        private System.Windows.Forms.Panel topPlayerNamePanel;
        private System.Windows.Forms.Button button1;
    }
}