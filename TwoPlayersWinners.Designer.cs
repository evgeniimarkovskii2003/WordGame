namespace WordGame
{
    partial class TwoPlayersWinners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoPlayersWinners));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberPlayersWinner = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WordGame.Properties.Resources.rm251_mind_01_a;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ToMainMenu);
            this.panel1.Controls.Add(this.PlayAgain);
            this.panel1.Controls.Add(this.word);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NumberPlayersWinner);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 387);
            this.panel1.TabIndex = 0;
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(99)))), ((int)(((byte)(194)))));
            this.ToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.ToMainMenu.Location = new System.Drawing.Point(356, 206);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(265, 45);
            this.ToMainMenu.TabIndex = 19;
            this.ToMainMenu.Text = "В главное меню";
            this.ToMainMenu.UseVisualStyleBackColor = false;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(99)))), ((int)(((byte)(194)))));
            this.PlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.PlayAgain.Location = new System.Drawing.Point(53, 206);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(243, 45);
            this.PlayAgain.TabIndex = 18;
            this.PlayAgain.Text = "Играть еще раз";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.BackColor = System.Drawing.Color.Transparent;
            this.word.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.word.Location = new System.Drawing.Point(326, 142);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(144, 37);
            this.word.TabIndex = 17;
            this.word.Text = "машина ";
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(197, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Слово:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberPlayersWinner
            // 
            this.NumberPlayersWinner.AutoSize = true;
            this.NumberPlayersWinner.BackColor = System.Drawing.Color.Transparent;
            this.NumberPlayersWinner.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPlayersWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.NumberPlayersWinner.Location = new System.Drawing.Point(505, 75);
            this.NumberPlayersWinner.Name = "NumberPlayersWinner";
            this.NumberPlayersWinner.Size = new System.Drawing.Size(34, 37);
            this.NumberPlayersWinner.TabIndex = 15;
            this.NumberPlayersWinner.Text = "1";
            this.NumberPlayersWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(197, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Победил игрок № ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TwoPlayersWinners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 387);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TwoPlayersWinners";
            this.Text = "WordGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwoPlayersWinners_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToMainMenu;
        private System.Windows.Forms.Button PlayAgain;
        public System.Windows.Forms.Label word;
        public System.Windows.Forms.Label NumberPlayersWinner;
    }
}