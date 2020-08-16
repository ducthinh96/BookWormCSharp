namespace BookWorm
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Quitter = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.ScoreBoard = new System.Windows.Forms.Button();
            this.buttonLancerPartie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Quitter);
            this.panel1.Controls.Add(this.Settings);
            this.panel1.Controls.Add(this.ScoreBoard);
            this.panel1.Controls.Add(this.buttonLancerPartie);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 768);
            this.panel1.TabIndex = 0;
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.Color.Transparent;
            this.Quitter.FlatAppearance.BorderSize = 0;
            this.Quitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Quitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitter.ForeColor = System.Drawing.Color.Black;
            this.Quitter.Location = new System.Drawing.Point(430, 551);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(592, 182);
            this.Quitter.TabIndex = 3;
            this.Quitter.Text = "EXIT";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Location = new System.Drawing.Point(463, 369);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(559, 181);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            // 
            // ScoreBoard
            // 
            this.ScoreBoard.BackColor = System.Drawing.Color.Transparent;
            this.ScoreBoard.FlatAppearance.BorderSize = 0;
            this.ScoreBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ScoreBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ScoreBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreBoard.Location = new System.Drawing.Point(448, 218);
            this.ScoreBoard.Name = "ScoreBoard";
            this.ScoreBoard.Size = new System.Drawing.Size(575, 147);
            this.ScoreBoard.TabIndex = 1;
            this.ScoreBoard.Text = "ScoreBoard";
            this.ScoreBoard.UseVisualStyleBackColor = false;
            // 
            // buttonLancerPartie
            // 
            this.buttonLancerPartie.BackColor = System.Drawing.Color.Transparent;
            this.buttonLancerPartie.FlatAppearance.BorderSize = 0;
            this.buttonLancerPartie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLancerPartie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLancerPartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLancerPartie.Location = new System.Drawing.Point(513, 57);
            this.buttonLancerPartie.Name = "buttonLancerPartie";
            this.buttonLancerPartie.Size = new System.Drawing.Size(510, 159);
            this.buttonLancerPartie.TabIndex = 0;
            this.buttonLancerPartie.Text = "buttonLancerPartie";
            this.buttonLancerPartie.UseVisualStyleBackColor = false;
            this.buttonLancerPartie.Click += new System.EventHandler(this.buttonLancerPartie_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1026, 761);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.Text = "BookWorm Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button ScoreBoard;
        private System.Windows.Forms.Button buttonLancerPartie;
    }
}

