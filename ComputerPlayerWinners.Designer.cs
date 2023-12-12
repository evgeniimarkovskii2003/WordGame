namespace WordGame
{
    partial class ComputerPlayerWinners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerPlayerWinners));
            this.panel1 = new System.Windows.Forms.Panel();
            this.level = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.AnotherLevel = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.winner = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WordGame.Properties.Resources.rm251_mind_01_a;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.level);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.rating);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ToMainMenu);
            this.panel1.Controls.Add(this.AnotherLevel);
            this.panel1.Controls.Add(this.PlayAgain);
            this.panel1.Controls.Add(this.word);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.winner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 450);
            this.panel1.TabIndex = 0;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.BackColor = System.Drawing.Color.Transparent;
            this.level.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.level.Location = new System.Drawing.Point(472, 156);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(215, 37);
            this.level.TabIndex = 25;
            this.level.Text = "легендарный";
            this.level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label.Location = new System.Drawing.Point(301, 156);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(152, 37);
            this.label.TabIndex = 24;
            this.label.Text = "Уровень:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.rating.Location = new System.Drawing.Point(530, 213);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(68, 37);
            this.rating.TabIndex = 23;
            this.rating.Text = "100";
            this.rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(301, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ваш рейтинг:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(99)))), ((int)(((byte)(194)))));
            this.ToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.ToMainMenu.Location = new System.Drawing.Point(568, 293);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(266, 45);
            this.ToMainMenu.TabIndex = 21;
            this.ToMainMenu.Text = "В главное меню";
            this.ToMainMenu.UseVisualStyleBackColor = false;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // AnotherLevel
            // 
            this.AnotherLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(99)))), ((int)(((byte)(194)))));
            this.AnotherLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnotherLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnotherLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.AnotherLevel.Location = new System.Drawing.Point(302, 293);
            this.AnotherLevel.Name = "AnotherLevel";
            this.AnotherLevel.Size = new System.Drawing.Size(243, 45);
            this.AnotherLevel.TabIndex = 20;
            this.AnotherLevel.Text = "Другой уровень";
            this.AnotherLevel.UseVisualStyleBackColor = false;
            this.AnotherLevel.Click += new System.EventHandler(this.AnotherLevel_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(99)))), ((int)(((byte)(194)))));
            this.PlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.PlayAgain.Location = new System.Drawing.Point(28, 293);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(243, 45);
            this.PlayAgain.TabIndex = 19;
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
            this.word.Location = new System.Drawing.Point(429, 104);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(144, 37);
            this.word.TabIndex = 18;
            this.word.Text = "машина ";
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(301, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Слово:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.BackColor = System.Drawing.Color.Transparent;
            this.winner.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.winner.Location = new System.Drawing.Point(293, 28);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(411, 49);
            this.winner.TabIndex = 15;
            this.winner.Text = "Победил компьютер";
            this.winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComputerPlayerWinners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ComputerPlayerWinners";
            this.Text = "WordGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComputerPlayerWinners_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label word;
        public System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToMainMenu;
        private System.Windows.Forms.Button AnotherLevel;
        private System.Windows.Forms.Button PlayAgain;
        public System.Windows.Forms.Label winner;
        public System.Windows.Forms.Label level;
        private System.Windows.Forms.Label label;
    }
}