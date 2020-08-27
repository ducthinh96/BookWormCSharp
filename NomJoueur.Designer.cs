namespace BookWorm
{
    partial class NomJoueur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NomJoueur));
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.confirmPlayerNameButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTextBox.Location = new System.Drawing.Point(378, 208);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(309, 49);
            this.playerNameTextBox.TabIndex = 0;
            this.playerNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tkEnterDown);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(392, 161);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(270, 33);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Entrez votre nom";
            // 
            // confirmPlayerNameButton
            // 
            this.confirmPlayerNameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmPlayerNameButton.BackgroundImage")));
            this.confirmPlayerNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmPlayerNameButton.FlatAppearance.BorderSize = 0;
            this.confirmPlayerNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmPlayerNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmPlayerNameButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPlayerNameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmPlayerNameButton.Location = new System.Drawing.Point(425, 286);
            this.confirmPlayerNameButton.Name = "confirmPlayerNameButton";
            this.confirmPlayerNameButton.Size = new System.Drawing.Size(206, 65);
            this.confirmPlayerNameButton.TabIndex = 2;
            this.confirmPlayerNameButton.Text = "C\'est parti !";
            this.confirmPlayerNameButton.UseVisualStyleBackColor = true;
            this.confirmPlayerNameButton.Click += new System.EventHandler(this.ConfirmPlayerNameButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(294, 404);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(695, 345);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // NomJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 761);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.confirmPlayerNameButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.playerNameTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NomJoueur";
            this.Text = "BookWorm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button confirmPlayerNameButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}